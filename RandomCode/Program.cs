using System;
using System.IO;
namespace RandomCode
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string filePath = @"C:\Users\opilane\Samples\quotes.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            Console.WriteLine(dataFromFile[0]);
            Random rnd = new Random();
            Console.WriteLine(dataFromFile[rnd.Next(dataFromFile.Length)]);



        }
    }
}
