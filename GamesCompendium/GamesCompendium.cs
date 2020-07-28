using Speed_Typing_Test___Form_Template;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesCompendium
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void typingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Speed_Typing_Test___Form_Template.TypingTestForm Tt = new Speed_Typing_Test___Form_Template.TypingTestForm();
            Tt.ShowDialog();

        }

        private void memoryGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Memory_Game.MemoryGameForm Mg = new Memory_Game.MemoryGameForm();
            Mg.ShowDialog();
        }

        private void anagramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anagrams.AnagramsForm A = new Anagrams.AnagramsForm();
            A.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
