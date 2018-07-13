using System;
using System.IO;
using System.Text;

namespace DocumentMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            String file1;
            String file2;
            String mergeFile;
            String contents = "";
            int answer;

            Console.WriteLine("Document Merger \n");

            do
            {
                
                Console.WriteLine("Please enter the name for the first text file:");
                file1 = Console.ReadLine();

                while (File.Exists(file1) == false)
                {
                    Console.WriteLine("File does not exists.");
                    Console.WriteLine("Please enter a new Document name: ");
                    file1 = Console.ReadLine();
                }

                Console.WriteLine("Please enter the name for the second text file:");
                file2 = Console.ReadLine();

                while (File.Exists(file2) == false)
                {
                    Console.WriteLine("File does not exists.");
                    Console.WriteLine("Please enter a new Document name: ");
                    file2 = Console.ReadLine();
                }

                mergeFile = file1 + file2 + ".txt";

                //   Console.WriteLine(mergeFile);



                String line = "";
                String line2 = "";

                try
                {
                    //Pass the file path and file name to the StreamReader constructor

                    StreamWriter sw = new StreamWriter(mergeFile);

                    // sw.Write(content);
                    sw.Close();

                    //Read the first line of text

                    StreamReader sr1 = new StreamReader(file1);
                    StreamReader sr2 = new StreamReader(file2);
                    line = sr1.ReadLine();
                    line = sr2.ReadLine();

                    //Continue to read until you reach end of file
                    while (line != null)
                    {
                        //write the lie to console window
                        //Console.WriteLine(content);
                        //Read the next line
                        sw.WriteLine(line);
                        contents += line;

                    }

                    while (line2 != null)
                    {
                        //write the lie to console window
                        //Console.WriteLine(content);
                        //Read the next line
                        sw.WriteLine(line2);
                        contents += line2;
                        // count++; //this will count the line
                    }

                    // Console.WriteLine(file + " was successfully saved. The document contains " + count + " characters." + file + " and " + count + " are placeholders for the filename of the document and the number of characters it contains");

                    //close the file
                    sr1.Close();
                    sr2.Close();
                    sw.Close();
                    // Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }

                Console.WriteLine("Would you like to merge two more files? (Enter 1  to merge two more files. Else, any button to exit.");
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer != 1)
                {
                    System.Environment.Exit(1);
                }


            } while (answer == 1);
        }
    }
}
