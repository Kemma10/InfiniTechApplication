using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InfiniTechApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to create a new note and discard the current one?",
                    "Confirm New Note",
                    MessageBoxButtons.YesNo
                );              
                if (result == DialogResult.Yes) // If yes, clear the richtextbox
                {
                    richTextBox1.Clear();
                }
                // If the user clicks 'No', do nothing
            }
            else
            {                
                richTextBox1.Clear(); // If richtextbox is empty, just clear it
            }
        }

        private void openStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // Create Open file dialog instance
            openFileDialog.ShowDialog(); // Show the dialog
        }

        private void saveStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); // Create Save file dialog instance
            saveFileDialog.ShowDialog(); // Show the dialog
        }

        private void saveAsCtrlShiftSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); // Create Save file dialog instance
            saveFileDialog.ShowDialog(); // Show the dialog
        }

        private void printStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog(); //Creates print dialog instance
            printDialog.ShowDialog(); // Show the dialog
        }

        private void exitStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Closes application
        }
    }
}
