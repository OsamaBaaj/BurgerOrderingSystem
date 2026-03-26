using SomeProjects.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeProjects
{
    public partial class frmBurger : Form
    {
        byte totalToppings = 1;

        public frmBurger()
        {
            InitializeComponent();
            DefaultSettings();
        }

        //Settings
        void DefaultSettings()
        {
            cbWhereToEat.SelectedIndex = 0;
            rbMediumWell.Checked = true;

            DisableDelivery();

            lbWhatCookingLevel_Summary.Text = rbMediumWell.Text;
            lbWhatToppings_Summary.Text = "";

            cbWhereToEat.SelectedIndex = 0; 
            lbWhereToEat_Summary.Text = cbWhereToEat.SelectedItem.ToString();

            lbAddress_Summary.Text = "";
            lbPhoneNumber_Summary.Text = "";

            lbQuantity_Summary.Text = nudQuantity.Value.ToString();

            SetBackColorTransparent(pnCookingLevels);
            SetBackColorTransparent(pnToppings);
            SetBackColorTransparent(pnWhereToEat);
            SetBackColorTransparent(panel4);
            SetBackColorTransparent(pnSummary);

            SetBackColorTransparent(rbRare);
            SetBackColorTransparent(rbMediumRare);
            SetBackColorTransparent(rbMediumWell);
            SetBackColorTransparent(rbWell);

            SetBackColorTransparent(chkLettuce);
            SetBackColorTransparent(chkTomatoes);
            SetBackColorTransparent(chkCheese);

            SetBackColorTransparent(lbCookingLevels);
            SetBackColorTransparent(lbToppings);
            SetBackColorTransparent(lbWhereToEat);
            SetBackColorTransparent(pnQuantity);
            SetBackColorTransparent(lbOrderSummary);
           
            SetBackColorTransparent(lbAddress);
            SetBackColorTransparent(lbPhoneNumber);

            SetBackColorTransparent(label1);
            SetBackColorTransparent(lbWhatCookingLevel_Summary);
            SetBackColorTransparent(label4);
            SetBackColorTransparent(lbWhatToppings_Summary);
            SetBackColorTransparent(label3);
            SetBackColorTransparent(lbWhereToEat_Summary);
            SetBackColorTransparent(label5);
            SetBackColorTransparent(lbAddress_Summary);
            SetBackColorTransparent(label8);
            SetBackColorTransparent(lbPhoneNumber_Summary);
            SetBackColorTransparent(label7);
            SetBackColorTransparent(lbQuantity_Summary);
            SetBackColorTransparent(label6);
            SetBackColorTransparent(lbTotalPrice);

           
            chkCheese.Checked = false;
            chkLettuce.Checked = false;
            chkTomatoes.Checked = false;

            nudQuantity.Value = 1;

            this.BackgroundImage = Resources.NormalBurger;
            btnOrder.Enabled = true;

            UpdatePrice();
        }
        
        void SetBackColorTransparent(Panel sender)
        {
            sender.BackColor = Color.FromArgb(100, Color.Black);
        }
        void SetBackColorTransparent(RadioButton sender)
        {
            sender.BackColor = Color.FromArgb(0, Color.Black);
        }
        void SetBackColorTransparent(CheckBox sender)
        {
            sender.BackColor = Color.FromArgb(0, Color.Black);
        }
        void SetBackColorTransparent(Label sender)
        {
            sender.BackColor = Color.FromArgb(0, Color.Black);
        }


        void EnableDelivery()
        {
            lbAddress.Enabled = true;
            tbAddress.Enabled = true;

            lbPhoneNumber.Enabled = true;
            tbPhoneNumber.Enabled = true;
        }
        void DisableDelivery()
        {
            lbAddress.Enabled = false;
            tbAddress.Enabled = false;
            tbAddress.Clear();
            lbAddress_Summary.Text = "";

            lbPhoneNumber.Enabled = false;
            tbPhoneNumber.Enabled = false;
            tbPhoneNumber.Clear();
            lbPhoneNumber_Summary.Text = "";
        }
        
        
        //Calculations
        float GetCookingLevelPrice()
        {
            if (rbRare.Checked)
                return Convert.ToSingle(rbRare.Tag);
            else if (rbMediumRare.Checked)
                return Convert.ToSingle(rbMediumRare.Tag);
            else if (rbMediumWell.Checked)
                return Convert.ToSingle(rbMediumWell.Tag);
            else if (rbWell.Checked)
                return Convert.ToSingle(rbWell.Tag);
            return 0;
        }
        float GetToppingsPrice()
        {
            float price = 0;

            if (chkCheese.Checked)
                price += Convert.ToSingle(chkCheese.Tag.ToString());
            if (chkLettuce.Checked)
                price += Convert.ToSingle(chkLettuce.Tag.ToString());
            if (chkTomatoes.Checked)
                price += Convert.ToSingle(chkTomatoes.Tag.ToString());
            return price;
        }
        float GetWhereToEatPrice()
        {
            float price = 0;
            if (cbWhereToEat.SelectedIndex == 2)
                price += 3;
            return price;
        }

        float CalculateTotalPrice()
        {
            return (float)(nudQuantity.Value) *(GetCookingLevelPrice() + GetToppingsPrice()) + GetWhereToEatPrice();
        }

        //Updates
        void UpdatePrice()
        {
            lbTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }
        void UpdateCookingLevel(object sender)
        {
            UpdatePrice();
            lbWhatCookingLevel_Summary.Text = ((RadioButton)sender).Text;
        }
        void UpdateQuantity()
        {
            UpdatePrice();
            lbQuantity_Summary.Text = nudQuantity.Value.ToString();

        }
        void UpdateWhereToEat()
        {
            UpdatePrice();
            if (cbWhereToEat.SelectedIndex == 2)
            {
                EnableDelivery();
            }
            else
            {
                DisableDelivery();
            }
            lbWhereToEat_Summary.Text = cbWhereToEat.SelectedItem.ToString();
        }

        enum enToppings { eNormal = 1, eCheese = 2, eLettuse = 4, eTomatoes = 8 };
        void UpdateImage()
        {
            switch (totalToppings)
            {
                case (Byte)(enToppings.eNormal):
                    this.BackgroundImage = Resources.NormalBurger;
                    break;
                case (Byte)(enToppings.eNormal) + (Byte)(enToppings.eCheese):
                    this.BackgroundImage = Resources.cheese;
                    break;
                case (Byte)(enToppings.eNormal) + (Byte)(enToppings.eLettuse):
                    this.BackgroundImage = Resources.Lettuce;
                    break;
                case (Byte)(enToppings.eNormal) + (Byte)(enToppings.eTomatoes):
                    this.BackgroundImage = Resources.Tomatoes;
                    break;
                case (Byte)(enToppings.eNormal) + (Byte)(enToppings.eCheese) + (Byte)(enToppings.eLettuse):
                    this.BackgroundImage = Resources.CheeseLettuce;
                    break;
                case (Byte)(enToppings.eNormal) + (Byte)(enToppings.eCheese) + (Byte)(enToppings.eTomatoes):
                    this.BackgroundImage = Resources.CheeseTomatoes;
                    break;
                case (Byte)(enToppings.eNormal) + (Byte)(enToppings.eTomatoes) + (Byte)(enToppings.eLettuse):
                    this.BackgroundImage = Resources.LettuceTomatoes;
                    break;
                case (Byte)(enToppings.eNormal) + (Byte)(enToppings.eCheese) + (Byte)(enToppings.eLettuse) + (Byte)(enToppings.eTomatoes):
                    this.BackgroundImage = Resources.CheeseLettuceTomatoes;
                    break;
                default:
                    break;
            }
        }
        void UpdateToppings()
        {
            UpdatePrice();
            totalToppings = 1;

            string toppings = "";

            if (chkCheese.Checked)
            {
                toppings += chkCheese.Text + ", ";
                totalToppings += (byte)(enToppings.eCheese);
            }
            if (chkLettuce.Checked)
            {
                toppings += chkLettuce.Text + ", ";
                totalToppings += (byte)(enToppings.eLettuse);
            }
            if (chkTomatoes.Checked)
            {
                toppings += chkTomatoes.Text + ", ";
                totalToppings += (byte)(enToppings.eTomatoes);
            }
            UpdateImage();

            if (toppings == "")
            {
                lbWhatToppings_Summary.Text = toppings;
                return;
            }

            lbWhatToppings_Summary.Text = toppings.Substring(0, toppings.Length - 2);
        }

        //Order
        bool IsDelivery()
        {
            if (cbWhereToEat.SelectedIndex == 2)
                return true;
            return false;
        }
        bool OrderMessage()
        {
            string message = "";
            message += "Cooking Level : " + lbWhatCookingLevel_Summary.Text + Environment.NewLine;
            message += "Toppings : " + lbWhatToppings_Summary.Text + Environment.NewLine;
            message += "Where To Eat : " + lbWhereToEat_Summary.Text + Environment.NewLine;
            if (IsDelivery())
            {
                message += "Address : " + lbAddress_Summary.Text + Environment.NewLine;
                message += "Phone Number : " + lbPhoneNumber_Summary.Text + Environment.NewLine;
            }
            message += "Quantity : " + nudQuantity.Value + Environment.NewLine;
            message += "\n\tTotal Price : " + lbTotalPrice.Text + Environment.NewLine;

            if ((MessageBox.Show(message, "Order Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
            {
                return true;
            }
            return false;
        }
        void DisableApp()
        {
            pnCookingLevels.Enabled = false;
            pnToppings.Enabled = false;
            pnWhereToEat.Enabled = false;
            panel4.Enabled = false;

            btnOrder.Enabled = false;
        }
        void Order()
        {
            if (OrderMessage())
                DisableApp();
        }
        void Reset()
        {
            pnCookingLevels.Enabled = true;
            pnToppings.Enabled = true;
            pnWhereToEat.Enabled = true;
            panel4.Enabled = true;
            pnSummary.Enabled = true;

            btnOrder.Enabled = false;
            
            DefaultSettings();
        }

        //Events
        private void CookingLevelCheckedChanged(object sender, EventArgs e)
        {
            UpdateCookingLevel(sender);
        }

        private void ToppingsCheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateQuantity();
        }

        private void cbWhereToEat_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void tbPhoneNumber_Error(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPhoneNumber.Text) || tbPhoneNumber.Text.Length < 10)
            {
                e.Cancel = true;
                tbPhoneNumber.Focus();

                errPhoneNumber.SetError(tbPhoneNumber, "Invalid Phone Number!");
            }
            else
            {
                e.Cancel = false;
                errPhoneNumber.SetError(tbPhoneNumber, "");
            }
        }

        private void tbPhoneNumber_Enter(object sender, EventArgs e)
        {
            tbPhoneNumber.SelectionStart = 0;
        }

        private void tbPhoneNumber_Click(object sender, EventArgs e)
        {
            tbPhoneNumber.SelectionStart = 0;
        }

        private void lbWhatCookingLevel_Summary_Click(object sender, EventArgs e)
        {

        }


        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            lbAddress_Summary.Text = tbAddress.Text;
        }

        private void tbPhoneNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lbPhoneNumber_Summary.Text = tbPhoneNumber.Text;    
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order();
        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.DeepSkyBlue;
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.LawnGreen;
        }

        private void btnResetOrder_MouseLeave(object sender, EventArgs e)
        {
            btnResetOrder.BackColor = Color.Silver;
        }
    }
}
