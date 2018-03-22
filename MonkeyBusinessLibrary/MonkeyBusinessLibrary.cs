using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MonkeyBusinessLibrary
{
    public class MonkeyBusinessLibrary
    {

        public void GetWords(List<string> words, string path)
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
