using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Permutations
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnPermuting_Click(object sender, EventArgs e)
        {
            if (txbInput.Text != string.Empty)
            {
                for (int i = 0; i < txbInput.Text.Length; i++)
                {
                    if (!char.IsNumber(txbInput.Text[i]))
                    {
                        lblError.Text = "You MUST type an integer!";
                        txbInput.Clear();
                        return;
                    }
                }
                int inputN = Convert.ToInt32(txbInput.Text);
                if (inputN > 0 && inputN < 50)
                {
                    Results r = new Results(inputN);
                    this.Hide();
                    r.ShowDialog();
                    txbInput.Clear();
                    this.Show();
                }
                else
                {
                    lblError.Text = "The integer MUST be between 0 and 50!";
                    txbInput.Clear();
                    return;
                }
            }
            else
            {
                lblError.Text = "First give me something to permute..";
                return;
            }
        }
    }
}
