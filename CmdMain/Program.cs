using System;
using CommandLibrary;

namespace MMConsole
{
    class Program 
    {
        static string input;
        static void Main(string[] args)
        {
            InitMsg();
            GetOutput();
        }
        static void InitMsg()
        {
            Console.WriteLine("Linux/Unix Windows cmd version.\n");
        }
        static void GetOutput()
        {
            do
            {
                input = Console.ReadLine();
                var parts = input.Split(" ");
                switch (parts.Length)
                {
                    case 1:
                        switch (parts[0])
                        {
                            case "ls": Console.WriteLine(Commands.ls()); break;
                            case "pwd": Console.WriteLine(Commands.pwd()); break;
                            case "h": help();break;
                            case "help": help();break;
                        }
                        break;
                    case 2:
                        switch (parts[0])
                        {
                            case "mkdir": Commands.mkdir(parts[1]); break;
                            case "rmdir": Commands.rmdir(parts[1]); break;
                            case "cd": Commands.cd(parts[1]); break;
                        }
                        break;
                }
            } while (!input.Split(" ")[0].Equals("exit"));
        }
        static void help()
        {
                Console.WriteLine("     Command           Description");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("     help / h                Displays this menu.");
                Console.WriteLine("     cd [directory]      Changes the current direcotry to a specified one.");
                Console.WriteLine("     pwd                 Displays the current working direcotry.");
                Console.WriteLine("     mkdir [directory]   Creates a new Directory");
                Console.WriteLine("     rmdir [directory]   Removes the specified directory");
                Console.WriteLine("-------------------------------------------------------\n");
                Console.WriteLine("Notes:\n" +
                    "Directory = Folder\n" +
                    "This tool is still in early development, so bugs should be inveitablly found.");
        }
    }
}
