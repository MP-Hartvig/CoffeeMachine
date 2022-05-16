using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Main_GUI_Manager
{
    public class GUI
    {
        Manager mana = new Manager();
        bool spacebarTerminator = false;

        public void StartMenu()
        {
            // Bool to control the menu
            bool startMenu = true;

            while (startMenu)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("               Coffee Machine");
                Console.WriteLine("==================================================\n");
                Console.WriteLine("1. Brew coffee");
                Console.WriteLine("2. (NOT WORKING)");
                Console.WriteLine("3. (NOT WORKING)");
                Console.WriteLine("4. (NOT WORKING)");
                Console.WriteLine("5. Exit");
                Console.Write("\r\nEnter a number: ");


                // Switch case for each menu point
                switch (Console.ReadKey(true).KeyChar)
                {
                    // Creates a journal
                    case '1':
                        BrewCoffeeMenu();
                        break;
                    //case '2':
                    //    Console.WriteLine("==================================================\n");

                    //    break;
                    //case '3':
                    //    Console.WriteLine("==================================================\n");

                    //    break;
                    //case '4':
                    //    Console.WriteLine("==================================================\n");

                    //    break;
                    // Exits the program
                    case '5':
                        ExitApplication();
                        break;
                    default:
                        break;
                }
            }
        }

        private void BrewCoffeeMenu()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("               Coffee Machine");
            Console.WriteLine("==================================================\n");

            Console.Write("Enter water amount (Between 200ml to 2000ml): ");
            int waterAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter bean amount (Between 50g to 300g): ");
            int beanAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter amount of degrees (Between 80 degrees to 100 degrees): ");
            int degrees = Convert.ToInt32(Console.ReadLine());

            mana.InitializeMachine(waterAmount, beanAmount, degrees);
            Console.WriteLine("\nCoffee is now being brewed.");

            Console.WriteLine("\nPress spacebar to return to main menu.");

            while (spacebarTerminator == false)
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    spacebarTerminator = true;
                }
            }
        }

        private void ExitApplication()
        {
            Environment.Exit(0);
        }
    }
}
