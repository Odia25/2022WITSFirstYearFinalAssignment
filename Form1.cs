using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022WITSFirstYearFinalAssignment
{
    public partial class FINALASSIGN : Form
    {
        public FINALASSIGN()
        {
            InitializeComponent();
        }
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
        //Declaration of constants
        const double NGRIRIPrice = 100;
        const double BHRLPrice = 150;
        const double CRLLPrice = 80;
        const double FSHSPrice = 70;
        const double MAKIPrice = 100;
        const double SOFTPrice = 95;
        const double WATRPrice = 30;
        const double VATRate = 0.15;
        const double ServRate = 0.1;

        //Declaration of accumualated totals
        double AccumAmtOwing = 0;
        double AccumVATAmt = 0;
        int AccumCash = 0;
        int AccumCard = 0;

        //Method for meal and bev validation
        private bool ValidateMeal(bool blnValidCode, string strFoodBevCode)
        {
            //boolean validation of food and bev codes
            if (strFoodBevCode != "BHRL" 
                && strFoodBevCode != "CRLL" 
                && strFoodBevCode != "FSHS" 
                && strFoodBevCode != "MAKI" 
                && strFoodBevCode != "NGRI" 
                && strFoodBevCode != "SOFT" 
                && strFoodBevCode != "WATR")
            {//error code 
                blnValidCode = false;
                MessageBox.Show("Please enter valid food or beverage code", "ERROR");
            }
            return blnValidCode;
        }

        //Method for FormInput validation 
        private bool FormInput(bool blnFormInput)
        { 
            if(nudNoPeople.Value <1)//validation for number of people
            { blnFormInput = false;
                MessageBox.Show("Invalid Number of People");
            }

        if (nudTabNo.Value<1 || nudTabNo.Value>10)//valiadtion for table number
            { blnFormInput = false;
                MessageBox.Show("Invalid Table Number");
            }
            return blnFormInput;

        }

        //Method for calculating amount owing
        private double CalcAmtOwing(double dblAmtOwing, double dblQty, string strFoodBevCode)
        {
            //calculations for amount owing as per food and bev code
            if (strFoodBevCode == "BHRL")
            { dblAmtOwing = dblQty * BHRLPrice; }
            else
                if (strFoodBevCode == "CRLL")
            { dblAmtOwing = dblQty * CRLLPrice; }
            else
                if (strFoodBevCode == "FSHS")
            { dblAmtOwing = dblQty * FSHSPrice; }
            else
                if (strFoodBevCode == "MAKI")
            { dblAmtOwing = dblQty * MAKIPrice; }
            else
                if (strFoodBevCode == "NGRI")
            { dblAmtOwing = dblQty * NGRIRIPrice; } 
            else 
                if (strFoodBevCode == "SOFT")
            { dblAmtOwing = dblQty * SOFTPrice; }
              else 
                if (strFoodBevCode == "WATR")
            { dblAmtOwing = dblQty * WATRPrice; }

            return dblAmtOwing;
        }

        //Method for calculating service charges
        private double CalcServCharge(double dblAmtOwing, double dblServCharge)
        {
            //accounting for service charges
            if (nudNoPeople.Value > 8)
            {
                dblServCharge = dblAmtOwing * ServRate;
            }
            return dblServCharge;
        }

        //Method for calculating accumulated total
        private void AccumTotals (double dblAmtOwing, double dblVATAmt)
        { 
            AccumAmtOwing += dblAmtOwing;//calculating accumulated amount owing
            AccumVATAmt += dblVATAmt;//calculating accumulated VAT amount

        }

        //Method for displaying amounts
        private void DisplayOutputs(double dblAmtOwing,double dblVATAmt, double AccumVATAmt, double AccumAmtOwing, int AccumCard, int AccumCash)
        { 
            //convert text to label
            lblAmtOwing.Text = dblAmtOwing.ToString("C2");
            lblVatAmt.Text = dblVATAmt.ToString("C2");
            lblAccAmtown.Text = AccumAmtOwing.ToString("C2");
            lblAccVatamt.Text = AccumVATAmt.ToString("C2");
            lblTotCardPay.Text = AccumCard.ToString("");
            lblTotCashPay.Text = AccumCash.ToString("");
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //declaring variables
            double dblQty = 0;
            double dblAmtOwing = 0;
            double dblServCharge = 0;
            double dblVATAmt = 0;

            //validating Input
            bool blnValidInput = true;
            blnValidInput = FormInput(blnValidInput);

            if (blnValidInput==true)
            { 
                //declaration of FOODBEVCODE
                string strFoodBevCode;
                strFoodBevCode = Convert.ToString(InputBox("Please enter food/beverage code", "FOOD/BEVERAGE CODE", "")).ToUpper();//getting of food/bev code //INITIALISATION OF LOOP
            
                while (strFoodBevCode!="AAAA") //termination of loop
                {
                    bool blnValidMealCode = true;
                    blnValidMealCode = ValidateMeal(blnValidMealCode, strFoodBevCode);
                    if (blnValidMealCode==true)
                    {
                        dblQty = Convert.ToDouble(InputBox("Please insert quantity", "QUANTITY INPUT", ""));//getting quantity //alteration
                        dblAmtOwing = CalcAmtOwing(dblAmtOwing, dblQty, strFoodBevCode);
                    }
                    strFoodBevCode = Convert.ToString(InputBox("Please enter food/beverage code", "FOOD/BEVERAGE CODE", "")).ToUpper();
                }
            }
            //calling Calculations for service charges
            CalcServCharge(dblAmtOwing, dblServCharge);

            //calculation for amount owing and service charges
            dblAmtOwing = dblAmtOwing + dblServCharge;

            //calculation for VAT Amount
            dblVATAmt = dblAmtOwing * VATRate;
            dblAmtOwing = dblAmtOwing + dblVATAmt;

            //calling AccumTotals
            AccumTotals(dblAmtOwing, dblVATAmt);

            if (radCard.Checked == true)//counting for card payments
            { AccumCard++; }
            else
           if (radCash.Checked == true)//counting for cash payments
            { AccumCash++; }

            //calling DisplayOutputs
            DisplayOutputs(dblAmtOwing, dblVATAmt, AccumVATAmt, AccumAmtOwing, AccumCard, AccumCash);


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clearing values excluding accumulated amounts
            lblAmtOwing.Text = "0.00";
            lblVatAmt.Text = "0.00";
            radCard.Checked = false;
            radCash.Checked = false;
            chkEatin.Checked = false;
            nudNoPeople.Value = 0;
            nudTabNo.Value = 0;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //termination of application
            Application.Exit();
        }
    }
}
