using System;

class Program
{

    public const int vertical = 4;
    public const int horizontal = 6;

    static void Main()
    {
        // Here is your empty program!
        Console.WriteLine("Hello world!");
    }

    class Grid
    {
        private char[,] CavernState = new char[NS + 1, WE + 1];

            public void Reset()
            {
                int Count1;
                int Count2;
                for (Count1 = 0; Count1 <= NS; Count1++)
                {
                    for (Count2 = 0; Count2 <= WE; Count2++)
                    {
                        CavernState[Count1, Count2] = ' ';
                    }
                }
            }

            public void Display(Boolean MonsterAwake)
            {
                int Count1;
                int Count2;
                for (Count1 = 0; Count1 <= NS; Count1++)
                {
                    Console.WriteLine(" ------------- ");
                    for (Count2 = 0; Count2 <= WE; Count2++)
                    {
                        if (CavernState[Count1, Count2] == ' ' || CavernState[Count1, Count2] == '*' || (CavernState[Count1, Count2] == 'M' && MonsterAwake))
                        {
                            Console.Write("|" + CavernState[Count1, Count2]);
                        }
                        else
                        {
                            Console.Write("| ");
                        }
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine(" ------------- ");
                Console.WriteLine();
            }

            public void PlaceItem(CellReference Position, char Item)
            {
                CavernState[Position.NoOfCellsSouth, Position.NoOfCellsEast] = Item;
            }

            public Boolean IsCellEmpty(CellReference Position)
            {
                if (CavernState[Position.NoOfCellsSouth, Position.NoOfCellsEast] == ' ')
                    return true;
                else
                    return false;
            }
    }

    class Ship
    {
        protected int posX;
        protected int posY;
        protected int health;

        

        public int GetHealth()
        {
            return health;
        }

        public void MoveX(int modifier)
        {
            posX+=modifier;
        }
    }

    class Enemy : Ship
    {
        public Enemy(int posX, int posY) {
            health = 100;
            this.posX = posX;
            this.posY = posY;
        }

        public void MoveY(int modifier)
        {
            posY+=modifier;
        }

    }

    class Player : Ship
    {
        public Player(int posX, int posY) {
            health = 100;
            this.posX = posX;
            this.posY = posY;
        }

    }
}