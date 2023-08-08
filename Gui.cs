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
        HexConverter hc = new HexConverter();

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
                Console.WriteLine("2. SHA");
                Console.WriteLine("1. HMAC");
                Console.WriteLine("4. Exit");
                Console.Write("\r\nPress a number.");

                // Switch case for each menu point
                switch (Console.ReadKey(true).KeyChar)
                {
                    // Calls a method to show the menu for MD5
                    case '1':
                        CreateMd5Menu();
                        break;
                    // Calls a method to show the menu for SHA
                    case '2':
                        CreateShaMenu();
                        break;
                    // Calls a method to show the menu for HMAC
                    case '3':
                        CreateHmacMenu();
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

        private void CreateMd5Menu()
        {
            // Bool to control the menu
            bool menu = true;

            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("               MD5 hashing algorithm");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("Enter text to use with MD5, press enter twice to save input. \n");

            while (menu)
            {
                string input = Console.ReadLine();

                if (Console.ReadKey(true).Key.ToString() == "Enter")
                {
                    ShowMd5AndHex(input);
                }
                else if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    StartMenu();
                }
            }
        }

        private void CreateShaMenu()
        {
            // Bool to control the menu
            bool menu = true;

            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("               SHA hashing algorithm");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("Enter text to use with SHA, press enter twice to save input. \n");

            while (menu)
            {
                string input = Console.ReadLine();

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    ShowShaAndHex(input);
                }
                else if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    StartMenu();
                }
            }
        }

        private void CreateHmacMenu()
        {
            bool menu = true;

            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("               HMAC hashing algorithm");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("Write text, if text is atleast 2 characters go to next step by pressing enter twice: \n");

            while (menu)
            {
                string input = Console.ReadLine();

                if (Console.ReadKey().Key == ConsoleKey.Enter && input.Length > 1)
                {
                    bool keyMenu = true;

                    Console.WriteLine("Write key, if key is atleast 2 characters go to next step by pressing enter twice: \n");

                    while (keyMenu)
                    {
                        string key = Console.ReadLine();

                        if (Console.ReadKey().Key == ConsoleKey.Enter && key.Length > 1)
                        {
                            ShowHmac(input, key);
                        }
                    }
                }
            }
        }

        private void ShowMd5AndHex(string input)
        {
            bool menu = true;

            Console.WriteLine("MD5: " + hm.GetHash(input, "MD5"));
            Console.WriteLine("MD5 in hex: " + hc.GetHexFromString(input));
            Console.WriteLine("\n Press escape to go back.");

            while (menu)
            {
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    StartMenu();
                }
            }
        }

        private void ShowShaAndHex(string input)
        {
            bool menu = true;

            Console.WriteLine("Input: " + input);
            Console.WriteLine("SHA: " + hm.GetHash(input, "SHA"));
            Console.WriteLine("SHA in hex: " + hc.GetHexFromString(input));
            Console.WriteLine("\n Press escape to go back.");

            while (menu)
            {
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    StartMenu();
                }
            }
        }

        private void ShowHmac(string input, string key)
        {
            bool menu = true;

            Console.WriteLine("Input: " + input);
            Console.WriteLine("Key: " + key);
            Console.WriteLine("HMAC: " + hm.GetHash(input, "", key));
            Console.WriteLine("\n Press escape to go back.");

            while (menu)
            {
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    StartMenu();
                }
            }
        }

        private void ExitApplication()
        {
            Environment.Exit(0);
        }
    }
}
