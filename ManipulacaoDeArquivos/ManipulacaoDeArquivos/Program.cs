using System;
using System.IO;

namespace ManipulacaoDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\duduh\file1.txt";
            string targetPath = @"C:\Users\duduh\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
