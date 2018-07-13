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
            String name1;
            String name2;
            String mergeFile;
            int answer;

            Console.WriteLine("Document Merger \n");

            do
            {
                
                Console.WriteLine("Please enter the name for the first text file:");
                name1 = Console.ReadLine();
                file1 = name1 + ".txt";

                while (File.Exists(file1) == false)
                {
                    Console.WriteLine("File does not exists.");
                    Console.WriteLine("Please enter a new Document name: ");
                    file1 = Console.ReadLine();
                }

                Console.WriteLine("Please enter the name for the second text file:");
                name2 = Console.ReadLine();
                file2 = name2 + ".txt";

                while (File.Exists(file2) == false)
                {
                    Console.WriteLine("File does not exists.");
                    Console.WriteLine("Please enter a new Document name: ");
                    file2 = Console.ReadLine();
                }

                mergeFile = name1 + name2 + ".txt";

                //   Console.WriteLine(mergeFile);



                String line = "";
                String line2 = "";
                String result = "";
                int count = 0;
                StreamReader sr1 = new StreamReader(file1);
                StreamReader sr2 = new StreamReader(file2);
                StreamWriter sw = new StreamWriter(mergeFile);
          

                try
                {
    

                    //Continue to read until you reach end of file
                    while ((line = sr1.ReadLine()) != null)
                       {
                        //write the lie to console window
                        //Console.WriteLine(content);
                        //Read the next line
                           count += line.Length;
                        result += line;
                       }

                    while ((line2 = sr2.ReadLine()) != null)
                    {
                        //write the lie to console window
                        //Console.WriteLine(content);
                        //Read the next line
                        count += line2.Length;
                        result += line2;
                    }
                    sw.WriteLine(result);

                    Console.WriteLine(mergeFile + " was successfully saved. The document contains " + count + " characters." + mergeFile + " and " + count + " are placeholders for the filename of the document and the number of characters it contains");

                 
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");

                    sr1.Close();
                    sr2.Close();
                    sw.Close();
                     
                }

                Console.WriteLine("Would you like to merge two more files? (Enter 1  to merge two more files. Else, enter any number to exit.");
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer != 1)
                {
                    System.Environment.Exit(1);
                }


            } while (answer == 1);
        }
    }
}
