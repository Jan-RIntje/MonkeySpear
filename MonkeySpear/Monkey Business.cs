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
        static Random _random = new Random();
        public static string output = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            string print = MonkeyBusinessUI.Randomizer();
            OutputLabel.Text = print;
            output = "";
        }



        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
