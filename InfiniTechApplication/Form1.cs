using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                    "You sure you want to create a new note and discard the current one?",
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

        // private void closes application
        private void exitStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Closes application
        }

        private void Menu_Cut(System.Object sender, System.EventArgs e)
        {
            // Ensure that text is currently selected in the text box.   
            if (richTextBox1.SelectedText != "")
                // Cut the selected text in the control and paste it into the Clipboard.
                richTextBox1.Cut();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_Cut(sender, e);
        }

        private void Menu_Copy(System.Object sender, System.EventArgs e)
        {
            // Ensure that text is selected in the text box.   
            if (richTextBox1.SelectionLength > 0)
                // Copy the selected text to the Clipboard.
                richTextBox1.Copy();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_Copy(sender, e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_Undo(sender, e);
        }

        private void Menu_Undo(System.Object sender, System.EventArgs e)
        {

            // Determine if last operation can be undone in text box.   
            if (richTextBox1.CanUndo == true)
            {
                // Undo the last operation.
                richTextBox1.Undo();

            }
        }

        // Method to handle redo operation
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Determines if a Redo operation can be performed.
            if (richTextBox1.CanRedo == true)
            {
                    // Perform the redo.
                    richTextBox1.Redo();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste(); // Paste clipboard content into the RichTextBox
        }
    }
}
//finished commit