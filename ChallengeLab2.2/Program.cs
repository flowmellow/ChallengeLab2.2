/*
Write a program in C# Sharp to create and copy the file to another name and display the content. You may use any file names and any content that you like .Purpose is to use create and copy functionality along with read file.
Expected Output :
Here is the content of the file mytest.txt :
Hello and Welcome
It is the first content
of the text file mytest.txt

The file mytest.txt successfully copied to the name mynewtest.txt in the same directory.
Here is the content of the file mynewtest.txt :
Hello and Welcome
It is the first content
of the text file mytest.txt
*/

using System.IO;
using System.Xml.Linq;

namespace ChallengeLab2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateFile();
            CopyFile();
            ReadFile();
        }
        public static void CreateFile()
        {
            try
            {
                StreamWriter myCreateFile = new StreamWriter("C:\\MSSA\\mytest.txt");
                myCreateFile.WriteLine("Here is the content of the file mytest.txt :");
                myCreateFile.WriteLine("Hello and Welcome");
                myCreateFile.WriteLine("It is the first content");
                myCreateFile.WriteLine("of the text file mytest.txt");
                myCreateFile.WriteLine();
                myCreateFile.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine("*Exception: " + e.Message);
                
            }
            finally
            {
                Console.WriteLine("*Test file has been created and saved.");
                Console.WriteLine();
            }
        }

        public static void CopyFile()
        {
            string sourceFileName = @"C:\MSSA\mytest.txt";
            string destFileName = @"C:\MSSA\mynewtest.txt";
            
            try
            {
                File.Copy(sourceFileName, destFileName);

                using (StreamWriter copiedTxt = File.AppendText(destFileName)) 
                {
                    copiedTxt.WriteLine("The file mytest.txt successfully copied to the name mynewtest.txt in the same directory.");
                    copiedTxt.WriteLine("Here is the content of the file mynewtest.txt :");
                    copiedTxt.WriteLine("Hello and Welcome");
                    copiedTxt.WriteLine("It is the first content");
                    copiedTxt.WriteLine("of the text file mynewtest.txt");
                    copiedTxt.Close();
                } 
                
            }
            catch (Exception e)
            {

                Console.WriteLine("*Exception: " + e.Message);
                Console.WriteLine(); //File has been written so having a space looks better
            }
            finally
            {
                Console.WriteLine("*The file has sucessfully copied and appended.");
                Console.WriteLine();
            }          

        }

        public static void ReadFile()
        {
            string copyFile;
            try
            {
                StreamReader copiedTxtRead = new StreamReader("C:\\MSSA\\mynewtest.txt");
                copyFile = copiedTxtRead.ReadLine();

                while (copyFile != null)
                {
                    Console.WriteLine(copyFile);
                    copyFile = copiedTxtRead.ReadLine();
                }
                copiedTxtRead.Close();
                Console.WriteLine();
            }
            catch (Exception e)
            {

                Console.WriteLine("*Exception: " + e.Message); 
            }
            finally
            {
                Console.WriteLine("*Copied text file has been read.");               
            }

        }
    }
}
