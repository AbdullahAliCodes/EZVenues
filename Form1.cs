using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    /*
 * Tamir Palay 2458163
Mohammed Bangie 2610990
Raeesa Lorgat 2686242
Abdullah Ali 2309318
 */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declaring constants given in the outline 
        const double dblVipDiscRate = 0.05;
        const double dblRetailDiscRate = 0.01;
        const double dblVatRate = 0.1;
        const int intDRSRate = 80;
        const int intPNTRate = 50;
        const int intJKTRate = 150;
        const int intWIGRate = 100;
        const int intHATRate = 25;
        const int intTOPRate = 90;
        const int intSMLpnts = 5;
        const int intMIDpnts = 10;
        const int intLRGpnts = 20;


        // declaring global variables
        string strCustPhoneNumber, strCustStats, strClthCode;
        int intClthQuantity,intLoyaltyPts,intTotalLoyaltyCusts, intTotalNumOfCusts;
        double dblTotalPurchase,dblDiscAmt,dblVatAmt;
        double dblAccTotalPurchase = 0;
        bool bHasLoyaltyCard;


        public static string InputBox(string prompt, string title, string defaultValue)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.DefaultValue = defaultValue;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        // Totals cleared for next customer but the accumlated totals have not been cleared
        // Default status set as regular
        // The focus is set to phone number
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDiscount.Text = "0.00";
            dblDiscAmt = 0;
            lblVAT.Text = "0.00";
            dblVatAmt = 0;
            lblTotal.Text = "0.00";
            dblTotalPurchase = 0;
            lblPoints.Text = "0";
            intLoyaltyPts = 0;
            rdbRegular.Checked = true;
            rdbVIP.Checked = false;
            rdbRetail.Checked = false;
            chkLoyaltyCard.Checked = false;
            mtxtPhoneNumber.Text = string.Empty;
            mtxtPhoneNumber.Focus();
        }

    

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Assumption: Previous customers details are cleared before a new one is processed
        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetInputs();

            bool blnIsValid = true;

            blnIsValid = ValidatePhoneNum(strCustPhoneNumber, blnIsValid);


            // checks if all conditions have been validated
            if (blnIsValid == true) {
                GetClthCode();
                while (strClthCode != "END")
                {
                    GetPurchase();
                }

                // subtracts the discount from the total
                dblDiscAmt = CalcDisc(dblDiscAmt, dblTotalPurchase);
                dblTotalPurchase -= dblDiscAmt;

                // adds the vat to the total
                dblVatAmt = dblTotalPurchase * dblVatRate;
                dblTotalPurchase += dblVatAmt;

                intLoyaltyPts = 0;

                // checks if customer has a loyalty card and gives them points if they do
                if (bHasLoyaltyCard == true)
                {
                    intLoyaltyPts = CalcLoyaltyPts(intLoyaltyPts,dblTotalPurchase);
                }

                AccumalateTotals();

                DisplayOutputs();

            }

            // MessageBox.Show(blnIsValid.ToString(), CustPhoneNumber.Length.ToString());

        }

        // Method for displaying all outputs
        private void DisplayOutputs()
        {
            lblDiscount.Text = dblDiscAmt.ToString("C2");
            lblVAT.Text = dblVatAmt.ToString("C2");
            lblTotal.Text = dblTotalPurchase.ToString("C2");

            lblPoints.Text = Convert.ToString(intLoyaltyPts);
            lblAccmTotal.Text = dblAccTotalPurchase.ToString("C2");
            lblAccmCustomers.Text = intTotalNumOfCusts.ToString();
            lblAccmCustomersWPoints.Text = intTotalLoyaltyCusts.ToString();
        }


        // Method for accumulating totals after each new customer
        private void AccumalateTotals()
        {
            intTotalNumOfCusts++;
            if (intLoyaltyPts >= 20) { 
                intTotalLoyaltyCusts++;
            }
            dblAccTotalPurchase += dblTotalPurchase;
        }

        // Methods for calculating correct loyalty points, called if customer has a loyalty card 
        private int CalcLoyaltyPts(int loyaltyPts,double TotalPurchase) {
            if (TotalPurchase < 500) {
                loyaltyPts = intSMLpnts;
            }
            else if (TotalPurchase < 1000)
            {
                loyaltyPts = intMIDpnts;
            }
            else if (TotalPurchase >= 1000)
            {
                loyaltyPts = intLRGpnts;
            }
            return loyaltyPts;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void mtxtPhoneNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        // Calculates discount according to customer status
        private double CalcDisc(double dblDiscAmt, double dblCustTotal)
        {
            // this method calculates the discount depending on the customer's status
            if (rdbRetail.Checked == true)
            { dblDiscAmt = dblCustTotal * dblRetailDiscRate; }
            else
            if (rdbVIP.Checked == true)
            { dblDiscAmt = dblCustTotal * dblVipDiscRate; }
            return dblDiscAmt;
        }

        private void lblAccmCustomers_Click(object sender, EventArgs e)
        {

        }

        private void lblAccmTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblAccmCustomersWPoints_Click(object sender, EventArgs e)
        {

        }

        // Called on each iteration of while loop to itemize billing
        private void GetPurchase()
        {
            bool blnValidClothItem = true;
            blnValidClothItem = ValidateClothingCode(blnValidClothItem,strClthCode);

            if (blnValidClothItem == true)
            {
                GetClthQuantity();

                dblTotalPurchase = CalcPurchases(strClthCode, intClthQuantity, dblTotalPurchase);

            }

            GetClthCode();
        }


        // Determines total purchases based on clothing code and quantity
        private double CalcPurchases(string ClthCode, int ClthQuantity, double TotalPurchase) {
            if (ClthCode == "DRS") {
                TotalPurchase += intDRSRate * ClthQuantity;
            }
            else if (ClthCode == "PNT")
            {
                TotalPurchase += intPNTRate * ClthQuantity;
            }
            else if (ClthCode == "JKT")
            {
                TotalPurchase += intJKTRate * ClthQuantity;
            }
            else if (ClthCode == "WIG")
            {
                TotalPurchase += intWIGRate * ClthQuantity;
            }
            else if (ClthCode == "HAT")
            {
                TotalPurchase += intHATRate * ClthQuantity;
            }
            else if (ClthCode == "TOP")
            {
                TotalPurchase += intTOPRate * ClthQuantity;
            }

            return TotalPurchase;

        }

        // Accepts the quantity of each item
        private void GetClthQuantity() {
            intClthQuantity = Convert.ToInt16(InputBox("Please enter the quantity", "CODE INPUT", ""));
        }

        private bool ValidateClothingCode(bool blnValidClothItem, string strClothCode) {
            // this method validates the clothing code to ensure it is one of the allowed codes
            if (strClothCode != "DRS" && strClothCode != "PNT" && strClothCode != "JKT" && strClothCode != "WIG" &&
            strClothCode != "HAT" && strClothCode != "TOP") 
            {
                blnValidClothItem = false;
                MessageBox.Show("Invalid clothing code", "Input Error");
            }
            return blnValidClothItem;
        }

        // Accepts the clothing code
        private void GetClthCode() {
            strClthCode = InputBox("Please enter the clothing code", "CODE INPUT", "").ToUpper();
        }

        // Validates the phone number
        private bool ValidatePhoneNum(string CustPhoneNumber, bool blnIsValid) {
            if (CustPhoneNumber.Length != 12
                || CustPhoneNumber == "") {
                blnIsValid = false;
                MessageBox.Show("Please enter a valid Phone Number","Error");
            }

            return blnIsValid;
        }

        // Accepts/Selects phone number and loyalty card respectively
        private void GetInputs()
        {
            strCustPhoneNumber=mtxtPhoneNumber.Text;
            bHasLoyaltyCard = chkLoyaltyCard.Checked;

        }
    }
}
