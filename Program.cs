﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Media;
using System.Diagnostics;
using RedMax_Operating_System.Properties;

namespace RedMax_Operating_System
{
    class Program
    {
        #region Main + ReadMe
        static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("RedMax Operating System");
            Console.WriteLine("Please Wait...");
            Thread.Sleep(5000);
            UserInterface();
        }
        static void readme_txt()
        {
            Console.Clear();
            Console.WriteLine("╔═════════════════════════README.txt═════════════════════════[X]══╗");
            Console.WriteLine("║ RedMax Documentation - README.txt                               ║");
            Console.WriteLine("║ -----------------------------------                             ║");
            Console.WriteLine("║ The RedMax Console Operating System is Open Source Software     ║");
            Console.WriteLine("║ Written and Compiled in Microsoft Visual Studio 2019 Community  ║");
            Console.WriteLine("║ Uploaded to GitHub : @sudo-apt-get-urmom                        ║");
            Console.WriteLine("║ Original URL :                                                  ║");
            Console.WriteLine("║ https://github.com/sudo-apt-get-urmom/redmax                    ║");
            Console.WriteLine("╚══Read-Only File════════QView Text Editor════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the desktop");
            Console.ReadKey();
            desktop();
        }
        #endregion
        #region UPS Detection
        static void UserInterface()
        {
            Console.OpenStandardInput();
            Console.Clear();
            Console.ResetColor();
            if (Settings.Default.UserType == 5)
            {
                Console.WriteLine();
                Console.WriteLine("╔═════════════════════User Profile Service═════════════════════╗");
                Console.WriteLine("║     You are currently logged on with a temporary profile.    ║");
                Console.WriteLine("║        Press any key to continue to the RedMax Desktop       ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                Console.WriteLine();
                Console.ReadKey();
                desktop();
            }
            if (Settings.Default.UserType == 4)
            {
                Console.WriteLine();
                Console.WriteLine("╔═════════════════════User Profile Service═════════════════════╗");
                Console.WriteLine("║        You are currently logged on with a Guest profile.     ║");
                Console.WriteLine("║        Press any key to continue to the RedMax Desktop       ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                Console.WriteLine();
                Console.ReadKey();
                desktop();
            }
            else
            {
                desktop();
            }
        }
        #endregion
        #region RM UD
        static void desktop()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ [RedMax] [File] [Settings] [QuickFind]                    [Feedback] [Spotlight] ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("  ╔═════╗");
            Console.WriteLine("  ║ TXT ║");
            Console.WriteLine("  ╚═════╝");
            Console.WriteLine(" ReadMe.txt");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("╔══════════════════════════╗");
            Console.WriteLine("║ [GView] [Feedback]       ║");
            Console.WriteLine("╚══════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("Enter a command");
            string command = Console.ReadLine();
            if (command=="$open 'readme.txt'")
            {
                readme_txt();
            }
            if (command=="$.help")
            {
                redhelp();
            }
            if (command == "$.shutdown")
            {
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Unknown Command");
                Console.WriteLine();
                Thread.Sleep(2000);
                desktop();
            }
        }
        #endregion
        #region RM HU
        static void redhelp()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("RedMax Help Utility");
            Console.ResetColor();
            Console.WriteLine("$open 'filename'  -  Opens a file / application");
            Console.WriteLine("$.help  -  Displays the RedMax Help Utility");
            Console.WriteLine("$.credits  -  Displays the RedMax Credits");
            Console.WriteLine("$.shutdown  -  Closes the RedMax Application");
            Console.WriteLine();
            Console.WriteLine("Press Any Key to return to the Desktop");
            Console.ReadKey();
            desktop();
        }
        #endregion
    }
}