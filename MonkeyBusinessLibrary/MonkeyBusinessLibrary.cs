using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MonkeyBusinessLibrary
{
    public class MonkeyLibrary
    {
        public List<string> words = new List<string>();
        public List<string> wordsFound = new List<string>();

        public void GetWords(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string[] filelines = File.ReadAllLines(path);

                foreach (var line in filelines)
                {
                    words.Add(line);
                }
            }
           
        }
    }
}
