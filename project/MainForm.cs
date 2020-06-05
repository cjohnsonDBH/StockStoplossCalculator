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


namespace project
{
    public partial class MainForm : Form
    {
        // Variables used for moving MainForm around the screen
        private bool mouseDown;
        private Point lastLocation;

        public MainForm()
        {
            InitializeComponent();

            // Check if file exists to load AccountValue
            if (File.Exists("config.ini"))
            {
                // Read file to get AccountValue
                string accountValue = File.ReadAllText(@"config.ini");
                // Set value to AccountValue text box
                txtAccountSize.Text = accountValue;
            }
            else
            {
                // File does not exist yet
                // Enter value manually
            }
        }

        #region Form | Drag & Drop -->
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion <-- Form | Drag & Drop

        #region Form | Minimize, Close, Compact -->

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            if (this.Size == new Size(155, 244))
            {
                Form.ActiveForm.Size = new System.Drawing.Size(155, 25);
            }
            else
            {
                Form.ActiveForm.Size = new System.Drawing.Size(155, 244);
            }

        }
        #endregion <-- Form | Minimize, Close, Compact

        private void txtAccountSize_TextChanged(object sender, EventArgs e)
        {
            if (txtAccountSize.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    double val2 = double.Parse(txtAccountSize.Text);
                    double val1 = Math.Round(0.01 * val2, 2);
                    txtPercentAccount.Text = val1.ToString();

                    // Save AccountValue to file
                    File.WriteAllText("config.ini", txtAccountSize.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtAccountSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPercentAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void txtShares_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPriceShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void txtTotalTrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void txt1pSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void txt15Profit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void txt20Profit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPriceShare_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAccountSize.Text == "")
                {
                    MessageBox.Show("Enter the Account Size Value");
                }
                else
                {
                    double val1 = double.Parse(txtShares.Text);
                    double val2 = double.Parse(txtPriceShare.Text);
                    double val3 = Math.Round(val1 * val2, 2);
                    txtTotalTrade.Text = val3.ToString();


                    double val5 = double.Parse(txtPercentAccount.Text);
                    double val9 = Math.Round(val3 - val5, 2);
                    double val10 = Math.Round(val9 / val1, 2);
                    txt1pSL.Text = val10.ToString();

                    double val15 = double.Parse(txtTotalTrade.Text);
                    double val11 = Math.Round(val15 * 0.15, 2);
                    double val13 = Math.Round(val11 / val1, 2);
                    double val12 = Math.Round(val13 + val2, 2);
                    txt15Profit.Text = val12.ToString();

                    double val14 = Math.Round(val15 * 0.2, 2);
                    double val16 = Math.Round(val14 / val1, 2);
                    double val19 = Math.Round(val16 + val2, 2);
                    txt20Profit.Text = val19.ToString();
                }
            }
            catch { }
        }
    }
}

