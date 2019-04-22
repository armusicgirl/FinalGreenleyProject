using System;

namespace Quest_of_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomClass[] rooms = new RoomClass[335]; // N, E, S, W, U, D

            rooms[1] = new RoomClass(2,0,0,0,0,0,"Forest: ", "Welcome, I've heard you are looking for the Golden Blizing. After years of reasearch, it looks like you were sucessful in finding the temple, but no one knows what lies inside. Becareful, and make sure to prove to all those who dobted you that you were right about this.");
            rooms[2] = new RoomClass(5, 3, 1, 4, 0, 0, "Entrance: ", "The room is lit up by tourches. This isn't so bad, Lets go get the Golden Blizing");
            rooms[3] = new RoomClass(6, 2, 0, 5, 0, 0, "Room of Gold: ", "Looks like a treasure room. ");
            rooms[4] = new RoomClass(7, 5, 0, 2, 0, 0, "Treasure Hall: ", "Looks like a room that could be filled with lots of gold. ");
            rooms[5] = new RoomClass(9, 3, 2, 4, 0, 0, "Oberon's Room: ", "A little cozy room, three walls full of books. In the corner is a chair with a little stone statue that looks like it could be reading. Wouldn't it be nice if you could speak to such a wise looking statue.");
            rooms[6] = new RoomClass(0, 0, 3, 0, 0, 0, "First Understanding: ", " ");
            rooms[7] = new RoomClass(0, 0, 4, 8, 0, 0, "Second Knowing: ", "");
            rooms[8] = new RoomClass(110, 7, 0, 0, 0, 0, "Art Gallary", "So many paintings along the walls, There is a circle of statues in the middle of the room curounding a fountain");
            rooms[9] = new RoomClass(11, 12, 5, 10, 0, 0, " First Battle: ", "There is a beast in the middle of the room...");
            rooms[10] = new RoomClass(11,9,41,8, 0, 0, "Dining room: ", "A long wooden table with acient food spread on it, almost looks fresh enough to eat.");
            rooms[11] = new RoomClass(14, 12, 9, 10, 0, 0, "Kitchen: ", "A clay oven, Stone Cook tops, knives, and a garden still growing where sun shines in from the celieng.");
            rooms[12] = new RoomClass(11, 13, 0, 9, 0, 0, "Music Room:", "String, wind, and percussion instruments are skattered around the room");
            rooms[13] = new RoomClass(0, 0, 0, 12, 0, 0, "Third Learning: ", "");
            rooms[14] = new RoomClass(18, 17, 11, 15, 0, 0, "Treasure treasure", "Lots of round dusty objects are skattered on the floor.");
            rooms[15] = new RoomClass(0, 14, 0, 16,0,0, "Throne Room: ", " Golden thrones are at the top of a tower of stairs looking down onto a great wide floor.");
            rooms[16] = new RoomClass(19, 15, 0, 0, 0, 0, "Snake Trap: ", "A pit of snakes, they take all your money.");
            rooms[17] = new RoomClass(0, 18, 40, 14, 0, 0, ";~)  ", "Hint hint, if you look for it");
            rooms[18] = new RoomClass(21, 17, 14, 20, 0, 0, "Break Room", "What is it you need? Chances are we got it here.");
            rooms[19] = new RoomClass(24, 0, 16, 0, 0, 0, "Bed Room", "A huge room with a bed that looks fun to jump on.");
           // rooms[20] = new RoomClass()

        }
    }
}
