using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class TextEditor : Form
    {
        // Fields of TextEditor partial class
        private UserList userList;
        private User user;

        // Constructor
        public TextEditor(UserList uL, User u)
        {
            InitializeComponent();
            userList = uL;
            user = u;

            //If user only has view permission disable RichTB editing
            if(u.UserType == "View")
            {
                RichTB.ReadOnly = true;
            }

            // Set username to label in text editor
            TTSLabel.Text += user.Username;
        }

        // Top menu strip start
        private void TMSNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void TMSOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void TMSSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void TMSSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        // TMSLogout_Click() - On click logout the current user and return to login form
        private void TMSLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login(userList);
            login.Show();
            this.Hide();
        }

        private void TMSCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void TMSCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void TMSPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void TMSAbout_Click(object sender, EventArgs e)
        {
            About();
        }
        // Top menu strip End

        // Top tool strip start
        private void TTSNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void TTSOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void TTSSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void TTSSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        
        // ^ XOR (exclusive OR)
        // out of two inputs, only one can be true for output to be true
        // Allows the FontStyle to toggle back to normal state

        // TTSBold_Click() - On click set font style to bold
        private void TTSBold_Click(object sender, EventArgs e)
        {
            RichTB.SelectionFont = new Font(RichTB.Font, FontStyle.Bold ^ RichTB.SelectionFont.Style);
        }

        // TTSItalic_Click() - On click set font style to italic
        private void TTSItalic_Click(object sender, EventArgs e)
        {
            RichTB.SelectionFont = new Font(RichTB.Font, FontStyle.Italic ^ RichTB.SelectionFont.Style);
        }

        // TTSUnderline_Click() - On click set font style to underline
        private void TTSUnderline_Click(object sender, EventArgs e)
        {
            RichTB.SelectionFont = new Font(RichTB.Font, FontStyle.Underline ^ RichTB.SelectionFont.Style);
        }

        // TTSFontSize_SelectedIndexChanged() - On selection change set font size to selected size
        private void TTSFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            RichTB.SelectionFont = new Font(RichTB.SelectionFont.FontFamily, Convert.ToInt32(TTSFontSize.SelectedItem), RichTB.SelectionFont.Style);
        }

        private void TTSHelp_Click(object sender, EventArgs e)
        {
            About();
        }
        // Top tool strip end

        // Left tool strip start
        private void LTSCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void LTSCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void LTSPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }
        // Left tool strip end

        // Reused Methods below

        // NewFile() - Opens a new file
        private void NewFile()
        {
            // if there are characters in RichTB ask user if save is necessary
            if(RichTB.Text != "")
            {
                // ask if user wants to save (yes, no, cancel)
                string caption = "Text Editor";
                string text = "There are unsaved changes, do you want to save?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(text, caption, buttons);
                // if yes save
                if (result == DialogResult.Yes)
                {
                    Save();
                }
                // if no open new
                else if (result == DialogResult.No)
                {
                    RichTB.Text = "";
                }
            }
            else
            {
                RichTB.Text = "";
            }
        }

        // Open() - Open an existing file
        private void Open()
        {
            // File dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTB.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
        // Save() - Save file as existing format
        private void Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "*.rtf";
            saveFileDialog.Filter = "RTF Files|*.rtf";

            if(saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                RichTB.SaveFile(saveFileDialog.FileName);
            }
        }

        // SaveAs() - Save file as specific format - Requirements state Saveas and save do the same action
        private void SaveAs()
        {
            Save();
        }

        // Cut() - Cut selected text
        private void Cut()
        {
            RichTB.Cut();
        }
        
        // Copy() - Copy selected text
        private void Copy()
        {
            RichTB.Copy();
        }

        // Paste() - Paste copied or cut text
        private void Paste()
        {
            RichTB.Paste();
        }

        // About()
        private void About()
        {
            About about = new About();
            about.Show();
        }

        // TextEditor_FormClosed() - On closing window, exit the application
        private void TextEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
