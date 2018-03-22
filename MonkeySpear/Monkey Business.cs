using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeySpear
{
    public partial class Form1 : Form
    {
        
        public string print;
        static Random _random = new Random();
        public static string output = "";

        public Form1()
        {
            InitializeComponent();
            MonkeyBusinessUI.Library.words.Add("a");
            MonkeyBusinessUI.Library.words.Add("as");
            MonkeyBusinessUI.Library.words.Add("arse");

        }

        

        private void start_btn_Click(object sender, EventArgs e)
        {
          
            for (int i=0; i < 60 ; i++)
            {
                
              eventH(sender, e);
              

            }
                

                
            
          

        }

        private void eventH(object sender, EventArgs e)
        {
            print = Randomizer();
            OutputLabel.Text += "\n";
           
            foreach (char a in print)
            {
                OutputLabel.Text += a;
                
                OutputLabel.Refresh();
                
            }

            output = "";
        }

        protected void Print(string random)
        {
            foreach(char a in print)
            {
                OutputLabel.Text += a;
                OutputLabel.Refresh();
                DoEvents();
            }
        }

        public static void DoEvents()
        {
            Application.DoEvents();
        }

        public static char GetLetter()
        {
            int number = _random.Next(0, 26);
            char letter = (char)('a' + number);
            return letter;
        }

        public string Randomizer()
        {
            
            while (output.Length < 100)
            {
                output += GetLetter();
                DoEvents();
            }
            return output;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = String.Empty;
        }
    }
}
