using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeHash
{
    internal class Gui
    {
        HashManager hm = new HashManager();

        bool spacebarTerminator = false;

        public void StartMenu()
        {
            // Bool to control the menu
            bool startMenu = true;

            while (startMenu)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("               Choose hashing algorithm");
                Console.WriteLine("==================================================\n");
                Console.WriteLine("1. MD5");
                Console.WriteLine("2. SHA2");
                Console.WriteLine("1. HMAC (In progress)");
                Console.WriteLine("4. Exit");
                Console.Write("\r\nPress a number.");


                // Switch case for each menu point
                switch (Console.ReadKey(true).KeyChar)
                {
                    // Creates a journal
                    case '1':
                        ComputeMd5Hash();
                        break;
                    case '2':
                        ComputeShaHash();
                        break;
                    case '3':
                        ComputeHmacHash();
                        break;
                    // Exits the program
                    case '4':
                        ExitApplication();
                        break;
                    default:
                        break;
                }
            }
        }

        private void ComputeMd5Hash()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("               MD5 hashing algorithm");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("Enter text to use with MD5, press enter to save input. \n");

            string temp = Console.ReadLine();


        }

        private void ComputeShaHash()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("               SHA hashing algorithm");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("Enter text to use with SHA, press enter to save input. \n");

            string temp = Console.ReadLine();


        }

        private void ComputeHmacHash()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("               HMAC hashing algorithm");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("Enter text to use with HMAC, press enter to save input. \n");

            string temp = Console.ReadLine();

            //if ()
            //{
                
            //}
        }

        private void ShowMd5HashAndHex()
        {

        }

        private void ShowShaHashAndHex()
        {

        }

        private void ShowHmacHashAndHex()
        {

        }

        private void ExitApplication()
        {
            Environment.Exit(0);
        }
    }
}
