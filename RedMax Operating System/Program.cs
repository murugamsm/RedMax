using System;
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
        #region Spotlight
        static void spotlight()
        {
            Console.Clear();
            Console.WriteLine("╔═════════════ RedMax Spotlight Notification Center ═════════════╗");
            Console.WriteLine("║   29th April 2019 - Build 0.01a Uploaded to GitHub Repository  ║");
            Console.WriteLine("║            https://www.github.com/indigoajax/redmax            ║");
            Console.WriteLine("╚════════ RedMax Shell Generation I ═════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to desktop");
            Console.ReadKey();
            desktop();
        }
        #endregion
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
            Console.WriteLine("║ Uploaded to GitHub : @indigoajax                                ║");
            Console.WriteLine("║ Original URL :                                                  ║");
            Console.WriteLine("║ https://github.com/indigoajax/redmax                            ║");
            Console.WriteLine("║ Twitter : @redmax_project                                       ║");
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
            Console.WriteLine("╔═════════════════════════ RedMax Shell Generation I ══════════════════════════════╗");
            Console.WriteLine("║ [RedMax] [File] [Preferences]                                        [Spotlight] ║");
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
            Console.WriteLine("╔══Quick Launch Bar═════════════╗");
            Console.WriteLine("║ [GView] [Menu]                ║");
            Console.WriteLine("╚═══════════════════════════════╝");
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
            if (command == "$.spotlight")
            {
                spotlight();
            }
            if (command=="$.quick .menu")
            {
                RedMaxMenu();
            }
            if (command == "$.preferences")
            {
                preferences();
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
            Console.WriteLine("╔══════════════════RedMax Help Utility══════════════════╗");
            Console.WriteLine("║ RedMax Help Utility                                   ║");
            Console.WriteLine("║ $open 'filename'  -  Opens a file / application       ║");
            Console.WriteLine("║ $.help  -  Displays the RedMax Help Utility           ║");
            Console.WriteLine("║ $.credits  -  Displays the RedMax Credits             ║");
            Console.WriteLine("║ $.shutdown  -  Closes the RedMax Application          ║");
            Console.WriteLine("╚═══ RedMax Shell Generation I ═════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("Press Any Key to return to the Desktop");
            Console.ReadKey();
            desktop();
        }
        #endregion
        #region System Preferences
        static void preferences()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════ System Preferences ═══════════════[?]══╗");
            Console.WriteLine("║ 'User Settings'   'UPS Service'  'RedMax General Options'  ║");
            Console.WriteLine("║ 'Build Information'                                        ║");
            Console.WriteLine("╚════════ RedMax Shell Generation I ═════════════════════════╝");
            Console.WriteLine();
            string sub = Console.ReadLine();
            if (sub=="User Settings")
            {
                settings_user();
            }
            if (sub=="UPS Service")
            {
                ups_service_settings();
            }
            if (sub=="RedMax General Options")
            {
                redmax_general();
            }
            if (sub=="Build Information")
            {
                redmax_build();
            }
            else
            {
                Console.WriteLine("This setting could not be found");
                Thread.Sleep(2000);
                preferences();
            }
        }
        static void settings_user()
        {

        }
        static void ups_service_settings()
        {

        }
        static void redmax_general()
        {

        }
        static void redmax_build()
        {
			Console.Clear();
			Console.WriteLine("╔═══════════════════ RedMax Build Info ═══════════════════╗");
			Console.WriteLine("║              RedMax Release Build is 0.01a              ║");
			Console.WriteLine("║        You are currently using RedMax Build 0.01b       ║");
			Console.WriteLine("║ Original GitHub Repo : www.github.com/indigoajax/redmax ║");
			Console.WriteLine("║              This is open-source software               ║");
			Console.WriteLine("╚═════ RedMax Shell Generation I ═════════════════════════╝");
			Console.WriteLine();
			Console.WriteLine("Press any key to return to the Desktop");
			Console.ReadKey();
			desktop();
        }
        #endregion
        #region RedMax "Start Screen"
        static void RedMaxMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("RedMax Start Screen");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("╔═══════════════════ Utilities ═══════════════════╦");
            Console.WriteLine("║ 'Desktop'  'System Preferences'  'Build Info'   ║");
            Console.WriteLine("╚═════════════════════════════════════════════════╩");
            Console.WriteLine();
            Console.WriteLine();
            string option = Console.ReadLine();
            if (option=="Desktop")
            {
                desktop();
            }
            if (option == "System Preferences")
            {
                preferences();
            }
            if (option == "Build Info")
            {
                redmax_build();
            }
            else
            {
                Console.WriteLine("This is not available");
                Thread.Sleep(2000);
                RedMaxMenu();
            }
        }
        #endregion
    }
}
