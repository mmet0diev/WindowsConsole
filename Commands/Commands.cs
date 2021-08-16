using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CommandLibrary
{
    public class Commands
    {
        public static string pwd()
        {
            return Directory.GetCurrentDirectory();
        }
        public static string ls()
        {
            string result = "";
            var files = Directory.GetFiles(Directory.GetCurrentDirectory());
            var dirs = Directory.GetDirectories(Directory.GetCurrentDirectory());

            foreach (string dir in dirs)
            {
                result += "\n" + dir;
            }
            foreach (string file in files)
            {
                result += "\n" +file;
            }
            return result;
        }
        public static void mkdir(string newFolder)
        {
            var currDir = Directory.GetCurrentDirectory();
            Directory.CreateDirectory(currDir + "\\" + newFolder);
        }
        public static void rmdir(string Folder)
        {
            if (Directory.Exists(Folder))
            {
                Directory.Delete(Folder);
            }
        }
        public static void cd(string newDir)
        {
            if (newDir.Equals(".."))
            {
                string parentDir = Directory.GetParent(newDir)+"";
                Directory.SetCurrentDirectory(parentDir);
            }
            else
            {
                if (Directory.Exists(newDir))
                {
                    Directory.SetCurrentDirectory(newDir);
                }
            }
        }
    }
}
