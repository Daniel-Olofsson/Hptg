using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;
namespace Heroespathtoglory
{
    public partial class Heroespathtoglory : Form
    {
        private const string PLAYER_DATA_FILE_NAME = "PlayerData.xml";
        //creates a player obj
        public string assetsFolder = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets";
        private Player _player;
        private Monster _currentMonster;
        private ImageList imagelist;
        public Heroespathtoglory()
        {
            InitializeComponent();
            
            if(File.Exists(PLAYER_DATA_FILE_NAME))
            {
                _player = Player.CreatePlayerFromXmlString(File.ReadAllText(PLAYER_DATA_FILE_NAME));
            }
            else
            {
                _player = Player.CreateDefaultPlayer();
            }
            
            // Starting pos
            MoveTo(Universe.LocationByID(Universe.LOCATION_ID_SHEEB));
            
            imagelist = new ImageList();

            //assigning values to labels
            UpdatePlayerStats();


        }
        //UP BTN
        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToGoUp);

        }
        // DOWN BTN
        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToGoDown);
        }
        //LEFT BTN
        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToGoLeft);
        }
        //RIGHT BTN
        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToGoRight);
        }
        private void MoveTo(Location newLocation)
        {
            // does the player have the right item to enter


            if (!_player.HasRequiredItemToEnterThisLocation(newLocation))
            {
                    //not the req item
                rbtMessages.Text += "You must have a " + newLocation.ItemRequierdToEnter.Name + " to enter this location." + Environment.NewLine;
                return;
            }
            

            //update the players current location
            _player.CurrentLocation = newLocation;

            // update planet picture
            string assetsFolder = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets";
            string planetPath = assetsFolder + "\\" + newLocation.PlanetImage;

            pictureBox1.Image = new Bitmap(planetPath);


            //show hide available movment buttons
            btnUp.Visible = (newLocation.LocationToGoUp != null);
            btnDown.Visible = (newLocation.LocationToGoDown != null);
            btnRight.Visible = (newLocation.LocationToGoRight != null);
            btnLeft.Visible = (newLocation.LocationToGoLeft != null);

            //display the current location and description
            rbtLocation.Text = newLocation.Name + Environment.NewLine;
            rbtLocation.Text += newLocation.Description + Environment.NewLine;
            
            
            _player.CurrentFuel -= 1;
            lblFuel.Text = _player.CurrentFuel.ToString();
            if(_player.CurrentFuel <= 0)
            {
                
                rbtMessages.Text += "You ran out of fuel before you got to the new location! Starvation and the empty void makes a perfect recipe for madness." + Environment.NewLine;
                rbtMessages.Text += "You died" + Environment.NewLine;
                rbtMessages.Text += "You wake up in another clone at home" + Environment.NewLine;
                _player.CurrentFuel += 10;
                MoveTo(Universe.LocationByID(Universe.LOCATION_ID_SHEEB));
                UpdatePlayerStats();

            }


            // heal the player if not maximum points
            if (_player.CurrentHitPoints < _player.MaximumHitPoints)
            {
                _player.CurrentHitPoints += 1;
                UpdatePlayerStats();
            }
            UpdatePlayerStats();

            //does the location have a quest
            if (newLocation.QuestAvailableHere != null)
            {
                //se if the plater already has the quest
                bool playerAlreadyHasQuest = _player.HasThisQuest(newLocation.QuestAvailableHere);
                bool playerAlreadyCompletedQuest = _player.CompletedThisQuest(newLocation.QuestAvailableHere);


                //see if the player already has the quest
                if (playerAlreadyHasQuest)
                {

                    //if the player has not completed the quest yet
                    if (!playerAlreadyCompletedQuest)
                    {
                        // items needed
                        bool playerHasAllItemsToCompleteQuest = _player.HasAllQuestCompletionItems(newLocation.QuestAvailableHere);


                        //player have the req items
                        if (playerHasAllItemsToCompleteQuest)
                        {
                            //Display msg
                            rbtMessages.Text += Environment.NewLine;
                            rbtMessages.Text += "You completed ' " + newLocation.QuestAvailableHere.Name + " ' quest!" + Environment.NewLine;
                            //remove item
                            _player.RemoveQuestCompletionItems(newLocation.QuestAvailableHere);
                            // give the quest reward
                            rbtMessages.Text += "You receive: " + Environment.NewLine;
                            rbtMessages.Text += newLocation.QuestAvailableHere.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;
                            rbtMessages.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " gold" + Environment.NewLine;
                            rbtMessages.Text += newLocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;
                            rbtMessages.Text += Environment.NewLine;
                            _player.AddExpPoints(newLocation.QuestAvailableHere.RewardExperiencePoints);

                            _player.Gold += newLocation.QuestAvailableHere.RewardGold;
                            //add reward item
                            _player.AddItemToInventory(newLocation.QuestAvailableHere.RewardItem);
                            //mark completed
                            _player.MarkQuestCompleted(newLocation.QuestAvailableHere);
                            UpdatePlayerStats();
                        }

                    }

                }
                else
                {
                    // does not have the quest
                    // display msg

                    rbtMessages.Text += "You recive the " + newLocation.QuestAvailableHere.Name + "quest." + Environment.NewLine;
                    rbtMessages.Text += newLocation.QuestAvailableHere.Description + Environment.NewLine;
                    rbtMessages.Text += "Complete the quest and return with:" + Environment.NewLine;
                    foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                    {
                        if (qci.Quantity == 1)
                        {
                            rbtMessages.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            rbtMessages.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    rbtMessages.Text += Environment.NewLine;

                    // add the quest to players quest list
                    _player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere));

                }


            }
            // does the location have a monster
            if (newLocation.MonsterLivingHere != null)
            {
                rbtMessages.Text += "Dear Heavens, a grotesque " + newLocation.MonsterLivingHere.Name + Environment.NewLine;

                // make a new monster

                Monster standardMonster = Universe.MonsterByID(newLocation.MonsterLivingHere.ID);

                _currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.MaximumDamage, standardMonster.RewardExperiencePoints, standardMonster.RewardGold, standardMonster.CurrentHitPoints, standardMonster.MaximumHitPoints);

                foreach (LootItem lootItem in standardMonster.LootTable)
                {
                    _currentMonster.LootTable.Add(lootItem);
                }

                cboWeapons.Visible = true;
                cboPotions.Visible = true;
                btnUseWeapon.Visible = true;
                btnUsePotion.Visible = true;
                cboSpells.Visible= true;
                btnUseSpell.Visible = true;
            }
            else
            {
                _currentMonster = null;

                cboWeapons.Visible = false;
                cboPotions.Visible = false;
                btnUseWeapon.Visible = false;
                btnUsePotion.Visible = false;
                cboSpells.Visible = false;
                btnUseSpell.Visible= false;
            }
            // refresh inventory
            UpdateInventoryListInUI();

            // Refresh player's quest list
            UpdateQuestListInUI();

            // Refresh player's weapons combobox
            UpdateWeaponListInUI();

            // Refresh player's potions combobox
            UpdatePotionListInUI();
            // refresh stats
            UpdatePlayerStats();
        }
        private void UpdateInventoryListInUI()
        {
            dgvInventory.RowHeadersVisible = false;

            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Inventory";
            dgvInventory.Columns[0].Width = 197;
            dgvInventory.Columns[1].Name = "Total";

            dgvInventory.Rows.Clear();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    dgvInventory.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                }
            }
        }

        private void UpdateQuestListInUI()
        {
            dgvQuests.RowHeadersVisible = false;

            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Quest";
            dgvQuests.Columns[0].Width = 197;
            dgvQuests.Columns[1].Name = "Completed?";

            dgvQuests.Rows.Clear();

            foreach (PlayerQuest playerQuest in _player.Quests)
            {
                dgvQuests.Rows.Add(new[] { playerQuest.Details.Name, playerQuest.IsCompleted.ToString() });
            }
        }

        private void UpdateWeaponListInUI()
        {
            List<Weapon> weapons = new List<Weapon>();
            List<Spell> spells = new List<Spell>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)inventoryItem.Details);
                        
                    }
                }
            }

            foreach(InventoryItem inventoryItem in _player.Inventory)  ///// test
            {
                if(inventoryItem.Details is Spell)
                {
                    if(inventoryItem.Quantity > 0)
                    {
                        spells.Add((Spell)inventoryItem.Details); // test
                    }
                }
            }

            if(spells.Count == 0)
            {
                cboSpells.Visible = false;
                btnUseSpell.Visible = false;
            }
            else
            {
                cboSpells.DataSource = spells;
                cboSpells.DisplayMember = "Name";
                cboSpells.ValueMember = "ID";
                cboSpells.SelectedIndex = 0;
            }

            if (weapons.Count == 0)
            {
                // The player doesn't have any weapons, so hide the weapon combobox and "Use" button
                cboWeapons.Visible = false;
                btnUseWeapon.Visible = false;
            }
            else
            {
                cboWeapons.DataSource = weapons;
                cboWeapons.DisplayMember = "Name";
                cboWeapons.ValueMember = "ID";

                cboWeapons.SelectedIndex = 0;
            }
        }

        private void UpdatePotionListInUI()
        {
            List<HealingPotion> healingPotions = new List<HealingPotion>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is HealingPotion)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        healingPotions.Add((HealingPotion)inventoryItem.Details);
                    }
                }
            }

            if (healingPotions.Count == 0)
            {
                // The player doesn't have any potions, so hide the potion combobox and "Use" button
                cboPotions.Visible = false;
                btnUsePotion.Visible = false;
            }
            else
            {
                cboPotions.DataSource = healingPotions;
                cboPotions.DisplayMember = "Name";
                cboPotions.ValueMember = "ID";

                cboPotions.SelectedIndex = 0;
            }
        }



        private void label5_Click(object sender, EventArgs e)
            {

            }

            private void label6_Click(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }

            private void label8_Click(object sender, EventArgs e)
            {

            }

            private void rbtLocation_TextChanged(object sender, EventArgs e)
            {

            }


            private void btnUseWeapon_Click(object sender, EventArgs e)
            {
                ///get currently weapon
                Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;
                
                //play sound
                using (var soundPlayer = new SoundPlayer(assetsFolder + "\\sfx\\destroyer.die.wav"))
                {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }

                // determine the amount of damage
                int damageToMonster = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);
                //apply the damage to the monster's currents hp
                _currentMonster.CurrentHitPoints -= damageToMonster;
                //display message
                rbtMessages.Text += _currentMonster.Name + "Suffer for " + damageToMonster.ToString() + Environment.NewLine;
                //check if the monster is sead
                if(_currentMonster.CurrentHitPoints <= 0)
                {
                    rbtMessages.Text += Environment.NewLine;
                    rbtMessages.Text += "You defeated the " + _currentMonster.Name + Environment.NewLine;

                    // Give player experience points for killing the monster
                    _player.AddExpPoints(_currentMonster.RewardExperiencePoints);
                    rbtMessages.Text += "You receive " + _currentMonster.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;

                    // Give player gold for killing the monster 
                    _player.Gold += _currentMonster.RewardGold;
                    rbtMessages.Text += "You receive " + _currentMonster.RewardGold.ToString() + " gold" + Environment.NewLine;

                    // Get random loot items from the monster
                    List<InventoryItem> lootedItems = new List<InventoryItem>();

                    foreach (LootItem lootItem in _currentMonster.LootTable)
                    {
                        if(RandomNumberGenerator.NumberBetween(1,100) <= lootItem.DropPrecentage)
                        {
                            lootedItems.Add(new InventoryItem(lootItem.Details,1));
                        }

                    }
                    if(lootedItems.Count == 0)
                    {
                        foreach(LootItem lootItem in _currentMonster.LootTable)
                        {
                            if (lootItem.IsDefaultItem)
                            {
                                lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                            }
                        }
                    }
                    // Add the looted items to the player's inventory
                    foreach(InventoryItem inventoryItem in lootedItems)
                    {
                        _player.AddItemToInventory(inventoryItem.Details);

                        if(inventoryItem.Quantity == 1)
                        { 
                            rbtMessages.Text += "You found " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name +Environment.NewLine;
                        }
                        else
                        {
                            rbtMessages.Text += "You found " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    //refresh
                    UpdatePlayerStats();
                    
                    UpdateInventoryListInUI();
                    UpdateWeaponListInUI();
                    UpdatePotionListInUI();
                    
                    //add a blank line for apperance
                    rbtMessages.Text += Environment.NewLine;
                    MoveTo(_player.CurrentLocation); // heal
                  
                }
                else
                {
                    //monster still have hp
                    // determine the amount damage the monster does do the player
                    int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);
                    //play sound
                    using (var soundPlayer = new SoundPlayer(assetsFolder + "\\sfx\\ogre5.wav"))
                    {
                        soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                    }
                    // display msg
                    rbtMessages.Text += "The " + _currentMonster.Name + " damaged you by " + damageToPlayer.ToString() + Environment.NewLine;
                    // subtract dmg
                    _player.CurrentHitPoints -= damageToPlayer;
                    
                    //refresh
                    lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                    if(_player.CurrentHitPoints <= 0)
                    {
                        rbtMessages.Text += "The " + _currentMonster.Name + " terminated you and mutilated your corpse and you were sent home to Sheeb" + Environment.NewLine;
                        // Move player to "Home"
                        MoveTo(Universe.LocationByID(Universe.LOCATION_ID_SHEEB));
                        _player.CurrentHitPoints += 10;
                        UpdatePlayerStats();
                    }
                }

            }

            private void btnUsePotion_Click(object sender, EventArgs e)
            {
                // currently potion
                HealingPotion potion = (HealingPotion)cboPotions.SelectedItem;

                //play sound
                using (var soundPlayer = new SoundPlayer(assetsFolder  + "\\sfx\\bottle.wav"))
                {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }



                //add the healing
                _player.CurrentHitPoints = (_player.CurrentHitPoints + potion.AmountToHeal);
                //current hitpoint cant be more then max
                if(_player.CurrentHitPoints > _player.MaximumHitPoints)
                {
                    _player.CurrentHitPoints = _player.MaximumHitPoints;
                }
                //remove the potion from the inventory
                foreach(InventoryItem ii in _player.Inventory)
                {
                    if(ii.Details.ID == potion.ID)
                    {
                        ii.Quantity--;
                        break;
                    }
                }
                //display the msg
                rbtMessages.Text += "You drink a " + potion.Name + " and feel restored" + Environment.NewLine;
                //monster attack
                int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);
                //display dmg msg
                rbtMessages.Text += "The " + _currentMonster.Name + "hurt you for " + damageToPlayer.ToString() + " amount of damage" + Environment.NewLine;
                // calculate the dmg
                _player.CurrentHitPoints -= damageToPlayer;
                // did player die
                if(_player.CurrentHitPoints <= 0)
                {
                    rbtMessages.Text += "Ripped apart by " + _currentMonster.Name + ". The suffering never ends..."+ Environment.NewLine;
                    rbtMessages.Text += "You wake up in another clone at home" + Environment.NewLine;
                    _player.CurrentHitPoints += 10;
                    _player.CurrentFuel += 10;
                    MoveTo(Universe.LocationByID(Universe.LOCATION_ID_SHEEB));
                    UpdatePlayerStats();
                }
                //refresh
                UpdateInventoryListInUI();
                UpdatePotionListInUI();
                UpdatePlayerStats();


        }

            private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void cboPotions_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void rbtMessages_TextChanged(object sender, EventArgs e)
            {
                rbtMessages.SelectionStart = rbtMessages.Text.Length;
                rbtMessages.ScrollToCaret();
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void Heroespathtoglory_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void UpdatePlayerStats()
        {
            //refresh 
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
            lblFuel.Text = _player.CurrentFuel.ToString();
            lblMana.Text = _player.CurrentMana.ToString();
        }

        private void btnUseSpell_Click(object sender, EventArgs e)
        {
            Spell currentSpell = (Spell)cboSpells.SelectedItem;
            using (var soundPlayer = new SoundPlayer(assetsFolder + "\\sfx\\weaponfire2.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }

            //count the mana
            if (_player.CurrentMana >= currentSpell.ManaCost)
            {
                _player.CurrentMana -= currentSpell.ManaCost;
                lblMana.Text = _player.CurrentMana.ToString();
                //determine the damage
                int damageToMonster = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);
                //apply the damage to the monster
                _currentMonster.CurrentHitPoints -= damageToMonster;
                //display msg
                rbtMessages.Text += _currentMonster.Name + "Suffer for " + damageToMonster.ToString() + " magic damage " + Environment.NewLine;
                // check if monster is dead
                if (_currentMonster.CurrentHitPoints <= 0)
                {
                    //msg
                    rbtMessages.Text += Environment.NewLine;
                    rbtMessages.Text += "You defeated the " + _currentMonster.Name + Environment.NewLine;
                    //xp gold  /// add for fuel later
                    _player.AddExpPoints(_currentMonster.RewardExperiencePoints);
                    rbtMessages.Text += "You receive " + _currentMonster.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;
                    _player.Gold += _currentMonster.RewardGold;
                    rbtMessages.Text += "You receive " + _currentMonster.RewardGold.ToString() + " gold" + Environment.NewLine;

                    // Get random loot items from the monster
                    List<InventoryItem> lootedItems = new List<InventoryItem>();
                    foreach (LootItem lootItem in _currentMonster.LootTable)
                    {
                        if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPrecentage)
                        {
                            lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                        }
                    }
                    if (lootedItems.Count > 0)
                    {
                        foreach (LootItem lootItem in _currentMonster.LootTable)
                        {
                            if (lootItem.IsDefaultItem)
                            {
                                lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                            }
                        }
                    }
                    //add the looted item to inventory
                    foreach (InventoryItem inventoryItem in lootedItems)
                    {
                        _player.AddItemToInventory(inventoryItem.Details);

                        if (inventoryItem.Quantity == 1)
                        {
                            rbtMessages.Text += "You found " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            rbtMessages.Text += "You found " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    //refresh
                    UpdatePlayerStats();

                    UpdateInventoryListInUI();
                    UpdateWeaponListInUI();
                    UpdatePotionListInUI();
                    //add a blank line for apperance
                    rbtMessages.Text += Environment.NewLine;
                    // small heal
                    MoveTo(_player.CurrentLocation);

                }
                else
                {
                    //monster still lives
                    //determine the amout damage the monster does to the player
                    int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

                    //play sound
                    using (var soundPlayer = new SoundPlayer(assetsFolder + "\\sfx\\ogre5.wav"))
                    {
                        soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                    }
                    //display msg
                    rbtMessages.Text += "The " + _currentMonster.Name + " damaged you by " + damageToPlayer.ToString() + Environment.NewLine;
                    //subtract the damage
                    _player.CurrentHitPoints -= damageToPlayer;

                    //refresh
                    lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                    if (_player.CurrentHitPoints <= 0)
                    {
                        rbtMessages.Text += "The " + _currentMonster.Name + " terminated you and mutilated your corpse" + Environment.NewLine;
                        rbtMessages.Text += "You wake up in another clone at home" + Environment.NewLine;
                        _player.CurrentFuel += 10;
                        _player.CurrentHitPoints += 10;
                        // Move player to "Home"
                        MoveTo(Universe.LocationByID(Universe.LOCATION_ID_SHEEB));
                        UpdatePlayerStats();
                    }
                }
            }
            else
            {
                btnUseSpell.Visible = false;
            }
        }

        private void cboSpells_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Heroespathtoglory_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(PLAYER_DATA_FILE_NAME, _player.ToXmlString());
        }
    }
}
