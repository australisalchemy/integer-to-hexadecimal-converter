using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntHex
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private dynamic toHex(dynamic input)
        {
                return input.ToString("X");
        }

        private dynamic toDec(dynamic input)
        {
                return long.Parse(input, System.Globalization.NumberStyles.HexNumber);
        }

        private dynamic toBin(dynamic input)
        {
                return Convert.ToString(input, 2);
        }

        private void txtInputDec_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                char[] result = new char[txtInputDec.Text.Length];
                string fixedString = "";

                if (string.IsNullOrEmpty(txtInputDec.Text) != true)
                {
                    for (int i = 0; i < txtInputDec.Text.Length; i++)
                    {
                        if (txtInputDec.Text[i] != ',')
                        {
                            result[index++] = txtInputDec.Text[i];
                        }
                    }

                    fixedString = new string(result, 0, index);

                    txtHex.Text = toHex(Int64.Parse(fixedString));
                    txtBinary.Text = toBin(Int64.Parse(fixedString));
                    txtDecimal.Text = txtInputDec.Text;
                }
                else
                {
                    clearAll();
                    // do nothing
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input!");
                clearAll();
            }
             
        }

        private void txtInputHex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInputHex.Text) != true)
                {
                    txtDecimal.Text = toDec(txtInputHex.Text).ToString();
                    txtHex.Text = txtInputHex.Text;
                    txtBinary.Text = Convert.ToString(Convert.ToInt64(txtInputHex.Text, 16), 2);
                }
                else
                {
                    clearAll();
                    // do nothing
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input!");
                clearAll();
            }
                
        }

        private void txtBinInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBinInput.Text) != true)
                {
                        txtBinary.Text = txtBinInput.Text;
                        txtDecimal.Text = Convert.ToInt64(txtBinInput.Text, 2).ToString();
                        txtHex.Text = toHex(Convert.ToInt64(txtBinInput.Text, 2));
                }
                else
                {
                    clearAll();
                    // do nothing
                }
                
            }
            catch
            {
                MessageBox.Show("Invalid Input!");
                clearAll();
            }
            
        }

        private void clearAll()
        {
            txtBinInput.Text = "";
            txtBinary.Text = "";

            txtDecimal.Text = "";
            txtInputDec.Text = "";

            txtHex.Text = "";
            txtInputHex.Text = "";
        }


    }
}
