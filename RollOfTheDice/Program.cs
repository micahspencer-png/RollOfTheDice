namespace RollOfTheDice
{
    //Micah Spencer
    //RCET2265
    //Fall 25
    //Roll of the Dice Program
    //https://github.com/micahspencer-png/RollOfTheDice.git

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Roll();
            Display();

            
            Console.Read();
        }
        private static int[] dice = new int[11];
        static void Roll()
        {

            Random Dice1 = new Random();
            Random Dice2 = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int roll1 = Dice1.Next(1,7);
                int roll2 = Dice2.Next(1,7);
                int total = roll1 + roll2;
                
                switch (total)
                {
                    case 2:
                        dice[0]++;
                        break;

                    case 3:
                        dice[1]++; 
                        break;

                    case 4:
                        dice[2]++;
                        break;

                    case 5:
                        dice[3]++;
                        break;

                    case 6:
                        dice[4]++;
                        break;

                    case 7:
                        dice[5]++;
                        break;

                    case 8:
                        dice[6]++;
                        break;

                    case 9:
                        dice[7]++;
                        break;

                    case 10:
                        dice[8]++;
                        break;

                    case 11:
                        dice[9]++;
                        break;

                    case 12:
                        dice[10]++;
                        break;

                    default:
                        Console.WriteLine("out of bounds");
                        break;

                }
            }
        }

        static void Display() 
        {
            string[] header = {"2","3","4","5","6","7","8","9","10","11","12" };
            string vDivide = "|";
            int pad = 3;
            int totalWidth = 12 * (pad + vDivide.Length);
            string hDivide = new string('-',totalWidth);
            Console.WriteLine("Roll of the Dice");
            Console.WriteLine(hDivide);
            foreach (string letter in header)
            {
                Console.Write(letter.PadLeft(pad) + vDivide);
            }
            Console.WriteLine();
            Console.WriteLine(hDivide);

            foreach(int count in dice)
            {
                Console.Write($" {count}{vDivide}");
            }
            Console.WriteLine();
            Console.WriteLine(hDivide);

        }

    }
}
