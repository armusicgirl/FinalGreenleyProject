using System;

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

            //List<ItemClass> inventory = new List<ItemClass>();

            //string commandString = Console.ReadLine().ToUpper();
            string[] charSeparators = new string[] { " ", ",", "." };

            RoomClass[] rooms = new RoomClass[335]; // N, E, S, W, U, D

            if (GameNumber % 2 == 0)
            {
                rooms[1] = new RoomClass(2, 0, 0, 0, 0, 0, "Forest: ", " Up for an Adventure? Head north to go inside the acient temple;~)");
                rooms[2] = new RoomClass(5, 3, 1, 4, 0, 0, "Entrance: ", "The room is lit up by tourches. This isn't so bad, Lets go get the Golden Blizing");
                rooms[3] = new RoomClass(6, 2, 0, 5, 0, 0, "Room of Gold: ", "Looks like a treasure room. ");
                rooms[4] = new RoomClass(7, 5, 0, 2, 0, 0, "Treasure Hall: ", "Looks like a room that could be filled with lots of gold. ");
                rooms[5] = new RoomClass(9, 3, 2, 4, 0, 0, "Oberon's Room: ", "A little cozy room, three walls full of books. In the corner is a chair with a little stone statue that looks like it could be reading. Wouldn't it be nice if you could speak to such a wise looking statue.");
                rooms[6] = new RoomClass(0, 0, 3, 0, 0, 0, "First Understanding: ", " ");
                rooms[7] = new RoomClass(0, 0, 4, 8, 0, 0, "Second Knowing: ", "");
                rooms[8] = new RoomClass(110, 7, 0, 0, 0, 0, "Art Gallary", "So many paintings along the walls, There is a circle of statues in the middle of the room curounding a fountain");
                rooms[9] = new RoomClass(11, 12, 5, 10, 0, 0, " First Battle: ", "There is a beast in the middle of the room...");
                rooms[10] = new RoomClass(11, 9, 0, 8, 0, 0, "Dining room: ", "A long wooden table with acient food spread on it, almost looks fresh enough to eat.");
                rooms[11] = new RoomClass(14, 12, 9, 10, 0, 0, "Kitchen: ", "A clay oven, Stone Cook tops, knives, and a garden still growing where sun shines in from the celieng.");
                rooms[12] = new RoomClass(11, 13, 0, 9, 0, 0, "Music Room:", "String, wind, and percussion instruments are skattered around the room");
                rooms[13] = new RoomClass(0, 0, 0, 12, 0, 0, "Third Learning: ", "");
                rooms[14] = new RoomClass(18, 17, 11, 15, 0, 0, "Treasure treasure", "Lots of round dusty objects are skattered on the floor.");
                rooms[15] = new RoomClass(0, 14, 0, 16, 0, 0, "Throne Room: ", " Golden thrones are at the top of a tower of stairs looking down onto a great wide floor.");
                rooms[16] = new RoomClass(19, 15, 0, 0, 0, 0, "Snake Trap: ", "A pit of snakes, they take all your money.");
                rooms[17] = new RoomClass(0, 18, 40, 14, 0, 0, ";~)  ", "Hint hint, if you look for it");
                rooms[18] = new RoomClass(21, 17, 14, 20, 0, 0, "Break Room", "What is it you need? Chances are we got it here.");
                rooms[19] = new RoomClass(24, 0, 16, 0, 0, 0, "Bed Room", "A huge room with a bed that looks fun to jump on.");
                rooms[20] = new RoomClass(124, 18, 0, 0, 0, 0, "Side Room:", "This side room has a bit of everything, from gold to ways to heal yourself.");
                rooms[21] = new RoomClass(23, 22, 18, 0, 0, 0, "Argus's Room: ", "A dog is sitting in the center of the room. When you walk in his tail starts wagging, how cute. Make sure to tell him he's a good boy!");
                rooms[22] = new RoomClass(0, 0, 0, 21, 0, 0, "Dark Wind: ", "Walking in gives you the chills as a gust of wind comes from no where! You see a shadow fly across the room then stand still. Wonder if it's friendly...");
                rooms[23] = new RoomClass(25, 123, 21, 0, 0, 0, "Battle Grounds: ", "A giant bird is flying around. You take a step in and it shoots fire at you from its mouth. It looks like it's either you or him.");
                rooms[24] = new RoomClass(0, 0, 20, 19, 0, 27, "Painted Hall", "The walls are full of hieroglyphs. They look importand, if only you had a book that you could /TRANSLATE WALLS USING BOOK/. ");
                rooms[25] = new RoomClass(26, 0, 23, 0, 0, 0, "Fly High Room: ", "There is a big tree growing in an almost dark room. Little glissing balls of light fly round it. You cant make out what they are till you see a light that looks like a little human with wings sitting at the ase of the tree. ");
                rooms[26] = new RoomClass(229, 0, 25, 0, 0, 0, "Balancing the Sides: ", "Walking in you see the only other door to the north. The door is bloked with a gate. Wtitten on the gate is a message and a scale with a small yellow ball weighing down one side. ");
                rooms[27] = new RoomClass(230, 0, 224, 231, 0, 0, "Rusing River: ", "The door closes behind you. Blocking the other doors fast flowing river. To lower the bridge or open your door it looks like there is a key pad looking for a word. try and read the Clue");
                rooms[28] = new RoomClass(34, 0, 23, 0, 0, 0, "Empty Hall", " Just more paintings on the side of the walls");
                rooms[29] = new RoomClass(0, 0, 26, 30, 0, 0, "Golden hall", "Beautiful golden walls, with some healing flowers growing on the sides.");
                rooms[30] = new RoomClass(32, 29, 27, 0, 0, 0, "Armory", "A stone room with weapons hung on racks");
                rooms[31] = new RoomClass(0, 27, 0, 32, 0, 0, "Clue:", "One big drawing is on the wall with an inscription at the bottom. You may want to take a better look at it.");
                rooms[32] = new RoomClass(33, 0, 30, 31, 0, 0, "Bitter Sweet: ", "There is a beautiful young woman pacing back and forth. Her hands look Cold as Ice and her hair is frozen over. You walk towards her and when you're close enough she hits you hard wih her frozen boots.");
                rooms[33] = new RoomClass(0, 134, 32, 135, 0, 0, "Trophy Room: ", "A massive room and the only thing in it is a piller with the Golden Blizing on it trapped within a cage with a lock on the outside. Looks like one more riddle ");
                rooms[34] = new RoomClass(0, 28, 0, 33, 0, 0, "All knowing: ", "A small girl sits in a little rocking chair reading a book, /Listen/ She says and hear of this place.");
                rooms[35] = new RoomClass(0, 33, 0, 0, 0, 0, "Credits: ", "    ");
                rooms[40] = new RoomClass(17, 0, 0, 0, 0, 0, "Story Of Time: ", "     ");
            }
            if (GameNumber % 2 != 0 && GameNumber >= 5)
            {
                rooms[1] = new RoomClass(2, 0, 0, 0, 0, 0, "Forest: ", " Up for an Adventure? Head north to go inside the acient temple;~)");
                rooms[2] = new RoomClass(5, 3, 1, 4, 0, 0, "Entrance: ", "The room is lit up by tourches. This isn't so bad, Lets go get the Golden Blizing");
                rooms[3] = new RoomClass(6, 2, 0, 5, 0, 0, "Room of Gold: ", "Looks like a treasure room. ");
                rooms[4] = new RoomClass(7, 5, 0, 2, 0, 0, "Treasure Hall: ", "Looks like a room that could be filled with lots of gold. ");
                rooms[5] = new RoomClass(9, 3, 2, 4, 0, 0, "Oberon's Room: ", "A little cozy room, three walls full of books. In the corner is a chair with a little stone statue that looks like it could be reading. Wouldn't it be nice if you could speak to such a wise looking statue.");
                rooms[6] = new RoomClass(0, 0, 3, 0, 0, 0, "First Understanding: ", " ");
                rooms[7] = new RoomClass(0, 0, 4, 8, 0, 0, "Second Knowing: ", "");
                rooms[8] = new RoomClass(110, 7, 0, 0, 0, 0, "Art Gallary", "So many paintings along the walls, There is a circle of statues in the middle of the room curounding a fountain");
                rooms[9] = new RoomClass(11, 12, 5, 10, 0, 0, " First Battle: ", "There is a beast in the middle of the room...");
                rooms[10] = new RoomClass(11, 9, 41, 8, 0, 0, "Dining room: ", "A long wooden table with acient food spread on it, almost looks fresh enough to eat.");
                rooms[11] = new RoomClass(14, 12, 9, 10, 0, 0, "Kitchen: ", "A clay oven, Stone Cook tops, knives, and a garden still growing where sun shines in from the celieng.");
                rooms[12] = new RoomClass(11, 13, 0, 9, 0, 0, "Music Room:", "String, wind, and percussion instruments are skattered around the room");
                rooms[13] = new RoomClass(0, 0, 0, 12, 0, 0, "Third Learning: ", "");
                rooms[14] = new RoomClass(18, 17, 11, 15, 0, 0, "Treasure treasure", "Lots of round dusty objects are skattered on the floor.");
                rooms[15] = new RoomClass(0, 14, 0, 16, 0, 0, "Throne Room: ", " Golden thrones are at the top of a tower of stairs looking down onto a great wide floor.");
                rooms[16] = new RoomClass(19, 15, 0, 0, 0, 0, "Snake Trap: ", "A pit of snakes, they take all your money.");
                rooms[17] = new RoomClass(0, 18, 40, 14, 0, 0, ";~)  ", "Hint hint, if you look for it");
                rooms[18] = new RoomClass(21, 17, 14, 20, 0, 0, "Break Room", "What is it you need? Chances are we got it here.");
                rooms[19] = new RoomClass(24, 0, 16, 0, 0, 0, "Bed Room", "A huge room with a bed that looks fun to jump on.");
                rooms[20] = new RoomClass(124, 18, 0, 0, 0, 0, "Side Room:", "This side room has a bit of everything, from gold to ways to heal yourself.");
                rooms[21] = new RoomClass(23, 22, 18, 0, 0, 0, "Argus's Room: ", "A dog is sitting in the center of the room. When you walk in his tail starts wagging, how cute. Make sure to tell him he's a good boy!");
                rooms[22] = new RoomClass(0, 0, 0, 21, 0, 0, "Dark Wind: ", "Walking in gives you the chills as a gust of wind comes from no where! You see a shadow fly across the room then stand still. Wonder if it's friendly...");
                rooms[23] = new RoomClass(25, 123, 21, 0, 0, 0, "Battle Grounds: ", "A giant bird is flying around. You take a step in and it shoots fire at you from its mouth. It looks like it's either you or him.");
                rooms[24] = new RoomClass(0, 0, 20, 19, 0, 27, "Painted Hall", "The walls are full of hieroglyphs. They look importand, if only you had a book that you could /TRANSLATE WALLS USING BOOK/. ");
                rooms[25] = new RoomClass(26, 0, 23, 0, 0, 0, "Fly High Room: ", "There is a big tree growing in an almost dark room. Little glissing balls of light fly round it. You cant make out what they are till you see a light that looks like a little human with wings sitting at the ase of the tree. ");
                rooms[26] = new RoomClass(229, 0, 25, 0, 0, 0, "Balancing the Sides: ", "Walking in you see the only other door to the north. The door is bloked with a gate. Wtitten on the gate is a message and a scale with a small yellow ball weighing down one side. ");
                rooms[27] = new RoomClass(230, 0, 224, 231, 0, 0, "Rusing River: ", "The door closes behind you. Blocking the other doors fast flowing river. To lower the bridge or open your door it looks like there is a key pad looking for a word. try and read the Clue");
                rooms[28] = new RoomClass(34, 0, 23, 0, 0, 0, "Empty Hall", " Just more paintings on the side of the walls");
                rooms[29] = new RoomClass(0, 0, 26, 30, 0, 0, "Golden hall", "Beautiful golden walls, with some healing flowers growing on the sides.");
                rooms[30] = new RoomClass(32, 29, 27, 0, 0, 0, "Armory", "A stone room with weapons hung on racks");
                rooms[31] = new RoomClass(0, 27, 0, 32, 0, 0, "Clue:", "One big drawing is on the wall with an inscription at the bottom. You may want to take a better look at it.");
                rooms[32] = new RoomClass(33, 0, 30, 31, 0, 0, "Bitter Sweet: ", "There is a beautiful young woman pacing back and forth. Her hands look Cold as Ice and her hair is frozen over. You walk towards her and when you're close enough she hits you hard wih her frozen boots.");
                rooms[33] = new RoomClass(0, 134, 32, 135, 0, 0, "Trophy Room: ", "A massive room and the only thing in it is a piller with the Golden Blizing on it trapped within a cage with a lock on the outside. Looks like one more riddle ");
                rooms[34] = new RoomClass(0, 28, 0, 33, 0, 0, "All knowing: ", "A small girl sits in a little rocking chair reading a book, /Listen/ She says and hear of this place.");
                rooms[35] = new RoomClass(0, 33, 0, 0, 0, 0, "Credits: ", "    ");
                rooms[41] = new RoomClass(10, 0, 0, 0, 0, 0, "Grand Room: ", "Lots of golden furniture. Look that fruit looks as if it was just picked.");
            }
            //only in games less than 5
            if (GameNumber % 2 != 0 && GameNumber < 5)
            {
                rooms[1] = new RoomClass(2, 0, 0, 0, 0, 0, "Forest: ", " Up for an Adventure? Head north to go inside the acient temple;~)");
                rooms[2] = new RoomClass(5, 3, 1, 4, 0, 0, "Entrance: ", "The room is lit up by tourches. This isn't so bad, Lets go get the Golden Blizing");
                rooms[3] = new RoomClass(6, 2, 0, 5, 0, 0, "Room of Gold: ", "Looks like a treasure room. ");
                rooms[4] = new RoomClass(7, 5, 0, 2, 0, 0, "Treasure Hall: ", "Looks like a room that could be filled with lots of gold. ");
                rooms[5] = new RoomClass(9, 3, 2, 4, 0, 0, "Oberon's Room: ", "A little cozy room, three walls full of books. In the corner is a chair with a little stone statue that looks like it could be reading. Wouldn't it be nice if you could speak to such a wise looking statue.");
                rooms[6] = new RoomClass(0, 0, 3, 0, 0, 0, "First Understanding: ", " ");
                rooms[7] = new RoomClass(0, 0, 4, 8, 0, 0, "Second Knowing: ", "");
                rooms[8] = new RoomClass(110, 7, 0, 0, 0, 0, "Art Gallary", "So many paintings along the walls, There is a circle of statues in the middle of the room curounding a fountain");
                rooms[9] = new RoomClass(11, 12, 5, 10, 0, 0, " First Battle: ", "There is a beast in the middle of the room...");
                rooms[10] = new RoomClass(11, 9, 41, 8, 0, 0, "Dining room: ", "A long wooden table with acient food spread on it, almost looks fresh enough to eat.");
                rooms[11] = new RoomClass(14, 12, 9, 10, 0, 0, "Kitchen: ", "A clay oven, Stone Cook tops, knives, and a garden still growing where sun shines in from the celieng.");
                rooms[12] = new RoomClass(11, 13, 0, 9, 0, 0, "Music Room:", "String, wind, and percussion instruments are skattered around the room");
                rooms[13] = new RoomClass(0, 0, 0, 12, 0, 0, "Third Learning: ", "");
                rooms[14] = new RoomClass(18, 17, 11, 15, 0, 0, "Treasure treasure", "Lots of round dusty objects are skattered on the floor.");
                rooms[15] = new RoomClass(0, 14, 0, 16, 0, 0, "Throne Room: ", " Golden thrones are at the top of a tower of stairs looking down onto a great wide floor.");
                rooms[16] = new RoomClass(19, 15, 0, 0, 0, 0, "Snake Trap: ", "A pit of snakes, they take all your money.");
                rooms[17] = new RoomClass(0, 18, 40, 14, 0, 0, ";~)  ", "Hint hint, if you look for it");
                rooms[18] = new RoomClass(21, 17, 14, 20, 0, 0, "Break Room", "What is it you need? Chances are we got it here.");
                rooms[19] = new RoomClass(24, 0, 16, 0, 0, 0, "Bed Room", "A huge room with a bed that looks fun to jump on.");
                rooms[20] = new RoomClass(124, 18, 0, 0, 0, 0, "Side Room:", "This side room has a bit of everything, from gold to ways to heal yourself.");
                rooms[21] = new RoomClass(23, 22, 18, 0, 0, 0, "Argus's Room: ", "A dog is sitting in the center of the room. When you walk in his tail starts wagging, how cute. Make sure to tell him he's a good boy!");
                rooms[22] = new RoomClass(0, 0, 0, 21, 0, 0, "Dark Wind: ", "Walking in gives you the chills as a gust of wind comes from no where! You see a shadow fly across the room then stand still. Wonder if it's friendly...");
                rooms[23] = new RoomClass(25, 123, 21, 0, 0, 0, "Battle Grounds: ", "A giant bird is flying around. You take a step in and it shoots fire at you from its mouth. It looks like it's either you or him.");
                rooms[24] = new RoomClass(0, 0, 20, 19, 0, 27, "Painted Hall", "The walls are full of hieroglyphs. They look importand, if only you had a book that you could /TRANSLATE WALLS USING BOOK/. ");
                rooms[25] = new RoomClass(26, 0, 23, 0, 0, 0, "Fly High Room: ", "There is a big tree growing in an almost dark room. Little glissing balls of light fly round it. You cant make out what they are till you see a light that looks like a little human with wings sitting at the ase of the tree. ");
                rooms[26] = new RoomClass(229, 0, 25, 0, 0, 0, "Balancing the Sides: ", "Walking in you see the only other door to the north. The door is bloked with a gate. Wtitten on the gate is a message and a scale with a small yellow ball weighing down one side. ");
                rooms[27] = new RoomClass(230, 0, 224, 231, 0, 0, "Rusing River: ", "The door closes behind you. Blocking the other doors fast flowing river. To lower the bridge or open your door it looks like there is a key pad looking for a word. try and read the Clue");
                rooms[28] = new RoomClass(34, 0, 23, 0, 0, 0, "Empty Hall", " Just more paintings on the side of the walls");
                rooms[29] = new RoomClass(0, 0, 26, 30, 0, 0, "Golden hall", "Beautiful golden walls, with some healing flowers growing on the sides.");
                rooms[30] = new RoomClass(32, 29, 27, 0, 0, 0, "Armory", "A stone room with weapons hung on racks");
                rooms[31] = new RoomClass(0, 27, 0, 32, 0, 0, "Clue:", "One big drawing is on the wall with an inscription at the bottom. You may want to take a better look at it.");
                rooms[32] = new RoomClass(33, 0, 30, 31, 0, 0, "Bitter Sweet: ", "There is a beautiful young woman pacing back and forth. Her hands look Cold as Ice and her hair is frozen over. You walk towards her and when you're close enough she hits you hard wih her frozen boots.");
                rooms[33] = new RoomClass(0, 134, 32, 135, 0, 0, "Trophy Room: ", "A massive room and the only thing in it is a piller with the Golden Blizing on it trapped within a cage with a lock on the outside. Looks like one more riddle ");
                rooms[34] = new RoomClass(0, 28, 0, 33, 0, 0, "All knowing: ", "A small girl sits in a little rocking chair reading a book, /Listen/ She says and hear of this place.");
                rooms[35] = new RoomClass(0, 33, 0, 0, 0, 0, "Credits: ", "    ");
                rooms[41] = new RoomClass(10, 0, 0, 42, 0, 0, "Grand Room: ", "Lots of golden furniture. Look that fruit looks as if it was just picked.");
                rooms[42] = new RoomClass(0, 41, 143, 0, 0, 0, "Black Out: ", "The room is so dark walking in, the tourch light seems to be engulfed by the darkness. Was that a noise?");
                rooms[43] = new RoomClass(43, 0, 133, 0, 0, 0, "Empty: ", "Just stone walls");
            }
            string Name = "bob";
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



        //Start Of Game Seen
            Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
            string s = "Press Enter to Start:";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
                    Console.ResetColor();
                    Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" What would you like to be named: ");
            Console.ResetColor();
            Name = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  Type the corresponding number with the character you would like to be: ");
            Console.ResetColor();
            Console.WriteLine("1. " + Tourist.ToString());
            Console.WriteLine("2. " + Archaeologist.ToString());
            Console.WriteLine("3. " + HomeDesigner.ToString());
            Console.WriteLine("4. " + Soldier.ToString());
            Console.WriteLine("5. " + NativeChild.ToString());
            Console.WriteLine();

            int userNumber = EnterAnInt();
            if (userNumber == Tourist.CharacterNumber)
            {
                Console.WriteLine(Name + Tourist.CharacterInfo);
            }
            else if(userNumber == Archaeologist.CharacterNumber)
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


            //Game Loop
            do
            {

                Console.WriteLine(rooms[currentRoom].visitRoom());
                Console.Write("Command (N,E,S,W,U,D,Q): ");

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

                    else if (commandWords[0] == "Unlock")
                    {
                        Console.WriteLine("What would you like to unlock that WITH? ");
                        Console.WriteLine();
                    }
                    else if (commandWords[0] == "Get")
                    {
                        Console.WriteLine("What ITEM would you like to get? ");
                        Console.WriteLine();
                    }
                    else if (commandWords[0] == "Drop")
                    {
                        Console.WriteLine("What ITEM would you like to drop? ");
                        Console.WriteLine();
                    }
                    else if (commandWords[0] == "READ")
                    {
                        Console.WriteLine("What would you like to read? ");
                        Console.WriteLine();
                    }


                }
            } while (command != "Q");
            Console.ReadKey();
        }

        private static int EnterAnInt()
        {
            int inputInt = 0;
            bool True = false;
            do
            {
                try
                {
                    
                    inputInt = Int32.Parse(Console.ReadLine());
                    if(inputInt == 1 || inputInt == 2 || inputInt == 3 || inputInt == 4 || inputInt == 5)
                    {
                        True = true;
                    }
                    

                }
                catch
                {
                    
                    if(inputInt < 1 || inputInt > 5)
                    {
                        Console.WriteLine("Not a character number");
                        True = false;
                    }
                    else
                    {
                        Console.WriteLine("That is not a whole number");
                        True = false;
                    }   
                }
            } while (!True);
            return inputInt;
        }
       
    }
}
