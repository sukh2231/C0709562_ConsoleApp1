using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
namespace C0709562
{
 
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
        }
        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:/Users/709562/Beowulf.txt"))
            
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)

                {
                    Console.WriteLine(ln);
                    counter++;
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");

            }
        }
        public void ProcessArrayList()
        {
            foreach (var line in Beowulf)
            {
                if (ContainsWord(line.ToString().ToLower(), "sea") && ContainsWord(line.ToString().ToLower(), "fare"))
                {
                    Console.WriteLine("line number is: {0}, LineNumber");
                }
            }
        }
        public bool ContainsWord(string line, string word)
        {
            if (line.Contains(word) == true)
            {
                return true;
            }
            return false;
        }
        public int FindNumberOfBlankSapces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }

    }
}
