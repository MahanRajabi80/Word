using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string text = txtEditor.Text;
            int charnumber = 0, linenumber = 1, dotnumber = 0, digitnumber = 0;
            foreach (char ch in text)
            {
                switch (ch)
                {
                    case '\n':
                        linenumber++;
                        break;
                    case '.':
                        dotnumber++;
                        charnumber++;
                        break;
                    default:
                        if (!char.IsControl(ch))
                            charnumber++;
                        if (char.IsControl(ch))
                            digitnumber++;
                        break;
                }
            }
            MessageBox.Show("CharNumber=" + charnumber.ToString() + ",LineNumber=" + linenumber.ToString() + ",DotNumber=" + dotnumber.ToString() + ",DigitNumber=" + digitnumber.ToString());
        }
    }
}
