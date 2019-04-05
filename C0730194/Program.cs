using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730194
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();

        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
            // Read file using StramReader. Read file line by line
            using (StreamReader file = new StreamReader("U:/Users/730194/C0730194-Assignment4/C0730194Beowulf.txt"))
            {
                int counter = 0;
                string ln;
       

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);

                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {

            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }

                if (char.IsWhiteSpace(c))
                {
                    countletters++;
                }
            }
            return countSpaces;

        }
    }
}