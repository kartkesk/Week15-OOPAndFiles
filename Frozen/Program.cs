using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string gift;

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            //getters for SecretSanta

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }

        }
        static void Main(string[] args)
        {
            List<SecretSanta> mySecretSantas = new List<SecretSanta>();
            string[] secretsantasFromFile = GetDataFromFile();

            foreach (string line in secretsantasFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newSecretSanta = new SecretSanta(tempArray[0], tempArray[1]);
                mySecretSantas.Add(newSecretSanta);

            }

            foreach (SecretSanta secretSantaFromList in mySecretSantas)
            {
                Console.WriteLine($"{secretSantaFromList.Name} wants {secretSantaFromList.Gift}.");
            }

        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }


        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\Samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }


    }

}
