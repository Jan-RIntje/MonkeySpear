using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeySpear
{
    public static class MonkeyBusinessUI
    {
        static Random _random = new Random();

        public static char GetLetter()
        {
            int number = _random.Next(0, 26);
            char letter = (char)('a' + number);
            return letter;
        }

        public static string Randomizer()
        {
            while (Form1.output.Length < 100)
            {
                Form1.output = Form1.output + GetLetter();
            }
            return Form1.output;

        }
    }
}
