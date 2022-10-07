using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Engine
{
    public static class Universe
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
        //public static readonly List<Spell> Spells = new List<Spell>();
        // Healing
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SALVIA_SICERARIA = 21;
        public const int ITEM_ID_CAN_WITH_PUDDING = 22;
        public const int ITEM_ID_DURAPLAST_BEER = 23;
        public const int ITEM_ID_DURAPLAST_PILL = 24;
        /// Weapons
        public const int ITEM_ID_HALFBROKEN_BLASTER = 1;
        public const int ITEM_ID_SPACECLUB = 6;
        public const int ITEM_ID_ENERGIZED_PHOTON_RIFLE = 25;
        public const int ITEM_ID_FUSION_THERMAL_FLAMETHROWER = 26;
        public const int ITEM_ID_LOW_FREQUENCY_BLASTER = 27;
        public const int ITEM_ID_HIGH_FREQUENCY_RIFLE = 28;
        public const int ITEM_ID_RADIO_ACTIVE_STICK = 29;
        //Items
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        /// seven is healing, healing_potion is a subclass of the item class
        /// 
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;
        public const int ITEM_ID_TOBACCO = 11;
        public const int ITEM_ID_SEMICONDUCTOR_MPX23 = 12;
        public const int ITEM_ID_ENDOTHERMIC_BATTERY = 13;
        public const int ITEM_ID_ELECTRIC_EXTENSION_CORD = 14;
        public const int ITEM_ID_HETERODYNE_RAM = 15;
        public const int ITEM_ID_KARYOKINESIS_TENT = 16;
        public const int ITEM_ID_ELECTRIC_TAPE = 17;
        public const int ITEM_ID_MUTATED_EAR = 18;
        public const int ITEM_ID_RADIO_ACTIVE_POTATO = 19;
        public const int ITEM_ID_SUPERHETRODYNE_RADIO = 20;
        // spells
        public const int SPELL_ID_FIREBALL = 101;
        public const int SPELL_ID_JUDGEMENT = 102;
        

        //Monsters
        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_BANDIT = 4;
        public const int MONSTER_ID_JUGGERNAUT = 5;
        public const int MONSTER_ID_REPONSIVE_BASE_PROTECTION_DROID = 6;
        public const int MONSTER_ID_SELF_AWARE_INFORMATION_DROID = 7;
        //Quest
        public const int QUEST_ID_CLEAR_HUTTAT = 1;
        public const int QUEST_ID_CLEAR_MOON_OF_ESUOH = 2;
        //Location
        public const int LOCATION_ID_SHEEB = 1;
        public const int LOCATION_ID_QUX = 2;
        public const int LOCATION_ID_ISC_DEFENSE_POST = 3;
        public const int LOCATION_ID_HUTTAT = 4;
        public const int LOCATION_ID_MOON_OF_HUTTAT = 5;
        public const int LOCATION_ID_ESUOH = 6;
        public const int LOCATION_ID_MOONOFESUOH = 7;
        public const int LOCATION_ID_SPACEBRIDGE = 8;
        public const int LOCATION_ID_ARACHNUS = 9;
        public const int LOCATION_ID_GOLGAGUS = 10;
        public const int LOCATION_ID_THE_PIONEERS_ASTEROID_BELT = 11;
        public const int LOCATION_ID_DARK_MAGON = 12;
        public const int LOCATION_ID_ASTEROID_BELT_ONE = 13;
        public const int LOCATION_ID_ASTEROID_BELT_TWO = 14;
        public const int LOCATION_ID_ASTEROID_BELT_THREE = 15;
        public const int LOCATION_ID_ASTEROID_BELT_FOUR = 16;
        public const int LOCATION_ID_ASTEROID_BELT_FIVE = 17;
        public const int LOCATION_ID_ASTEROID_BELT_SIX = 18;
        public const int LOCATION_ID_ASTEROID_BELT_SEVEN = 19;
        public const int LOCATION_ID_ASTEROID_BELT_EIGHT = 20;
        public const int LOCATION_ID_ASTEROID_BELT_NINE = 21;
        public const int LOCATION_ID_ASTEROID_BELT_TEN = 22;
        public const int LOCATION_ID_ASTEROID_BELT_ELEVEN = 23;
        public const int LOCATION_ID_ASTEROID_BELT_TWELVE = 24;
        public const int LOCATION_ID_ASTEROID_BELT_THIRTEEN = 25;
        public const int LOCATION_ID_ASTEROID_BELT_FOURTEEN = 26;
        public const int LOCATION_ID_ASTEROID_BELT_FIFTEEN = 27;
        public const int LOCATION_ID_ASTEROID_BELT_SIXTEEN = 28;
        public const int LOCATION_ID_ASTEROID_BELT_SEVENTEEN = 29;
        public const int LOCATION_ID_ASTEROID_BELT_EIGHTEEN = 30;
        public const int LOCATION_ID_ASTEROID_BELT_NINETEEN = 31;
        public const int LOCATION_ID_ASTEROID_BELT_TWENTY = 32;
        public const int LOCATION_ID_ASTEROID_BELT_TWENTYONE = 33;
        public const int LOCATION_ID_ASTEROID_BELT_TWENTYTWO = 34;
        public const int LOCATION_ID_ASTEROID_BELT_TWENTYTHREE = 35;
        public const int LOCATION_ID_ASTEROID_BELT_TWENTYFOUR = 36;

        public const int UNSELLABLE_ITEM_PRICE = -1;
        //Constructor

        static Universe()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
            
        }
        


        private static void PopulateItems()
        {
            // items
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails", 0));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur", 0));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs", 0));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", 0));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs", 0));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks", 0));
            //key
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes", UNSELLABLE_ITEM_PRICE));
            //
            Items.Add(new Item(ITEM_ID_TOBACCO, "Old tobacco", "Old tobaccos", 0));
            Items.Add(new Item(ITEM_ID_SEMICONDUCTOR_MPX23, "MPX23 Semi conductor","Semi conductors", 0));
            Items.Add(new Item(ITEM_ID_ENDOTHERMIC_BATTERY, "Endothermic battery", "Endothermic batterys", 0));
            Items.Add(new Item(ITEM_ID_ELECTRIC_EXTENSION_CORD, "Electric extension cord", "Electric extension cords", 0));
            Items.Add(new Item(ITEM_ID_HETERODYNE_RAM, "Heterodyne RAM", "Heterodyne RAMs", 0));
            Items.Add(new Item(ITEM_ID_KARYOKINESIS_TENT, "Karyokinesis tent", "Karyokinesis tents", 0));
            Items.Add(new Item(ITEM_ID_ELECTRIC_TAPE, "Electric tape", "Rolls of electric tape", 0));
            Items.Add(new Item(ITEM_ID_MUTATED_EAR, "Mutated ear", "Mutated ears", 0));
            Items.Add(new Item(ITEM_ID_RADIO_ACTIVE_POTATO, "Radio active potato","Radio active potatoes", 0));
            Items.Add(new Item(ITEM_ID_SUPERHETRODYNE_RADIO, "Superhetrodyne radio", "Superhetrodyne radios", 0));
            //// weapons
            Items.Add(new Weapon(ITEM_ID_HALFBROKEN_BLASTER, "Half broken blaster", "Half broken blasters", 1, 0, 4));
            Items.Add(new Weapon(ITEM_ID_SPACECLUB, "Space club", "Space clubs", 1, 3, 4));
            Items.Add(new Weapon(ITEM_ID_ENERGIZED_PHOTON_RIFLE, "Energized photon rifle", "Energized photon rifles", 8,10, 15));
            Items.Add(new Weapon(ITEM_ID_FUSION_THERMAL_FLAMETHROWER, "Fusion thermal flamethrower", "Fusion thermal flamethrowers", 8, 8, 10));
            Items.Add(new Weapon(ITEM_ID_LOW_FREQUENCY_BLASTER, "Low frequency blaster", "Low frequency blasters", 2, 6, 10));
            Items.Add(new Weapon(ITEM_ID_HIGH_FREQUENCY_RIFLE, "High frequency rifle", "High frequency rifles", 14, 7, 13));
            Items.Add(new Weapon(ITEM_ID_RADIO_ACTIVE_STICK, "Radio active stick", "Radio active sticks", 0, 1, 2));

            Items.Add(new Spell(SPELL_ID_FIREBALL, "Fireball", "Fireballs", 0, "Shoots a fast fireball", "Fire", 4, 5, 12));
            Items.Add(new Spell(SPELL_ID_JUDGEMENT, "Judgement", "Judgements", 0, "Blast the heretics with your faith", "Holy", 3, 2, 6));

            // healing and food
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 5, 0));
            Items.Add(new HealingPotion(ITEM_ID_SALVIA_SICERARIA,"Salvia siceraria", "Salvia sicerarias", 4, 0));
            Items.Add(new HealingPotion(ITEM_ID_CAN_WITH_PUDDING, "Can with pudding", "Cans of pudding", 1, 0));
            Items.Add(new HealingPotion(ITEM_ID_DURAPLAST_BEER, "Duraplast Beer", "Duraplast beers", 2, 0));
            Items.Add(new HealingPotion(ITEM_ID_DURAPLAST_PILL, "Duraplast pill", "Duraplast pills", 8, 0));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 15, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SALVIA_SICERARIA), 33, true));

            Monster bandit = new Monster(MONSTER_ID_BANDIT, "Bandit", 7, 4, 12, 5, 5);
            bandit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_TOBACCO), 50, true));
            bandit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPACECLUB), 25, true));
            bandit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DURAPLAST_BEER), 25, true));

            Monster juggernaut = new Monster(MONSTER_ID_JUGGERNAUT, "Juggernaut", 9, 20, 50, 33, 33);
            juggernaut.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SEMICONDUCTOR_MPX23), 25, true));
            juggernaut.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ENDOTHERMIC_BATTERY), 25, true));
            juggernaut.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ELECTRIC_EXTENSION_CORD), 25, true));
            juggernaut.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HETERODYNE_RAM), 25, true));
            juggernaut.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SUPERHETRODYNE_RADIO), 25, true));
            juggernaut.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ENERGIZED_PHOTON_RIFLE), 25, true));
            juggernaut.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HIGH_FREQUENCY_RIFLE), 25, true));

            Monster responsive_base_protection_droid = new Monster(MONSTER_ID_REPONSIVE_BASE_PROTECTION_DROID, "Responsive base protection droid", 8, 8, 15, 8, 8);
            responsive_base_protection_droid.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ELECTRIC_EXTENSION_CORD), 20, true));
            responsive_base_protection_droid.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ENDOTHERMIC_BATTERY), 20, true));
            responsive_base_protection_droid.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FUSION_THERMAL_FLAMETHROWER), 20, true));

            Monster self_aware_information_droid = new Monster(MONSTER_ID_SELF_AWARE_INFORMATION_DROID, "Self aware information droid", 2, 4, 8, 18, 18);
            self_aware_information_droid.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HETERODYNE_RAM), 20, true));
            self_aware_information_droid.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RADIO_ACTIVE_POTATO), 20, true));
            self_aware_information_droid.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RADIO_ACTIVE_STICK), 55, true));


            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
            Monsters.Add(bandit);
            Monsters.Add(juggernaut);
            Monsters.Add(responsive_base_protection_droid);
            Monsters.Add(self_aware_information_droid);
        }

        private static void PopulateQuests()
        {
            Quest clearMoonOfHuttat =
                new Quest(
                    QUEST_ID_CLEAR_HUTTAT,
                    "Clear moon of Huttat of rats ",
                    "Kill rats at moon of Huttat and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces. ", 20, 10);

            clearMoonOfHuttat.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

            clearMoonOfHuttat.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quest clearMoonOfEsuoh =
                new Quest(
                    QUEST_ID_CLEAR_MOON_OF_ESUOH,
                    "Clear the fields at moon of Esuoh ",
                    "The moon of Esuoh have been infected by mutated snakes. Farmers are saying that their moon-light enhancers have been sabotaged. they cant get their engineers to fix it until the snakes are cleared. ", 20, 20);

            clearMoonOfEsuoh.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));

            clearMoonOfEsuoh.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quests.Add(clearMoonOfHuttat);
            Quests.Add(clearMoonOfEsuoh);
        }

        private static void PopulateLocations()
        {

            // Create each location
            Location sheeb = new Location(LOCATION_ID_SHEEB, "Planet:Sheeb", "Your home planet. Once a crown jewel in the galaxy, now its all a wasteland..", planetimage: "sheeb.gif");

            Location qux = new Location(LOCATION_ID_QUX, "Planet:Qux Trade and services", "The city of Qux, ''Falburn'' was built in the shadows of a rugged volcaono and is truly an evergrowing wonder.", planetimage: "qux.gif");

            Location huttat = new Location(LOCATION_ID_HUTTAT, "Planet:Huttat", "The plant-like organisms on this planet are dominated by large fungi and flowers, but there are some trees and shrubs as well. The flowers come in almost every color imaginable, but they tend to be fairly small. The fungi on the other hand, they reach incredible heights, but are usually fairly pale in color.", planetimage: "qux.gif");
            huttat.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_HUTTAT);

            Location moonofhuttat = new Location(LOCATION_ID_MOON_OF_HUTTAT, "Planet:Moon of Huttat", "Unlike Huttat, the vegetation on this moon is aggressive and harsh.", planetimage: "moon of huttat.gif");
            moonofhuttat.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            Location esuoh = new Location(LOCATION_ID_ESUOH, "Planet:ESUOH", "The planet Eshuoh is famous for its export in vegetation and food.", planetimage: "esuoh.gif");
            esuoh.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_MOON_OF_ESUOH);

            Location moonofesuoh = new Location(LOCATION_ID_MOONOFESUOH, "Planet:Moon of Esuoh", "You see rows of vegetables growing here.", planetimage: "moon of huttat.gif");
            moonofesuoh.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location asteroid_belt = new Location(LOCATION_ID_THE_PIONEERS_ASTEROID_BELT, "The Pioneers CO Asteroid belt", "Once a famous and prosperous minnig operation before the war. Now home to atrocious creatures, heinous plundrers and other poachers of the galaxy", planetimage: "THE_PIONEERS_ASTEROID_BELT.png");
            asteroid_belt.MonsterLivingHere = MonsterByID(MONSTER_ID_BANDIT);

            Location dark_magon = new Location(LOCATION_ID_DARK_MAGON, "Planet:Dark Magon", "This planet has four major landmasses scattered apart over the globe.  It has an average surface temperature of about 63° Fahrenheit.  Its average temperature has been falling over the last several hundred years, and it experiences extremely high levels of geological activity in a few hotspots.  Easily-mined metals are scarce.");

            Location iscdefensepost = new Location(LOCATION_ID_ISC_DEFENSE_POST, "Spacestation:ISC Defense post, Wormulon", "ISC Defense post, Wormulon got it's name after the 12th sun war, year 23xy^2.");

            Location spacebridge = new Location(LOCATION_ID_SPACEBRIDGE, "SpaceBridge", "A anicent space bridge crosses a wide river spacedust and heavenly power.", ItemByID(ITEM_ID_ADVENTURER_PASS));

            Location arachnus = new Location(LOCATION_ID_ARACHNUS, "Planet:Arachnus", "The forest of Arachnus stretches far and wide. The mountain DeorcLacu is the only safe place to land. But dont let your guard down, it's a treacherous place and one should be careful around these woods.");
            arachnus.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            Location golgalus = new Location(LOCATION_ID_GOLGAGUS, "Planet:Golgalus", "The city of Golgalus, ''Earthfall'' was built at the edge of an enormous island and is trully a fully mordernized display of wonder");
            golgalus.MonsterLivingHere = MonsterByID(MONSTER_ID_BANDIT);


            Location asteroid_belt_one = new Location(LOCATION_ID_ASTEROID_BELT_ONE, "Asteroid belt", "Asteroid belt", planetimage: "a1.png");

            Location asteroid_belt_two = new Location(LOCATION_ID_ASTEROID_BELT_TWO, "Asteroid belt", "Asteroid belt", planetimage: "a2.png");
            asteroid_belt_two.MonsterLivingHere = MonsterByID(MONSTER_ID_BANDIT);

            Location asteroid_belt_three = new Location(LOCATION_ID_ASTEROID_BELT_THREE, "Asteroid belt", "Asteroid belt", planetimage: "a3.png");

            Location asteroid_belt_four = new Location(LOCATION_ID_ASTEROID_BELT_FOUR, "Asteroid belt", "Asteroid belt", planetimage: "a4.png");

            Location asteroid_belt_five = new Location(LOCATION_ID_ASTEROID_BELT_FIVE, "Asteroid belt", "Asteroid belt", planetimage: "a5.png");

            Location asteroid_belt_six = new Location(LOCATION_ID_ASTEROID_BELT_SIX, "Asteroid belt", "Asteroid belt", planetimage: "a6.png");

            Location asteroid_belt_seven = new Location(LOCATION_ID_ASTEROID_BELT_SEVEN, "Asteroid belt", "Asteroid belt", planetimage: "a7.png");

            Location asteroid_belt_eight = new Location(LOCATION_ID_ASTEROID_BELT_EIGHT, "Asteroid belt", "Asteroid belt", planetimage: "a8.png");

            Location asteroid_belt_nine = new Location(LOCATION_ID_ASTEROID_BELT_NINE, "Asteroid belt", "Asteroid belt", planetimage: "a9.png");
            asteroid_belt_nine.MonsterLivingHere = MonsterByID(MONSTER_ID_JUGGERNAUT);

            Location asteroid_belt_ten = new Location(LOCATION_ID_ASTEROID_BELT_TEN, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_eleven = new Location(LOCATION_ID_ASTEROID_BELT_ELEVEN, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_twelve = new Location(LOCATION_ID_ASTEROID_BELT_TWELVE, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_thirteen = new Location(LOCATION_ID_ASTEROID_BELT_THIRTEEN, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_fourteen = new Location(LOCATION_ID_ASTEROID_BELT_FOURTEEN, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_fifteen = new Location(LOCATION_ID_ASTEROID_BELT_FIFTEEN, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_sixteen = new Location(LOCATION_ID_ASTEROID_BELT_SIXTEEN, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_seventeen = new Location(LOCATION_ID_ASTEROID_BELT_SEVENTEEN, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_eighteen = new Location(LOCATION_ID_ASTEROID_BELT_EIGHTEEN, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_nineteen = new Location(LOCATION_ID_ASTEROID_BELT_NINETEEN, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_twenty = new Location(LOCATION_ID_ASTEROID_BELT_TWENTY, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_twentyone = new Location(LOCATION_ID_ASTEROID_BELT_TWENTYONE, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_twentytwo = new Location(LOCATION_ID_ASTEROID_BELT_TWENTYTWO, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_twentythree = new Location(LOCATION_ID_ASTEROID_BELT_TWENTYTHREE, "Asteroid belt", "Asteroid belt");
            Location asteroid_belt_twentyfour = new Location(LOCATION_ID_ASTEROID_BELT_TWENTYFOUR, "Asteroid belt", "Asteroid belt");


            // Add the locations to the static list
            Locations.Add(sheeb);
            Locations.Add(qux);
            Locations.Add(iscdefensepost);
            Locations.Add(huttat);
            Locations.Add(moonofhuttat);
            Locations.Add(esuoh);
            Locations.Add(moonofesuoh);
            Locations.Add(spacebridge);
            Locations.Add(arachnus);
            Locations.Add(golgalus);
            Locations.Add(asteroid_belt);
            Locations.Add(dark_magon);
            Locations.Add(asteroid_belt_one);
            Locations.Add(asteroid_belt_two);
            Locations.Add(asteroid_belt_three);
            Locations.Add(asteroid_belt_four);
            Locations.Add(asteroid_belt_five);
            Locations.Add(asteroid_belt_six);
            Locations.Add(asteroid_belt_seven);
            Locations.Add(asteroid_belt_eight);
            Locations.Add(asteroid_belt_nine);
            Locations.Add(asteroid_belt_ten);
            Locations.Add(asteroid_belt_eleven);
            Locations.Add(asteroid_belt_twelve);
            Locations.Add(asteroid_belt_thirteen);
            Locations.Add(asteroid_belt_fourteen);
            Locations.Add(asteroid_belt_fifteen);
            Locations.Add(asteroid_belt_sixteen);
            Locations.Add(asteroid_belt_seventeen);
            Locations.Add(asteroid_belt_eighteen);
            Locations.Add(asteroid_belt_nineteen);
            Locations.Add(asteroid_belt_twenty);
            Locations.Add(asteroid_belt_twentyone);
            Locations.Add(asteroid_belt_twentytwo);
            Locations.Add(asteroid_belt_twentythree);
            Locations.Add(asteroid_belt_twentyfour);
            //Directory.GetCurrentDirectory(), "\\map.txt"
            //C:\Users\Daniel\Desktop\Game Folder c#\Heroespathtoglory.demov2 public string assetsFolder = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets";

            //var path = Path.Combine(@"C:\Users\Daniel\Desktop\Game Folder c#\Heroespathtoglory.demov2\map.txt");

            //string[] lines = System.IO.File.ReadAllLines(path);

            int[,] map = new int[24, 5]{
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 },
                { 26, 27, 28, 29, 30 },
                { 31, 32, 33, 34, 35 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },
                { 36, 36, 36, 36, 36 },

            };
            
            // loop through rows
            for (int row = 0; row < 24; row++)
            {
                //string line = map[row]; 
                // loop through cols
                for (int col = 0; col < 5; col++)
                {
                    // convert from char to int lol
                    int planetId = map[row, col];
                    
                    Location location = LocationByID(planetId);

                    
                    // Add Up location if exist
                    try
                    {
                        int upId = map[row + 1,col];
                        if (upId != 0)
                        {
                            Location upLocation = LocationByID(upId);
                            location.LocationToGoUp = upLocation;
                        }
                        
                    }
                    catch(IndexOutOfRangeException ex) 
                    {
                        
                    }
                    

                    // Add Down location if exist
                    try
                    {
                        int downId = map[row - 1,col];
                        if (downId != 0)
                        {
                            Location downLocation = LocationByID(downId);
                            location.LocationToGoDown = downLocation;
                        }
                    }
                    catch(IndexOutOfRangeException ex) 
                    {
                        
                    }
                    

                    // Add Left location if exist
                    try
                    {
                        
                            int leftId = map[row, col - 1];
                            if (leftId != 0)
                            {
                                Location leftLocation = LocationByID(leftId);
                                location.LocationToGoLeft = leftLocation;
                            }
                        
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        
                    }

                    
                    // Add Right location if exist
                    try
                    {
                        
                            int rightId = map[row, col + 1];
                            if (rightId != 0)
                            {
                                Location rightLocation = LocationByID(rightId);
                                location.LocationToGoRight = rightLocation;
                            }
                        
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        
                    }
                    
                    

                }
            }

        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}