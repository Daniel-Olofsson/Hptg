using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml;
using System.IO;

namespace Engine
{
    public class Player : LivingCreature
    {
        private int _gold;
        private int _expPoints;
        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }
        public int ExperiencePoints 
        {
            get { return _expPoints; } 
            private set
            {
                _expPoints = value;
                OnPropertyChanged("ExperiencePoints");
                OnPropertyChanged("Level");
            }
        }
        public int Level
        {
            get { return ((ExperiencePoints / 100) + 1); }
        }
        public Location CurrentLocation { get; set; }
        public int CurrentMana { get; set; }
        public int MaximumMana { get; set; }
        public int MaxFuel { get; set; }
        public int CurrentFuel { get; set; }
        public List<InventoryItem> Inventory { get; set;}
        public List<PlayerQuest> Quests { get; set; }
        private Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int currentMana, int maximumMana, int maxFuel, int currentFuel) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            CurrentMana = currentMana;
            MaximumMana = maximumMana;
            MaxFuel = maxFuel;
            CurrentFuel = currentFuel;
            
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }


        public static Player CreateDefaultPlayer()
        {
            Player player = new Player(10, 10, 25, 0, 10, 10, 30, 30 );
            player.Inventory.Add(new InventoryItem(Universe.ItemByID(Universe.ITEM_ID_HALFBROKEN_BLASTER), 1));
            player.Inventory.Add(new InventoryItem(Universe.ItemByID(Universe.SPELL_ID_FIREBALL), 1));
            player.CurrentLocation = Universe.LocationByID(Universe.LOCATION_ID_SHEEB);

            return player;
        }
        public static Player CreatePlayerFromXmlString(string xmlPlayerData)
        {
            try
            {
                XmlDocument playerData = new XmlDocument();

                playerData.LoadXml(xmlPlayerData);

                int currentHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentHitPoints").InnerText);
                int maximumHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/MaximumHitPoints").InnerText);
                int gold = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Gold").InnerText);
                int experiencePoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/ExperiencePoints").InnerText);
                int currentMana = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentMana").InnerText);
                int maximumMana = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/MaximumMana").InnerText);
                int maxFuel = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/MaxFuel").InnerText);
                int currentFuel = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentFuel").InnerText);

                Player player = new Player(currentHitPoints, maximumHitPoints, gold, experiencePoints, currentMana, maximumMana, maxFuel, currentFuel);

                int currentLocationID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentLocation").InnerText);
                player.CurrentLocation = Universe.LocationByID(currentLocationID);

                foreach (XmlNode node in playerData.SelectNodes("/Player/InventoryItems/InventoryItem"))
                {
                    int id = Convert.ToInt32(node.Attributes["ID"].Value);
                    int quantity = Convert.ToInt32(node.Attributes["Quantity"].Value);

                    for (int i = 0; i < quantity; i++)
                    {
                        player.AddItemToInventory(Universe.ItemByID(id));
                    }
                }

                foreach (XmlNode node in playerData.SelectNodes("/Player/PlayerQuests/PlayerQuest"))
                {
                    int id = Convert.ToInt32(node.Attributes["ID"].Value);
                    bool isCompleted = Convert.ToBoolean(node.Attributes["IsCompleted"].Value);

                    PlayerQuest playerQuest = new PlayerQuest(Universe.QuestByID(id));
                    playerQuest.IsCompleted = isCompleted;

                    player.Quests.Add(playerQuest);
                }

                return player;
            }
            catch
            {
                // If there was an error with the XML data, return a default player object
                return Player.CreateDefaultPlayer();
            }
        }


        public void AddExpPoints(int experiencePointsToAdd)
        {
            ExperiencePoints += experiencePointsToAdd;
            MaximumHitPoints = (Level * 10);
        }

        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if(location.ItemRequierdToEnter == null)
            {
                //there is no req item for this location so return true
                return true;
            }
            return Inventory.Exists(ii => ii.Details.ID == location.ItemRequierdToEnter.ID);

        }

        public bool HasThisQuest(Quest quest)
        {
            return Quests.Exists(pq => pq.Details.ID == quest.ID);
        }

        public bool CompletedThisQuest(Quest quest)
        {
            foreach(PlayerQuest playerQuest in Quests)
            {
                if(playerQuest.Details.ID == quest.ID)
                {
                    return playerQuest.IsCompleted;
                }
            }

            return false;
        }

        public bool HasAllQuestCompletionItems(Quest quest)
        {
            // se if the player has all the items needed for completion (quest)
            foreach(QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                bool foundItemInPlayersInventory = false;


                //check each item in inv and see if if its enough
                if (!Inventory.Exists(ii => ii.Details.ID == qci.Details.ID && ii.Quantity >= qci.Quantity))
                {
                    return false;
                }
            }
            // if we got here then the player must have all the items
            return true;
        }

        public void RemoveQuestCompletionItems(Quest quest)
        {
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                InventoryItem item = Inventory.SingleOrDefault(ii => ii.Details.ID == qci.Details.ID);

                if(item != null)
                {
                    item.Quantity -= qci.Quantity;
                }
            }
        }

        public void AddItemToInventory(Item itemToAdd)
        {
            InventoryItem item = Inventory.SingleOrDefault(ii => ii.Details.ID == itemToAdd.ID);

            if(item == null)
            {
                Inventory.Add(new InventoryItem(itemToAdd, 1));
            }
            else
            {
                item.Quantity++;
            }
        }

        public void MarkQuestCompleted(Quest quest)
        {
            // Find the quest in the player's quest list
            PlayerQuest playerQuest = Quests.SingleOrDefault(pq => pq.Details.ID == quest.ID);

            if(playerQuest != null)
            {
                playerQuest.IsCompleted = true;
            }
        }
        public string ToXmlString()
        {
            XmlDocument playerData = new XmlDocument();

            // Create the top-level XML node
            XmlNode player = playerData.CreateElement("Player");
            playerData.AppendChild(player);

            // Create the "Stats" child node to hold the other player statistics nodes
            XmlNode stats = playerData.CreateElement("Stats");
            player.AppendChild(stats);

            // Create the child nodes for the "Stats" node
            XmlNode currentHitPoints = playerData.CreateElement("CurrentHitPoints");
            currentHitPoints.AppendChild(playerData.CreateTextNode(this.CurrentHitPoints.ToString()));
            stats.AppendChild(currentHitPoints);

            XmlNode maximumHitPoints = playerData.CreateElement("MaximumHitPoints");
            maximumHitPoints.AppendChild(playerData.CreateTextNode(this.MaximumHitPoints.ToString()));
            stats.AppendChild(maximumHitPoints);

            XmlNode gold = playerData.CreateElement("Gold");
            gold.AppendChild(playerData.CreateTextNode(this.Gold.ToString()));
            stats.AppendChild(gold);

            XmlNode experiencePoints = playerData.CreateElement("ExperiencePoints");
            experiencePoints.AppendChild(playerData.CreateTextNode(this.ExperiencePoints.ToString()));
            stats.AppendChild(experiencePoints);

            XmlNode currentLocation = playerData.CreateElement("CurrentLocation");
            currentLocation.AppendChild(playerData.CreateTextNode(this.CurrentLocation.ID.ToString()));
            stats.AppendChild(currentLocation);

            XmlNode currentMana = playerData.CreateElement("CurrentMana");
            currentMana.AppendChild(playerData.CreateTextNode(this.CurrentMana.ToString()));
            stats.AppendChild(currentMana);

            XmlNode maximumMana = playerData.CreateElement("MaximumMana");
            maximumMana.AppendChild(playerData.CreateTextNode(this.MaximumMana.ToString()));
            stats.AppendChild(maximumMana);

            XmlNode currentFuel = playerData.CreateElement("CurrentFuel");
            currentFuel.AppendChild(playerData.CreateTextNode(this.CurrentFuel.ToString()));
            stats.AppendChild(currentFuel);

            XmlNode maxFuel = playerData.CreateElement("MaxFuel");
            maxFuel.AppendChild(playerData.CreateTextNode(this.MaxFuel.ToString()));
            stats.AppendChild(maxFuel);

            // Create the "InventoryItems" child node to hold each InventoryItem node
            XmlNode inventoryItems = playerData.CreateElement("InventoryItems");
            player.AppendChild(inventoryItems);

            // Create an "InventoryItem" node for each item in the player's inventory
            foreach (InventoryItem item in this.Inventory)
            {
                XmlNode inventoryItem = playerData.CreateElement("InventoryItem");

                XmlAttribute idAttribute = playerData.CreateAttribute("ID");
                idAttribute.Value = item.Details.ID.ToString();
                inventoryItem.Attributes.Append(idAttribute);

                XmlAttribute quantityAttribute = playerData.CreateAttribute("Quantity");
                quantityAttribute.Value = item.Quantity.ToString();
                inventoryItem.Attributes.Append(quantityAttribute);

                inventoryItems.AppendChild(inventoryItem);
            }

            // Create the "PlayerQuests" child node to hold each PlayerQuest node
            XmlNode playerQuests = playerData.CreateElement("PlayerQuests");
            player.AppendChild(playerQuests);

            // Create a "PlayerQuest" node for each quest the player has acquired
            foreach (PlayerQuest quest in this.Quests)
            {
                XmlNode playerQuest = playerData.CreateElement("PlayerQuest");

                XmlAttribute idAttribute = playerData.CreateAttribute("ID");
                idAttribute.Value = quest.Details.ID.ToString();
                playerQuest.Attributes.Append(idAttribute);

                XmlAttribute isCompletedAttribute = playerData.CreateAttribute("IsCompleted");
                isCompletedAttribute.Value = quest.IsCompleted.ToString();
                playerQuest.Attributes.Append(isCompletedAttribute);

                playerQuests.AppendChild(playerQuest);
            }

            return playerData.InnerXml; // The XML document, as a string, so we can save the data to disk
        }
    }
}
