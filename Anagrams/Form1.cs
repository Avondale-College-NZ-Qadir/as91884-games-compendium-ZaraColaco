using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anagrams
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)
            {

            }

        private void BTstart_Click(object sender, EventArgs e)
            {
            BTstart.Visible = false;
            TBLetters.Text = "N     A     R     S     E     W";

            }
        }
    }
