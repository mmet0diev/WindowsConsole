using System;
using CommandLibrary;

namespace MMConsole
{
    class Program 
    {
        static string input;
        static void Main(string[] args)
        {
            GetOutput();
        }

        private static void GetOutput()
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
            if (input.Equals("help"))
            {

            }
        }
    }
}
