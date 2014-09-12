using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
C# Programming Tips & Techniques
by Charles Wright, Kris Jamsa

Publisher: Osborne/McGraw-Hill (December 28, 2001)
ISBN: 0072193794
*/

namespace FilePatches
{
    /*
    public class ShowDir
    {
        static public void Main(string[] args)
        {
            string temp = null;
            string dir = @"D:\PW\pw_devtools\PW_DEV\PW-PCK\1.4.7\surfaces.pck.files\surfaces";
            // Build the directory name from the arguments (a directory name may
            // contain spaces).
            string DirName = "";
            /*foreach (string str in args)
            {
                DirName += str;
                DirName += " ";
            }
            DirName += dir;
            DirName += " ";
            // Strip any leading or trailing spaces from the directory name
            DirName = DirName.Trim();
            // Check whether the directory exists
            //                if (!Directory.Exists(DirName))
            //                {
            //                    Console.WriteLine ("No such directory: " + DirName);
            //                    return;
            //                }
            // Set the current working directory
            try
            {
                Directory.SetCurrentDirectory(DirName);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Not authorized to access " + DirName);
                return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No such directory: " + DirName);
                return;
            }
            // List the files in the selected directory
            string[] files = Directory.GetFiles(".");
            foreach (string str in files)
            {
                int index = str.LastIndexOf("\\");
                Console.WriteLine(str.Substring(index + 1));
            }
            temp = Console.ReadLine();
        }
    }*/
    /*
    class MainClass
    {
        public static void Main()
        {
            Char[] chars;
            Byte[] bytes = new Byte[] { 85, 0, 110, 0, 105, 0, 99, 0, 111, 0, 100, 0, 101, 0 };

            UnicodeEncoding Unicode = new UnicodeEncoding();

            int charCount = Unicode.GetCharCount(bytes, 2, 8);
            chars = new Char[charCount];
            int charsDecodedCount = Unicode.GetChars(bytes, 2, 8, chars, 0);

            Console.WriteLine(charsDecodedCount);

            foreach (Char c in chars)
            {
                Console.WriteLine("[{0}]", c);
            }
            Console.ReadLine();
        }
    }*/
    /*
    class MainClass
    {
        public static void Main()
        {
            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                // Create and write a string containing the symbol for pi. 
                string srcString = "Area = \u03A0r^2";
                output.WriteLine("Source Text : " + srcString);

                // Write the UTF-16 encoded bytes of the source string. 
                byte[] utf16String = Encoding.Unicode.GetBytes(srcString);
                output.WriteLine("UTF-16 Bytes: {0}",
                     BitConverter.ToString(utf16String));
                // Convert the UTF-16 encoded source string to UTF-8 and ASCII. 
                byte[] utf8String = Encoding.UTF8.GetBytes(srcString);
                byte[] asciiString = Encoding.ASCII.GetBytes(srcString);

                // Write the UTF-8 and ASCII encoded byte arrays. 
                output.WriteLine("UTF-8        Bytes: {0}",
                     BitConverter.ToString(utf8String));
                output.WriteLine("ASCII        Bytes: {0}",
                     BitConverter.ToString(asciiString));

                // Convert UTF-8 and ASCII encoded bytes back to UTF-16 encoded 
                // string and write. 
                output.WriteLine("UTF-8        Text : {0}",
                     Encoding.UTF8.GetString(utf8String));
                output.WriteLine("ASCII        Text : {0}",
                     Encoding.ASCII.GetString(asciiString));
            }
            Console.ReadLine();

        }
    }*/
    
}