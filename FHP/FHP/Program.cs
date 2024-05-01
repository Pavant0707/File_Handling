using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHP
{
    class Program { 
    
        
        static void Main(string[] args)
        {
           // String path123= @"C:\FileProg\ram.txt";
            //File.Create(path123);
            //String path124 = @"C:\FileProg\sai.txt";
           // File.Move(path123,path124);
            //Console.WriteLine("d");
            //Console.WriteLine("A file created with name");
            //File.WriteAllText(path123, "jai sri rama\n jai sri ram");
            //string strings = File.ReadAllText(path123);
            //Console.WriteLine(strings);
            //try
            //{
            //    using (StreamReader reader = new StreamReader(path123))
            //    {
            //        int count = 0;
            //        while (reader.ReadLine() != null)
            //        {
                        
            //            count++;
            //        }
            //        Console.WriteLine(count);
            //    }
            //}catch (Exception ex)
            //{
                
            //}

            String[] s = { "A", "b", "C", "D" };
            String filePath = @"C:\FileProg\array.txt";
            try
            {
                using (StreamWriter stream = new StreamWriter(filePath))
                {
                    foreach (string line in s)
                    {
                        stream.WriteLine(line);
                           
                    }
                }
                Console.WriteLine("Array of string entered in file");

                StreamReader streamReader = new StreamReader(filePath);
                String contenct=streamReader.ReadToEnd();
                Console.WriteLine(contenct[s.Length-1]);           

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}
