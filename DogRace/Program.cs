using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternatief
{
    class Program
    {
        public static string answer;
        public static string pickeddog;

        static void Main()
        {

            Start();

            Console.WriteLine("there are four dogs that participate.");

            do
            {
                Console.Write("Witch one would you like to pick :   ");
                pickeddog = Console.ReadLine();
                Console.Clear();
            } while (pickeddog != "1" && pickeddog != "2" && pickeddog != "3" && pickeddog != "4");


            Console.WriteLine("You Picked dog number {0} . Good luck.", pickeddog);

            Console.WriteLine("The Dog with the highest running score wins.");

            Dog[] dogs = RunDogs();


            //Even toch in een method gezet voor overzichtelijkheid
            dogs = BubbleSort(dogs);


            Console.WriteLine("The dog who has won is = " + (dogs[0]).Number);

            ShowWinOrLose(dogs);

            Restart();



        }

        private static void Restart()
        {
            Console.WriteLine("Press Enter to Restart or another key to exit");
            string restartInput = Console.ReadKey().Key.ToString();
            if (restartInput == "Enter")
            {
                Console.Clear();
                Init();
                Main();
            }

        }

        private static void Init()
        {
            answer = null;
            pickeddog = null;
        }


        private static void ShowWinOrLose(Dog[] dogs)
        {
            if (Convert.ToInt32(pickeddog) == dogs[0].Number)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You Winnnnn !!!!! :D :D");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You lose :(");
                Console.ResetColor();
            }
        }

        private static Dog[] RunDogs()
        {
            Dog[] dogs = new Dog[4];
            Random random = new Random();

            for (int i = 0; i < dogs.Length; i++)
            {
                int randomNumber = random.Next(4, 100);
                dogs[i] = new Dog();
                dogs[i].Number = i + 1;
                dogs[i].Score = randomNumber;
                Console.Write("Dog number {0}= {1}", dogs[i].Number, dogs[i].Score);
                //Console.ReadLine();
            }
            return dogs;
        }

        private static void Start()
        {
            do
            {
                Console.WriteLine("You are currently at the animal race tourney. Four special dogs are about to race against each other for the Race title!");
                Console.WriteLine("You just walked in and you are currently standing infront of the bar.");
                Console.WriteLine("Suddenly a desk clerk starts talking to you...");
                Console.WriteLine();


                Console.WriteLine("Hello sir! Would you like to place a bet on the next race?");
                Console.Write("Please type Yes or No if you would like to place a bet?  ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                Console.Clear();

            } while (answer != "YES" && answer != "NO");
            Console.Clear();

            if (answer == "NO")
            {
                Console.WriteLine("Thank you for visiting us. Have a great day!");
                Console.WriteLine("press Enter to Exit");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        private static Dog[] BubbleSort(Dog[] dogs)
        {
            Console.WriteLine("==========UnSorted Array Input===============");
            for (int i = 0; i < dogs.Length; i++)
            {
                Console.WriteLine(dogs[i].Number + ": " + dogs[i].Score);
            }

            for (int i = dogs.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (dogs[j].Score > dogs[j + 1].Score)
                    {
                        Dog highValue = dogs[j];

                        dogs[j] = dogs[j + 1];
                        dogs[j + 1] = highValue;
                    }
                }
            }

            //Na het sorten even van hoog naar laag zetten
            Array.Reverse(dogs);

            Console.WriteLine("==========Sorted Array Using BubbleSort===============");
            for (int i = 0; i < dogs.Length; i++)
            {
                Console.WriteLine(dogs[i].Number + ": " + dogs[i].Score);
            }
            return dogs;
        }
    }
}
