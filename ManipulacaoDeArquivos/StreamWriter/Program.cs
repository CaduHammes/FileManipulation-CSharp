using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamWritePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string soucePath = @"C:\Users\duduh\file1.txt";
            string targetPath = @"C:\Users\duduh\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(soucePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
