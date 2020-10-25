using System;
using System.Collections;

namespace LabA
{
    class Program
    {
        private readonly static FileOuput outFile = new FileOuput("animals.txt");
        private readonly static FileInput inFile = new FileInput("animals.txt");
        static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();

            GatherInput inputGatherer = new GatherInput(zoo);

            inputGatherer.GetUserInput();

            foreach (ITalkable thing in zoo)
            {
                Printout(thing);
            }

            outFile.FileClose();
            inFile.FileRead();
            inFile.FileClose();

            FileInput indata = new FileInput("animals.txt");
            string line;
            while ((line = indata.FileReadLine()) != null) 
            {
                Console.WriteLine(line);
            }
        }

        public static void Printout(ITalkable p)
        {
            Console.WriteLine($"{p.GetName()} says= {p.Talk()}");
            outFile.FileWrite($"{p.GetName()} | {p.Talk()}");
        }
    }
}
