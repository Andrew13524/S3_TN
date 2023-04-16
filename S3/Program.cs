using System;

namespace S3
{
    class Tile
    {
        public int Value;

        public Tile()
        {
            Value = 0;
        }
        public Tile(int value)
        {
            Value = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Storing Multiple Tiles
            Tile[] tiles = new Tile[16];
            for (int i = 0; i < tiles.Length; i++)
            {
                tiles[i] = new Tile();
            }

            // Getting Random Tiles
            Random random = new Random();
            tiles[0].Value = 2;
            tiles[5].Value = 2;

            int result = random.Next(0, 16);
            tiles[result].Value = 2;

            result = random.Next(0, 16);
            tiles[result].Value = 2;

            foreach (Tile tile in tiles)
            {
                //Console.WriteLine(tile.Value);
            }

            // Methods

            //int num = 3;
            //int result = AddNum(num, num);

            //Console.WriteLine(result);

            // Classes/Constructors
            //Tile tile = new Tile(2);
            //Tile tile2 = new Tile();

            //int[] numbers = new int[16];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = 1;
            //}

            //foreach(int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

        }

        public static int AddNum(int a)
        {
            return a + 1;
        }
        public static int AddNum(int a, int b)
        {
            return a + b;
        }
    }
}
