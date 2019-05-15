using System;
using System.Collections.Generic;
using System.Text;

namespace Quest_of_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Quest Of Questions";


        //PreGame Logic
            Random rnd = new Random();
            int GameNumber = rnd.Next(1, 11);

            int currentRoom = 1;
            string command = "";
            string Name = "";


            //Start Of Game Seen
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            string a = "Press Enter to Start:";
            Console.SetCursorPosition((Console.WindowWidth - a.Length) / 2, Console.CursorTop);
            Console.WriteLine(a);
            Console.ResetColor();
            Console.ReadLine();

            Name = GetName();
            Console.WriteLine();
            Console.Write("                        ");

     

            //string commandString = Console.ReadLine().ToUpper();
            string[] charSeparators = new string[] { " ", ",", "." };

            RoomClass[] rooms = new RoomClass[335]; // N, E, S, W, U, D
            HelperClass[] helper = new HelperClass[50];

            List<ItemClass> roomItem = new List<ItemClass>();
            List<ItemClass> inventory = new List<ItemClass>();
            List<QandA> QA = new List<QandA>();


            if (GameNumber % 2 == 0)
            {
                rooms[1] = new RoomClass(false, 2, 0, 0, 0, 0, 0, "Forest: ", " Up for an Adventure? Head north to go inside the acient temple;~)");
                rooms[2] = new RoomClass(false, 5, 42, 1, 41, 0, 0, "Entrance: ", "The room is lit up by torches. This isn't so bad, Lets go get the Golden Blizing");
                rooms[41] = new RoomClass(false, 4, 2, 0, 0, 0, 0, "Hall: ", "Not much to see. Shall we keep going?");
                rooms[42] = new RoomClass(false, 3, 0, 0, 2, 0, 0, "Hall: ", "Not much to see. Shall we keep going?");
                rooms[3] = new RoomClass(false, 6, 0, 42, 5, 0, 0, "Room of Gold: ", "Looks like a treasure room. ");
                rooms[4] = new RoomClass(false, 7, 5, 41, 0, 0, 0, "Treasure Hall: ", "Looks like a room that could be filled with lots of gold. ");
                rooms[5] = new RoomClass(true, 9, 3, 2, 4, 0, 0, "Oberon's Room: ", "A little cozy room, three walls full of books. In the corner is a chair with a little stone statue that looks like it could be reading. Wouldn't it be nice if you could speak to such a wise looking statue.");
                rooms[6] = new RoomClass(false, 0, 0, 3, 0, 0, 0, "First Understanding: ", " ");
                rooms[7] = new RoomClass(false, 0, 0, 4, 8, 0, 0, "Second Knowing: ", "");
                rooms[8] = new RoomClass(false, 110, 7, 0, 0, 0, 0, "Art Gallary", "So many paintings along the walls, There is a circle of statues in the middle of the room curounding a fountain");
                rooms[9] = new RoomClass(false, 11, 12, 5, 10, 0, 0, " First Battle: ", "There is a beast in the middle of the room...");
                rooms[10] = new RoomClass(false, 11, 9, 0, 8, 0, 0, "Dining room: ", "A long wooden table with acient food spread on it, almost looks fresh enough to eat.");
                rooms[11] = new RoomClass(false, 14, 12, 9, 10, 0, 0, "Kitchen: ", "A clay oven, Stone Cook tops, knives, and a garden still growing where sun shines in from the celieng.");
                rooms[12] = new RoomClass(false, 11, 13, 0, 9, 0, 0, "Music Room:", "String, wind, and percussion instruments are skattered around the room");
                rooms[13] = new RoomClass(false, 0, 0, 0, 12, 0, 0, "Third Learning: ", "");
                rooms[14] = new RoomClass(false, 18, 17, 11, 15, 0, 0, "Treasure treasure", "Lots of round dusty objects are skattered on the floor.");
                rooms[15] = new RoomClass(false, 0, 14, 0, 16, 0, 0, "Throne Room: ", " Golden thrones are at the top of a tower of stairs looking down onto a great wide floor.");
                rooms[16] = new RoomClass(false, 19, 15, 0, 0, 0, 0, "Snake Trap: ", "A pit of snakes, they take all your money.");
                rooms[17] = new RoomClass(false, 0, 18, 40, 14, 0, 0, ";~)  ", "Hint hint, if you look for it");
                rooms[18] = new RoomClass(false, 21, 17, 14, 20, 0, 0, "Break Room", "What is it you need? Chances are we got it here.");
                rooms[19] = new RoomClass(false, 24, 0, 16, 0, 0, 0, "Bed Room", "A huge room with a bed that looks fun to jump on.");
                rooms[20] = new RoomClass(false, 124, 18, 0, 0, 0, 0, "Side Room:", "This side room has a bit of everything, from gold to ways to heal yourself.");
                rooms[21] = new RoomClass(true, 23, 22, 18, 0, 0, 0, "Argus's Room: ", "A dog is sitting in the center of the room. When you walk in his tail starts wagging, how cute. Make sure to tell him he's a good boy!");
                rooms[22] = new RoomClass(true, 0, 0, 0, 21, 0, 0, "Dark Wind: ", "Walking in gives you the chills as a gust of wind comes from no where! You see a shadow fly across the room then stand still. Wonder if it's friendly...");
                rooms[23] = new RoomClass(false, 25, 123, 21, 0, 0, 0, "Battle Grounds: ", "A giant bird is flying around. You take a step in and it shoots fire at you from its mouth. It looks like it's either you or him.");
                rooms[24] = new RoomClass(false, 0, 0, 20, 19, 0, 27, "Painted Hall", "The walls are full of hieroglyphs. They look importand, if only you had a book that you could /TRANSLATE WALLS USING BOOK/. ");
                rooms[25] = new RoomClass(true, 26, 0, 23, 0, 0, 0, "Fly High Room: ", "There is a big tree growing in an almost dark room. Little glissing balls of light fly round it. You cant make out what they are till you see a light that looks like a little human with wings sitting at the ase of the tree. ");
                rooms[26] = new RoomClass(false, 229, 0, 25, 0, 0, 0, "Balancing the Sides: ", "Walking in you see the only other door to the north. The door is bloked with a gate. Wtitten on the gate is a message and a scale with a small yellow ball weighing down one side. ");
                rooms[27] = new RoomClass(false, 230, 0, 224, 231, 0, 0, "Rusing River: ", "The door closes behind you. Blocking the other doors fast flowing river. To lower the bridge or open your door it looks like there is a key pad looking for a word. try and read the Clue");
                rooms[28] = new RoomClass(false, 34, 0, 23, 0, 0, 0, "Empty Hall", " Just more paintings on the side of the walls");
                rooms[29] = new RoomClass(false, 0, 0, 26, 30, 0, 0, "Golden hall", "Beautiful golden walls, with some healing flowers growing on the sides.");
                rooms[30] = new RoomClass(false, 32, 29, 27, 0, 0, 0, "Armory", "A stone room with weapons hung on racks");
                rooms[31] = new RoomClass(false, 0, 27, 0, 32, 0, 0, "Clue:", "One big drawing is on the wall with an inscription at the bottom. You may want to take a better look at it.");
                rooms[32] = new RoomClass(false, 33, 0, 30, 31, 0, 0, "Bitter Sweet: ", "There is a beautiful young woman pacing back and forth. Her hands look Cold as Ice and her hair is frozen over. You walk towards her and when you're close enough she hits you hard wih her frozen boots.");
                rooms[33] = new RoomClass(false, 0, 134, 32, 135, 0, 0, "Trophy Room: ", "A massive room and the only thing in it is a piller with the Golden Blizing on it trapped within a cage with a lock on the outside. Looks like one more riddle ");
                rooms[34] = new RoomClass(true, 0, 28, 0, 33, 0, 0, "All knowing: ", "A small girl sits in a little rocking chair reading a book, /Listen/ She says, /and hear of this place./");
                rooms[35] = new RoomClass(false, 0, 33, 0, 0, 0, 0, "Credits: ", "    ");
                rooms[40] = new RoomClass(false, 17, 0, 0, 0, 0, 0, "Story Of Time: ", "     ");

                rooms[2].roomItem.Add(new ItemClass(1, "TORCH", "Lights Up The Room", 0, 1, 3));
                rooms[5].roomItem.Add(new ItemClass(100, "TRANSLATOR", "a book that allows you to translate hints on the walls", 50, 500, 0));
                rooms[10].roomItem.Add(new ItemClass(2, "KNIFE", "Sharp And Pointy, great for chopping", 3, 10, 2));
                rooms[11].roomItem.Add(new ItemClass(2, "KNIFE", "Sharp And Pointy, great for chopping", 3, 10, 2));
                rooms[12].roomItem.Add(new ItemClass(99, "INSTRUMENT1", "Snake charmer: hypnotises snakes", 15, 3, 1));
                rooms[12].roomItem.Add(new ItemClass(98, "INSTRUMENT2", "Pettler Flute: Playing this weakens monsters", 15, 3, 1));
                rooms[12].roomItem.Add(new ItemClass(98, "INSTRUMENT3", "Harmonica: a fun little instrument", 3, 3, 1));
                rooms[30].roomItem.Add(new ItemClass(3, "SWORD", "Weapon for a hero", 5, 10, 3));
                rooms[30].roomItem.Add(new ItemClass(4, "SPEARS", "Perfect at throwing at monsters", 3, 3, 3));
                rooms[30].roomItem.Add(new ItemClass(5, "BOW", "great for shooting arrows", 3, 40, 0));
                rooms[30].roomItem.Add(new ItemClass(6, "ARROWS", "Can be shot out of a bow", 3, 5, 1));
                rooms[30].roomItem.Add(new ItemClass(6, "ARROWS", "Can be shot out of a bow", 3, 5, 1));
                rooms[40].roomItem.Add(new ItemClass(7, "GUN", "Can Shoot Bullets", 1, 40, 1));
                rooms[40].roomItem.Add(new ItemClass(7, "BULLETS", "Can be shot out of a gun", 3, 5, 1));


                //rooms[5].helper.Add(new HelperClass(1, "Oberon: ", "Welcome, " + Name + ", to the Temple of the Sun. I am here to answer your questions."));
                //helper.Add(new QandA(1, " ", " ", 1));
                //QandA number1 = new QandA(1, "Where am I and how do I get the Blizing?", "Welcome to the Temple of the Sun, To get the blizing you just have to get to it alive."));


                rooms[5].helper[5] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");
                    rooms[5].helper[5].QA.Add(new QandA(1, "Where am I and how do I get the Blizing?", "Welcome to the Temple of the Sun, To get the blizing you just have to get to it alive."));
                    rooms[5].helper[5].QA.Add(new QandA(2, "What challenges will I have to face?", " This temple has been lined with riddles, monsters, and traps garding the blizing. Of corse we all have some hidden shortcuts..."));
                    rooms[5].helper[5].QA.Add(new QandA(3, "What if I get lost?", "Helpers are around the temple, If you can read hyroglyphs the walls will be helpful. There may or may not be a translation book around these few rooms."));
                    rooms[5].helper[5].QA.Add(new QandA(-4, "Extra Question: ", "Helpers are around the temple, If you can read hyroglyphs the walls will be helpful. There may or may not be a translation book around these few rooms."));
                rooms[21].helper[21] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");
                rooms[22].helper[22] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");
                rooms[25].helper[25] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");
            }
            if (GameNumber % 2 != 0 && GameNumber >= 5)
            {
                rooms[1] = new RoomClass(false, 2, 0, 0, 0, 0, 0, "Forest: ", " Up for an Adventure? Head north to go inside the acient temple;~)");
                rooms[2] = new RoomClass(false, 5, 42, 1, 41, 0, 0, "Entrance: ", "The room is lit up by torches. This isn't so bad, Lets go get the Golden Blizing");
                rooms[41] = new RoomClass(false, 4, 2, 0, 0, 0, 0, "Hall: ", "Not much to see. Shall we keep going?");
                rooms[42] = new RoomClass(false, 3, 0, 0, 2, 0, 0, "Hall: ", "Not much to see. Shall we keep going?");
                rooms[3] = new RoomClass(false, 6, 0, 42, 5, 0, 0, "Room of Gold: ", "Looks like a treasure room. ");
                rooms[4] = new RoomClass(false, 7, 5, 41, 0, 0, 0, "Treasure Hall: ", "Looks like a room that could be filled with lots of gold. ");
                rooms[5] = new RoomClass(true, 9, 3, 2, 4, 0, 0, "Oberon's Room: ", "A little cozy room, three walls full of books. In the corner is a chair with a little stone statue that looks like it could be reading. Wouldn't it be nice if you could speak to such a wise looking statue.");
                rooms[6] = new RoomClass(false, 0, 0, 3, 0, 0, 0, "First Understanding: ", " ");
                rooms[7] = new RoomClass(false, 0, 0, 4, 8, 0, 0, "Second Knowing: ", "");
                rooms[8] = new RoomClass(false, 110, 7, 0, 0, 0, 0, "Art Gallary", "So many paintings along the walls, There is a circle of statues in the middle of the room curounding a fountain");
                rooms[9] = new RoomClass(false, 11, 36, 5, 10, 0, 0, " First Battle: ", "There is a beast in the middle of the room...");
                rooms[10] = new RoomClass(false, 11, 9, 41, 8, 0, 0, "Dining room: ", "A long wooden table with acient food spread on it, almost looks fresh enough to eat.");
                rooms[11] = new RoomClass(false, 14, 12, 9, 10, 0, 0, "Kitchen: ", "A clay oven, Stone Cook tops, knives, and a garden still growing where sun shines in from the celieng.");
                rooms[12] = new RoomClass(false, 0, 13, 36,11, 0, 0, "Music Room:", "String, wind, and percussion instruments are skattered around the room");
                rooms[36] = new RoomClass(false, 12, 0, 0, 9, 0, 0,"Reflection Pool","Water looks so clear kinda want to dive in");
                rooms[13] = new RoomClass(false, 0, 0, 0, 12, 0, 0, "Third Learning: ", "");
                rooms[14] = new RoomClass(false, 18, 17, 11, 15, 0, 0, "Treasure treasure", "Lots of round dusty objects are skattered on the floor.");
                rooms[15] = new RoomClass(false, 0, 14, 0, 16, 0, 0, "Throne Room: ", " Golden thrones are at the top of a tower of stairs looking down onto a great wide floor.");
                rooms[16] = new RoomClass(false, 19, 15, 0, 0, 0, 0, "Snake Trap: ", "A pit of snakes, they take all your money.");
                rooms[17] = new RoomClass(false, 0, 18, 40, 14, 0, 0, ";~)  ", "Hint hint, if you look for it");
                rooms[18] = new RoomClass(false, 21, 17, 14, 20, 0, 0, "Break Room", "What is it you need? Chances are we got it here.");
                rooms[19] = new RoomClass(false, 24, 0, 16, 0, 0, 0, "Bed Room", "A huge room with a bed that looks fun to jump on.");
                rooms[20] = new RoomClass(false, 124, 18, 0, 0, 0, 0, "Side Room:", "This side room has a bit of everything, from gold to ways to heal yourself.");
                rooms[21] = new RoomClass(true, 23, 22, 18, 0, 0, 0, "Argus's Room: ", "A dog is sitting in the center of the room. When you walk in his tail starts wagging, how cute. Make sure to tell him he's a good boy!");
                rooms[22] = new RoomClass(true, 0, 0, 0, 21, 0, 0, "Dark Wind: ", "Walking in gives you the chills as a gust of wind comes from no where! You see a shadow fly across the room then stand still. Wonder if it's friendly...");
                rooms[23] = new RoomClass(false, 25, 123, 21, 0, 0, 0, "Battle Grounds: ", "A giant bird is flying around. You take a step in and it shoots fire at you from its mouth. It looks like it's either you or him.");
                rooms[24] = new RoomClass(false, 0, 0, 20, 19, 0, 27, "Painted Hall", "The walls are full of hieroglyphs. They look importand, if only you had a book that you could /TRANSLATE WALLS USING BOOK/. ");
                rooms[25] = new RoomClass(true, 26, 0, 23, 0, 0, 0, "Fly High Room: ", "There is a big tree growing in an almost dark room. Little glissing balls of light fly round it. You cant make out what they are till you see a light that looks like a little human with wings sitting at the ase of the tree. ");
                rooms[26] = new RoomClass(false, 229, 0, 25, 0, 0, 0, "Balancing the Sides: ", "Walking in you see the only other door to the north. The door is bloked with a gate. Wtitten on the gate is a message and a scale with a small yellow ball weighing down one side. ");
                rooms[27] = new RoomClass(false, 230, 0, 224, 231, 0, 0, "Rusing River: ", "The door closes behind you. Blocking the other doors fast flowing river. To lower the bridge or open your door it looks like there is a key pad looking for a word. try and read the Clue");
                rooms[28] = new RoomClass(false, 34, 0, 23, 0, 0, 0, "Empty Hall", " Just more paintings on the side of the walls");
                rooms[29] = new RoomClass(false, 0, 0, 26, 30, 0, 0, "Golden hall", "Beautiful golden walls, with some healing flowers growing on the sides.");
                rooms[30] = new RoomClass(false, 32, 29, 27, 0, 0, 0, "Armory", "A stone room with weapons hung on racks");
                rooms[31] = new RoomClass(false, 0, 27, 0, 32, 0, 0, "Clue:", "One big drawing is on the wall with an inscription at the bottom. You may want to take a better look at it.");
                rooms[32] = new RoomClass(false, 33, 0, 30, 31, 0, 0, "Bitter Sweet: ", "There is a beautiful young woman pacing back and forth. Her hands look Cold as Ice and her hair is frozen over. You walk towards her and when you're close enough she hits you hard wih her frozen boots.");
                rooms[33] = new RoomClass(false, 0, 134, 32, 135, 0, 0, "Trophy Room: ", "A massive room and the only thing in it is a piller with the Golden Blizing on it trapped within a cage with a lock on the outside. Looks like one more riddle ");
                rooms[34] = new RoomClass(true, 0, 28, 0, 33, 0, 0, "All knowing: ", "A small girl sits in a little rocking chair reading a book, /Listen/ She says and hear of this place.");
                rooms[35] = new RoomClass(false, 0, 33, 0, 0, 0, 0, "Credits: ", "    ");
                rooms[41] = new RoomClass(false, 10, 0, 0, 0, 0, 0, "Grand Room: ", "Lots of golden furniture. Look that fruit looks as if it was just picked.");

                rooms[2].roomItem.Add(new ItemClass(1, "TORCH", "Lights Up The Room", 0, 1, 3));
                rooms[11].roomItem.Add(new ItemClass(2, "KNIFE", "Sharp And Pointy, great for chopping", 3, 10, 2));
                rooms[30].roomItem.Add(new ItemClass(3, "SWORD", "Weapon for a hero", 5, 10, 3));
                rooms[30].roomItem.Add(new ItemClass(4, "SPEARS", "Perfect at throwing at monsters", 3, 3, 3));
                rooms[30].roomItem.Add(new ItemClass(5, "BOW", "great for shooting arrows", 3, 40, 0));
                rooms[30].roomItem.Add(new ItemClass(6, "ARROWS", "Can be shot out of a bow", 3, 5, 1));
                rooms[30].roomItem.Add(new ItemClass(6, "ARROWS", "Can be shot out of a bow", 3, 5, 1));

                rooms[5].helper[5] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");
                    rooms[5].helper[5].QA.Add(new QandA(1, "Where am I and how do I get the Blizing?", "Welcome to the Temple of the Moon, To get the blizing you just have to get to it alive."));
                    rooms[5].helper[5].QA.Add(new QandA(2, "What challenges will I have to face?", " This temple has been lined with riddles, monsters, and traps garding the blizing. Of corse we all have some hidden shortcuts..."));
                    rooms[5].helper[5].QA.Add(new QandA(3, "What if I get lost?", "Helpers are around the temple, If you can read hyroglyphs the walls will be helpful. There may or may not be a translation book around these few rooms."));
                    rooms[5].helper[5].QA.Add(new QandA(-4, "Extra Question: ", "Helpers are around the temple, If you can read hyroglyphs the walls will be helpful. There may or may not be a translation book around these few rooms."));
                rooms[21].helper[21] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");
                rooms[22].helper[22] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");
                rooms[25].helper[25] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");
            }
            //only in games less than 5
            if (GameNumber % 2 != 0 && GameNumber < 5)
            {
                rooms[1] = new RoomClass(false, 2, 0, 0, 0, 0, 0, "Forest: ", " Up for an Adventure? Head north to go inside the acient temple;~)");
                rooms[2] = new RoomClass(false, 5, 41, 1, 42, 0, 0, "Entrance: ", "The room is lit up by torches. This isn't so bad, Lets go get the Golden Blizing");
                rooms[41] = new RoomClass(false, 4, 2, 0, 0, 0, 0, "Hall: ", "Not much to see. Shall we keep going?");
                rooms[42] = new RoomClass(false, 3, 0, 0, 2, 0, 0, "Hall: ", "Not much to see. Shall we keep going?");
                rooms[3] = new RoomClass(false, 6, 0, 42, 5, 0, 0, "Room of Gold: ", "Looks like a treasure room. ");
                rooms[4] = new RoomClass(false, 7, 5, 41, 0, 0, 0, "Treasure Hall: ", "Looks like a room that could be filled with lots of gold. ");
                rooms[5] = new RoomClass(true, 9, 3, 2, 4, 0, 0, "Oberon's Room: ", "A little cozy room, three walls full of books. In the corner is a chair with a little stone statue that looks like it could be reading. Wouldn't it be nice if you could speak to such a wise looking statue.");
                rooms[6] = new RoomClass(false, 0, 0, 3, 0, 0, 0, "First Understanding: ", " ");
                rooms[7] = new RoomClass(false, 0, 0, 4, 8, 0, 0, "Second Knowing: ", "");
                rooms[8] = new RoomClass(false, 110, 7, 0, 0, 0, 0, "Art Gallary", "So many paintings along the walls, There is a circle of statues in the middle of the room curounding a fountain");
                rooms[9] = new RoomClass(false, 11, 12, 5, 10, 0, 0, " First Battle: ", "There is a beast in the middle of the room...");
                rooms[10] = new RoomClass(false, 11, 9, 41, 8, 0, 0, "Dining room: ", "A long wooden table with acient food spread on it, almost looks fresh enough to eat.");
                rooms[11] = new RoomClass(false, 14, 12, 9, 10, 0, 0, "Kitchen: ", "A clay oven, Stone Cook tops, knives, and a garden still growing where sun shines in from the celieng.");
                rooms[12] = new RoomClass(false, 11, 13, 0, 9, 0, 0, "Music Room:", "String, wind, and percussion instruments are skattered around the room");
                rooms[13] = new RoomClass(false, 0, 0, 0, 12, 0, 0, "Third Learning: ", "");
                rooms[14] = new RoomClass(false, 18, 17, 11, 15, 0, 0, "Treasure treasure", "Lots of round dusty objects are skattered on the floor.");
                rooms[15] = new RoomClass(false, 0, 14, 0, 16, 0, 0, "Throne Room: ", " Golden thrones are at the top of a tower of stairs looking down onto a great wide floor.");
                rooms[16] = new RoomClass(false, 19, 15, 0, 0, 0, 0, "Snake Trap: ", "A pit of snakes, they take all your money.");
                rooms[17] = new RoomClass(false, 0, 18, 40, 14, 0, 0, ";~)  ", "Hint hint, if you look for it");
                rooms[18] = new RoomClass(false, 21, 17, 14, 20, 0, 0, "Break Room", "What is it you need? Chances are we got it here.");
                rooms[19] = new RoomClass(false, 24, 0, 16, 0, 0, 0, "Bed Room", "A huge room with a bed that looks fun to jump on.");
                rooms[20] = new RoomClass(false, 124, 18, 0, 0, 0, 0, "Side Room:", "This side room has a bit of everything, from gold to ways to heal yourself.");
                rooms[21] = new RoomClass(true, 23, 22, 18, 0, 0, 0, "Argus's Room: ", "A dog is sitting in the center of the room. When you walk in his tail starts wagging, how cute. Make sure to tell him he's a good boy!");
                rooms[22] = new RoomClass(true, 0, 0, 0, 21, 0, 0, "Dark Wind: ", "Walking in gives you the chills as a gust of wind comes from no where! You see a shadow fly across the room then stand still. Wonder if it's friendly...");
                rooms[23] = new RoomClass(false, 25, 123, 21, 0, 0, 0, "Battle Grounds: ", "A giant bird is flying around. You take a step in and it shoots fire at you from its mouth. It looks like it's either you or him.");
                rooms[24] = new RoomClass(false, 0, 0, 20, 19, 0, 27, "Painted Hall", "The walls are full of hieroglyphs. They look importand, if only you had a book that you could /TRANSLATE WALLS USING BOOK/. ");
                rooms[25] = new RoomClass(true, 26, 0, 23, 0, 0, 0, "Fly High Room: ", "There is a big tree growing in an almost dark room. Little glissing balls of light fly round it. You cant make out what they are till you see a light that looks like a little human with wings sitting at the base of the tree. ");
                rooms[26] = new RoomClass(false, 229, 0, 25, 0, 0, 0, "Balancing the Sides: ", "Walking in you see the only other door to the north. The door is bloked with a gate. Wtitten on the gate is a message and a scale with a small yellow ball weighing down one side. ");
                rooms[27] = new RoomClass(false, 230, 0, 224, 231, 0, 0, "Rusing River: ", "The door closes behind you. Blocking the other doors fast flowing river. To lower the bridge or open your door it looks like there is a key pad looking for a word. try and read the Clue");
                rooms[28] = new RoomClass(false, 34, 0, 23, 0, 0, 0, "Empty Hall", " Just more paintings on the side of the walls");
                rooms[29] = new RoomClass(false, 0, 0, 26, 30, 0, 0, "Golden hall", "Beautiful golden walls, with some healing flowers growing on the sides.");
                rooms[30] = new RoomClass(false, 32, 29, 27, 0, 0, 0, "Armory", "A stone room with weapons hung on racks");
                rooms[31] = new RoomClass(false, 0, 27, 0, 32, 0, 0, "Clue:", "One big drawing is on the wall with an inscription at the bottom. You may want to take a better look at it.");
                rooms[32] = new RoomClass(false, 33, 0, 30, 31, 0, 0, "Bitter Sweet: ", "There is a beautiful young woman pacing back and forth. Her hands look Cold as Ice and her hair is frozen over. You walk towards her and when you're close enough she hits you hard wih her frozen boots.");
                rooms[33] = new RoomClass(false, 0, 134, 32, 135, 0, 0, "Trophy Room: ", "A massive room and the only thing in it is a piller with the Golden Blizing on it trapped within a cage with a lock on the outside. Looks like one more riddle ");
                rooms[34] = new RoomClass(false, 0, 28, 0, 33, 0, 0, "All knowing: ", "A small girl sits in a little rocking chair reading a book, /Listen/ She says and hear of this place.");
                rooms[35] = new RoomClass(false, 0, 33, 0, 0, 0, 0, "Credits: ", "    ");
                rooms[41] = new RoomClass(false, 10, 0, 0, 42, 0, 0, "Grand Room: ", "Lots of golden furniture. Look that fruit looks as if it was just picked.");
                rooms[42] = new RoomClass(false, 0, 41, 143, 0, 0, 0, "Black Out: ", "The room is so dark walking in, the tourch light seems to be engulfed by the darkness. Was that a noise?");
                rooms[43] = new RoomClass(false, 43, 0, 133, 0, 0, 0, "Empty: ", "Just stone walls");

                rooms[3].roomItem.Add(new ItemClass(10, "GOLD", "Adds to your wealth", 5, 0, 0));
                rooms[10].roomItem.Add(new ItemClass(10, "GOLD", "Adds to your wealth", 2, 0, 0));
                rooms[14].roomItem.Add(new ItemClass(10, "GOLD", "Adds to your wealth", 5, 0, 0));
                rooms[15].roomItem.Add(new ItemClass(10, "GOLD", "Adds to your wealth", 5, 0, 0));
                rooms[18].roomItem.Add(new ItemClass(10, "GOLD", "Adds to your wealth", 5, 0, 0));
                rooms[25].roomItem.Add(new ItemClass(10, "GOLD", "Adds to your wealth", 5, 0, 0));
                rooms[29].roomItem.Add(new ItemClass(10, "GOLD", "Adds to your wealth", 5, 0, 0));
                rooms[41].roomItem.Add(new ItemClass(10, "GOLD", "Adds to your wealth", 5, 0, 0));
                rooms[43].roomItem.Add(new ItemClass(10, "GOLD", "Adds to your wealth", 20, 0, 0));

                rooms[2].roomItem.Add(new ItemClass(1, "TORCH", "Lights Up The Room", 0, 1, 3));
                rooms[5].roomItem.Add(new ItemClass(100, "TRANSLATOR", "a book that allows you to translate hints on the walls", 50, 500, 0));
                rooms[10].roomItem.Add(new ItemClass(2, "KNIFE", "Sharp And Pointy, great for chopping", 3, 10, 2));
                rooms[11].roomItem.Add(new ItemClass(2, "KNIFE", "Sharp And Pointy, great for chopping", 3, 10, 2));
                rooms[12].roomItem.Add(new ItemClass(99, "INSTRUMENT1", "Snake charmer: hypnotises snakes",15,3,1));
                rooms[12].roomItem.Add(new ItemClass(98, "INSTRUMENT2", "Pettler Flute: Playing this weakens monsters", 15, 3, 1));
                rooms[12].roomItem.Add(new ItemClass(98, "INSTRUMENT3", "Harmonica: a fun little instrument", 3, 3, 1));
                rooms[30].roomItem.Add(new ItemClass(3,"SWORD", "Weapon for a hero", 5, 10, 3));
                rooms[30].roomItem.Add(new ItemClass(4,"SPEARS", "Perfect at throwing at monsters", 3, 3, 3));
                rooms[30].roomItem.Add(new ItemClass(5,"BOW", "great for shooting arrows", 3, 40, 0));
                rooms[30].roomItem.Add(new ItemClass(6,"ARROWS", "Can be shot out of a bow", 3, 5, 1));
                rooms[30].roomItem.Add(new ItemClass(6,"ARROWS", "Can be shot out of a bow", 3, 5, 1));

                rooms[5].helper[5] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");
                    rooms[5].helper[5].QA.Add(new QandA(1, "Where am I and how do I get the Blizing?", "Welcome to the Temple of Seasons, To get the blizing you just have to get to it alive."));
                    rooms[5].helper[5].QA.Add(new QandA(2, "What challenges will I have to face?", " This temple has been lined with riddles, monsters, and traps garding the blizing. Of corse we all have some hidden shortcuts..."));
                    rooms[5].helper[5].QA.Add(new QandA(3, "What if I get lost?", "Helpers are around the temple, If you can read hyroglyphs the walls will be helpful. There may or may not be a translation book around these few rooms."));
                    rooms[5].helper[5].QA.Add(new QandA(-4, "Extra Question: ", "Helpers are around the temple, If you can read hyroglyphs the walls will be helpful. There may or may not be a translation book around these few rooms."));
                rooms[21].helper[21] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");
                rooms[22].helper[22] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");
                rooms[25].helper[25] = new HelperClass(1, "Oberon: ", "Welcome, " + Name + ",  I am Oberon. Type the number associated with each question for me to answer.");

            }

            //A bit underprepaired, but great at asking questions that could be extra useful
            CharacterClass Tourist = new CharacterClass(1, Name, "Tourist: you are able to ask extra questions that others may not think about",", You're not familier with the area, but walking away from the tour group was a adventurous descision " +
                "that has brought you to an acient temple. You had heard the tourest guide say something about a priceless, long lost Golden Blizing that is somewhere in there. ", 10, 50, 5,2);
            CharacterClass Archaeologist = new CharacterClass(2, Name, "Archaeologist: Temples like these are your specialty, you understand the hyroglif meanings and don't need a translator.", ", You have been studying temples like this one for years, when you heard about the priceless, long lost," +
                "Golden Blizing you had to come take a look. ", 10, 15, 5,3);
            CharacterClass HomeDesigner = new CharacterClass(3, Name, "Home Designer: You know when a wall looks funky, you can easily find passages others might not have thought about.", ", A very well off client has asked you to design a get-away home for them. They wanted it to feel like" +
                "it was an acient temple, and this one caught your eye. When looking around at the features someone told you about a priceless, long lost Golden Blizing. ", 10, 5, 5,3);
            CharacterClass Soldier = new CharacterClass(4, Name, "Soldier: You are skilled in combat and can take on whatever comes your way.", ", Your day off from training, a few of your friends " +
                " dared you to go into the cave and look for the priceless, long lost Golden Blizing. You're not chicken are you?", 12, 0, 5,5);
            CharacterClass NativeChild = new CharacterClass(5, Name, "Native Child: you have heard all the the riddles and stories before, all you have to do is remember.",
                ", You are young to go to school, but adventure is running through your veins. After hearing Papie tell you stories of the priceless, long lost Golden Blizing you decided that you were going to bring it back to him", 10, 0, 7, 1);




            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  Type the corresponding number with the character you would like to be: ");
            Console.ResetColor();
            Console.WriteLine("1. " + Tourist.ToString());
            Console.WriteLine("2. " + Archaeologist.ToString());
            Console.WriteLine("3. " + HomeDesigner.ToString());
            Console.WriteLine("4. " + Soldier.ToString());
            Console.WriteLine("5. " + NativeChild.ToString());
            Console.WriteLine();

            int userNumber;
            bool work = false;
            do
            {
                userNumber = EnterAnInt();
                if (userNumber == 1 || userNumber == 2 || userNumber == 3 || userNumber == 4 || userNumber == 5)
                {
                    Console.WriteLine();
                    work = true;
                }
                else
                {
                    Console.WriteLine("try again");
                    Console.WriteLine();
                }
            } while (work != true);

            if (userNumber == Tourist.CharacterNumber)
            {
                Console.WriteLine(Name + Tourist.CharacterInfo);
            }
            else if (userNumber == Archaeologist.CharacterNumber)
            {
                Console.WriteLine(Name + Archaeologist.CharacterInfo);
            }
            else if (userNumber == HomeDesigner.CharacterNumber)
            {
                Console.WriteLine(Name + HomeDesigner.CharacterInfo);
            }
            else if (userNumber == Soldier.CharacterNumber)
            {
                Console.WriteLine(Name + Soldier.CharacterInfo);
            }
            else if (userNumber == NativeChild.CharacterNumber)
            {
                Console.WriteLine(Name + NativeChild.CharacterInfo);
            }
            Console.ReadKey();
            Console.Clear();

            //Game Loop
            do
            {
                if(rooms[currentRoom].HasHelper == true)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();

                    if (rooms[currentRoom].HasHelper == true)
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        ConsoleColor currentBackground = Console.BackgroundColor;
                    }
                }
                else
                {
                    if(Console.BackgroundColor == ConsoleColor.DarkBlue)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();

                    }
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                Console.WriteLine();
                if (rooms[currentRoom] == rooms[1]  || rooms[currentRoom] == rooms[2] )
                {
                    Console.WriteLine(rooms[currentRoom].visitRoom());
                }
                else if(inventory.Contains(inventory.Find(item => item.ItemName == "TORCH")))
                {
                    Console.WriteLine(rooms[currentRoom].visitRoom());
                }
                else
                {
                    Console.WriteLine("It's Too dark in here to see, we need a torch");
                }     
                Console.WriteLine("Command (N,E,S,W,U,D,Q): ");

                command = Console.ReadLine().ToUpper();
                string[] commandWords = command.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                //Single letter Directrions
                if (commandWords.Length == 1)
                {
                    if (commandWords[0] == "N" || commandWords[0] == "E" || commandWords[0] == "S" || commandWords[0] == "W" || commandWords[0] == "U" || commandWords[0] == "D" ||
                        commandWords[0] == "NORTH" || commandWords[0] == "EAST" || commandWords[0] == "SOUTH" || commandWords[0] == "WEST" ||
                        commandWords[0] == "UP" || commandWords[0] == "Down")
                    {

                        if (commandWords[0] == "N" && rooms[currentRoom].ToNorth > 0 && rooms[currentRoom].ToNorth < 100 ||
                            commandWords[0] == "NORTH" && rooms[currentRoom].ToNorth > 0 && rooms[currentRoom].ToNorth < 100)
                        {
                            currentRoom = rooms[currentRoom].ToNorth;
                            Console.WriteLine();
                        }
                        else if (commandWords[0] == "E" && rooms[currentRoom].ToEast > 0 && rooms[currentRoom].ToEast < 100 ||
                            commandWords[0] == "EAST" && rooms[currentRoom].ToEast > 0 && rooms[currentRoom].ToEast < 100)
                        {
                            currentRoom = rooms[currentRoom].ToEast;
                            Console.WriteLine();

                        }
                        else if (commandWords[0] == "S" && rooms[currentRoom].ToSouth > 0 && rooms[currentRoom].ToSouth < 100 ||
                            commandWords[0] == "SOUTH" && rooms[currentRoom].ToSouth > 0 && rooms[currentRoom].ToSouth < 100)
                        {
                            currentRoom = rooms[currentRoom].ToSouth;
                            Console.WriteLine();

                        }
                        else if (commandWords[0] == "W" && rooms[currentRoom].ToWest > 0 && rooms[currentRoom].ToWest < 100 ||
                            commandWords[0] == "WEST" && rooms[currentRoom].ToWest > 0 && rooms[currentRoom].ToWest < 100)
                        {
                            currentRoom = rooms[currentRoom].ToWest;
                            Console.WriteLine();

                        }
                        else if (commandWords[0] == "U" && rooms[currentRoom].ToUp > 0 && rooms[currentRoom].ToUp < 100 ||
                            commandWords[0] == "UP" && rooms[currentRoom].ToUp > 0 && rooms[currentRoom].ToUp < 100)
                        {
                            currentRoom = rooms[currentRoom].ToUp;
                            Console.WriteLine();

                        }
                        else if (commandWords[0] == "D" && rooms[currentRoom].ToDown > 0 && rooms[currentRoom].ToDown < 100 ||
                            commandWords[0] == "Down" && rooms[currentRoom].ToDown > 0 && rooms[currentRoom].ToDown < 100)
                        {
                            currentRoom = rooms[currentRoom].ToDown;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, You can't go that way ");
                            Console.WriteLine();
                        }
                    }
                    else if (commandWords[0] == "SEARCH")
                    {
                        //Finds Hidden and Locked Rooms
                        if (rooms[currentRoom].ToNorth >= 100 && rooms[currentRoom].ToNorth <= 200)
                        {
                            Console.WriteLine("You have found a passage to the north, but it is locked");
                            Console.WriteLine();
                            rooms[currentRoom].ToNorth = rooms[currentRoom].ToNorth * -1;
                        }
                        if (rooms[currentRoom].ToEast >= 100 && rooms[currentRoom].ToEast <= 200)
                        {
                            Console.WriteLine("You have found a passage to the east, but it is locked");
                            Console.WriteLine();
                            rooms[currentRoom].ToEast = rooms[currentRoom].ToEast * -1;
                        }
                        if (rooms[currentRoom].ToSouth >= 100 && rooms[currentRoom].ToSouth <= 200)
                        {
                            Console.WriteLine("You have found a passage to the south, but it is locked");
                            Console.WriteLine();
                            rooms[currentRoom].ToSouth = rooms[currentRoom].ToSouth * -1;
                        }
                        if (rooms[currentRoom].ToWest >= 100 && rooms[currentRoom].ToWest <= 200)
                        {
                            Console.WriteLine("You have found a passage to the west, but it is locked");
                            Console.WriteLine();
                            rooms[currentRoom].ToWest = rooms[currentRoom].ToWest * -1;
                        }
                        if (rooms[currentRoom].ToUp >= 100 && rooms[currentRoom].ToUp <= 200)
                        {
                            Console.WriteLine("You have found an Upper passage, but it is locked");
                            Console.WriteLine();
                            Console.WriteLine();
                            rooms[currentRoom].ToUp = rooms[currentRoom].ToUp * -1;
                        }
                        if (rooms[currentRoom].ToDown >= 100 && rooms[currentRoom].ToDown <= 200)
                        {
                            Console.WriteLine("You have found a passage under the floor, but it is locked");
                            Console.WriteLine();
                            rooms[currentRoom].ToDown = rooms[currentRoom].ToDown * -1;
                        }

                        //Finds Hidden Rooms
                        if (rooms[currentRoom].ToNorth >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToNorth = rooms[currentRoom].ToNorth - 200;
                        }
                        if (rooms[currentRoom].ToEast >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToEast = rooms[currentRoom].ToEast - 200;
                        }
                        if (rooms[currentRoom].ToSouth >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToSouth = rooms[currentRoom].ToSouth - 200;
                        }
                        if (rooms[currentRoom].ToWest >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToWest = rooms[currentRoom].ToWest - 200;
                        }
                        if (rooms[currentRoom].ToUp >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToUp = rooms[currentRoom].ToUp - 200;
                        }
                        if (rooms[currentRoom].ToDown >= 200)
                        {
                            Console.WriteLine("You have found a passage, Now You Can See Where It Leads");
                            Console.WriteLine();
                            rooms[currentRoom].ToDown = rooms[currentRoom].ToDown - 200;
                        }
                    }
                    else if (commandWords[0] == "LOOK")
                    {
                        Console.WriteLine();
                        Console.WriteLine(rooms[currentRoom].RoomDescription);
                        Console.WriteLine();
                    }
                    else if (commandWords[0] == "SPEAK")
                    {
                        Console.WriteLine();
                        Console.WriteLine(Name + ": Hello?");
                        if (rooms[currentRoom].HasHelper == true)
                        {
                            Console.WriteLine(rooms[currentRoom].helper[currentRoom].HelperName + rooms[currentRoom].helper[currentRoom].HelperInfo);
                            Console.WriteLine();
                            bool again = false;

                            do
                            {
                                foreach (QandA question in rooms[currentRoom].helper[currentRoom].QA)
                                {
                                    if (userNumber == Tourist.CharacterNumber && question.QuestionNumber < 0)
                                    {
                                        question.QuestionNumber *= -1;
                                    }
                                    if (question.QuestionNumber > 0)
                                    {
                                        Console.WriteLine(question.QuestionNumber + ": " + question.Question);
                                    }
                                }
                                bool correctQuestion = false;
                                do
                                {
                                    int answerNumber = EnterAnInt();
                                    foreach (QandA question in rooms[currentRoom].helper[currentRoom].QA)
                                    {
                                        if (answerNumber == question.QuestionNumber)
                                        {
                                            if (question.QuestionNumber > 0)
                                            {
                                                Console.WriteLine(question.Answer);
                                                correctQuestion = true;
                                            }
                                        }
                                    }
                                } while (correctQuestion != true);

                                Console.WriteLine("Would you like to ask another question? Y/N: ");
                                string goingAgain = Console.ReadLine().ToUpper();
                                if( goingAgain == "Y" || goingAgain == "YES")
                                {
                                    again = true;
                                }
                                else if (goingAgain == "N" || goingAgain == "NO")
                                {
                                    again = false;
                                }
                                else
                                {
                                    Console.WriteLine("I'll Take that as a no");
                                    again = false;
                                }


                            } while (again != false);
                            
                            
                        }
                        else
                        {
                            Console.WriteLine("...");
                            Console.WriteLine("Nothing, looks like there is no one here to speak with");
                        }
                    }

                    else if (commandWords[0] == "HELP")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Type N, S, E, W, U, D to move through rooms");
                        Console.WriteLine("Search, Unlock With ____, Get ___, Drop ____, Read Note, Info ____, Dig With ____, inventory, look ");
                        Console.WriteLine();
                    }

                    //Command error catch
                    else if (commandWords[0] == "DIG")
                    {
                        Console.WriteLine();
                        Console.WriteLine("What would you like to dig WITH? ");
                        Console.WriteLine();
                    }

                    else if (commandWords[0] == "UNLOCK")
                    {
                        Console.WriteLine("What would you like to unlock that WITH? ");
                        Console.WriteLine();
                    }
                    else if (commandWords[0] == "GET")
                    {
                        Console.WriteLine("What ITEM would you like to get? ");
                        Console.WriteLine();
                    }
                    else if (commandWords[0] == "DROP")
                    {
                        Console.WriteLine("What ITEM would you like to drop? ");
                        Console.WriteLine();
                    }
                    else if (commandWords[0] == "READ")
                    {
                        Console.WriteLine("What would you like to read? ");
                        Console.WriteLine();
                    }

                    // commands with at least three words
                    //check to see what you are carrying
                    else if (commandWords[0].Length >= 3 && commandWords[0].Substring(0, 3) == "INV")
                    {
                        Console.WriteLine("You are carrying the following Items: ");
                        Console.WriteLine();

                        if (inventory.Count == 0)
                        {
                            Console.WriteLine("Nothing");
                            Console.WriteLine();
                        }
                        else
                        {
                            foreach (ItemClass item in inventory)
                            {
                                Console.WriteLine(item.ItemName);
                            }
                            Console.WriteLine();

                        }

                    }
                }
                else if (commandWords.Length == 2)
                {
                    if (commandWords[0] == "GET")
                    {
                        if (rooms[currentRoom].roomItem.Find(item => item.ItemName == commandWords[1]) != null)
                        {
                            inventory.Add(rooms[currentRoom].roomItem.Find(item => item.ItemName == commandWords[1]));
                            rooms[currentRoom].roomItem.Remove(rooms[currentRoom].roomItem.Find(item => item.ItemName == commandWords[1]));
                            Console.WriteLine("You picked up a(n) " + commandWords[1]);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("I do not see a " + commandWords[1] + " here!");
                            Console.WriteLine();
                        }
                    }

                    if (commandWords[0] == "DROP")
                    {
                        if (inventory.FindIndex(item => item.ItemName == commandWords[1]) >= 0)
                        {
                            rooms[currentRoom].roomItem.Add(inventory.Find(item => item.ItemName == commandWords[1]));
                            inventory.Remove(inventory.Find(item => item.ItemName == commandWords[1]));
                            Console.WriteLine("You dropped the " + commandWords[1]);
                        }
                        else
                        {
                            Console.WriteLine("There is not a " + commandWords[1] + "in your inventory!");
                            Console.WriteLine();

                        }
                    }
                    else if (commandWords[0] == "GO")
                    {
                        if (commandWords[1] == "N" && rooms[currentRoom].ToNorth > 0 && rooms[currentRoom].ToNorth < 100 ||
                            commandWords[1] == "NORTH" && rooms[currentRoom].ToNorth > 0 && rooms[currentRoom].ToNorth < 100)
                        {
                            currentRoom = rooms[currentRoom].ToNorth;
                            Console.WriteLine();
                        }
                        else if (commandWords[1] == "E" && rooms[currentRoom].ToEast > 0 && rooms[currentRoom].ToEast < 100 ||
                            commandWords[1] == "EAST" && rooms[currentRoom].ToEast > 0 && rooms[currentRoom].ToEast < 100)
                        {
                            currentRoom = rooms[currentRoom].ToEast;
                            Console.WriteLine();

                        }
                        else if (commandWords[1] == "S" && rooms[currentRoom].ToSouth > 0 && rooms[currentRoom].ToSouth < 100 ||
                            commandWords[1] == "SOUTH" && rooms[currentRoom].ToSouth > 0 && rooms[currentRoom].ToSouth < 100)
                        {
                            currentRoom = rooms[currentRoom].ToSouth;
                            Console.WriteLine();

                        }
                        else if (commandWords[1] == "W" && rooms[currentRoom].ToWest > 0 && rooms[currentRoom].ToWest < 100 ||
                            commandWords[1] == "WEST" && rooms[currentRoom].ToWest > 0 && rooms[currentRoom].ToWest < 100)
                        {
                            currentRoom = rooms[currentRoom].ToWest;
                            Console.WriteLine();

                        }
                        else if (commandWords[1] == "U" && rooms[currentRoom].ToUp > 0 && rooms[currentRoom].ToUp < 100 ||
                            commandWords[1] == "UP" && rooms[currentRoom].ToUp > 0 && rooms[currentRoom].ToUp < 100)
                        {
                            currentRoom = rooms[currentRoom].ToUp;
                            Console.WriteLine();

                        }
                        else if (commandWords[1] == "D" && rooms[currentRoom].ToDown > 0 && rooms[currentRoom].ToDown < 100 ||
                            commandWords[1] == "DOWN" && rooms[currentRoom].ToDown > 0 && rooms[currentRoom].ToDown < 100)
                        {
                            currentRoom = rooms[currentRoom].ToDown;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, You can't go that way ");
                            Console.WriteLine();
                        }

                    }
                    else if (commandWords[0] == "INFO" && commandWords[1] == "SHOVEL")
                    {
                        Console.WriteLine();
                        Console.WriteLine("SHOVEL: Useful For Digging");
                        Console.WriteLine();

                    }

                }
            } while (command != "Q");
            Console.ReadKey();
        }

        private static string GetName()
        {
            string Name = "";
            Console.ForegroundColor = ConsoleColor.Blue;
            string b = " What would you like to be named: ";
            Console.SetCursorPosition((Console.WindowWidth - b.Length) / 2, Console.CursorTop);
            Console.WriteLine(b);
            Console.ResetColor();

            Console.Write("                                                       ");
            Name = Console.ReadLine();
            return Name;
        }
        private static int EnterAnInt()
        {
            int inputInt = 0;
           
                try
                {
                    
                    inputInt = Int32.Parse(Console.ReadLine());
                    

                }
                catch
                {
                        Console.WriteLine("Needs to be a whole number!");
                      
                }
            return inputInt;
        }
       
    }
}
