using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonEventsPractice
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("Main Form Loaded" + Environment.NewLine);
        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    messagesTextBox.AppendText("Left button of the mouse has been clicked over the main form" + Environment.NewLine);
                    break;
                case MouseButtons.Right:
                    messagesTextBox.AppendText("Right button of the mouse has been clicked over the main form" + Environment.NewLine);
                    break;
                default:
                    break;
            }            
        }

        private void eventLabel_DoubleClick(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("Oh! So you couldnt resist double clicking the label huh?" + Environment.NewLine);
        }

        private void eventNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int a = (int)eventNumericUpDown.Value;
            messagesTextBox.AppendText("The NumericUpDown value has changed to: " + a + Environment.NewLine);
        }

        private void eventListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = (int)eventListBox.SelectedIndex;
            messagesTextBox.AppendText("ListBox selected Index has changed to: " + a + Environment.NewLine);
        }

        private void eventTestBox_Leave(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("TestBox lost the focus, maybe not the chosen one" + Environment.NewLine);
        }

        private void eventTestBox_Enter(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("TestBox is the chosen one, it has the focus" + Environment.NewLine);
        }

        private void eventTestBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char lletra = e.KeyChar;
            messagesTextBox.AppendText($"The '{lletra}' key was pressed and released" + Environment.NewLine);
        }

        private void eventPictureBox_MouseEnter(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("The mouse entered the image" + Environment.NewLine);
        }

        private void eventPictureBox_MouseLeave(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("The mouse left the image" + Environment.NewLine);
        }
    }
}
