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

namespace WindowsFormsApp6
{
    public partial class MainMenu : Form
    {
        // Variables Created and valued here
        int valueMemCost = 0;
        double valueExtraCost = 0;
        double Mobilenumber;
        long Number;
        int AccessValue, PersonalValue, Dietvalue, VideoRentalvalue, filewrite = 0;
        string Frequency;
        decimal Discount, RegularPayAmount;
        string Alert;

        public MainMenu()
        {
            InitializeComponent();
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            //Null Entires for First Name, Last Name, Address And MobileNumber 
            string[] NullEntires = new string[4];
            NullEntires[0] = FirstnameBox.Text;
            NullEntires[1] = LastnameBox.Text;
            NullEntires[2] = AddressBox.Text;
            NullEntires[3] = MobilenumberBox.Text;

            string[] Names = new string[4];
            Names[0] = "First Name";
            Names[1] = "Last Name";
            Names[2] = "Address";
            Names[3] = "Mobile Number";

            Alert = "";
            for (int o = 0; o < 4; o++)
            {

                if (NullEntires[o] == "")
                {
                    Alert += "Please enter A Valid " + Names[o] + "\n";

                }
                if (NullEntires[0] != "")
                {
                    continue;
                }

            }
            if (Alert != "")
            {
                MessageBox.Show(Alert);
                return;
            }

            //Null Entries for Number bank Account
            if (NumberTxtBox.Text == "")
            {
                MessageBox.Show("Please Enter Valid Bank Account Number");
                return;
            }
            // Changing the GUI textboxes to varaibles that can be written to file 
            String Firstname = FirstnameBox.Text;
            String Lastname = LastnameBox.Text;
            String Address = AddressBox.Text;
            Mobilenumber = double.Parse(MobilenumberBox.Text);
            Number = long.Parse(NumberTxtBox.Text);

         for (filewrite = 1; filewrite < 2; filewrite++)
         {
             //Writing to the file  checking if the file has been written properly
             StreamWriter sr = File.AppendText("members.txt");
             sr.WriteLine("First Name: " + Firstname);
             sr.WriteLine("Last Name: " + Lastname);
             sr.WriteLine("Address: " + Address);
             sr.WriteLine("Mobile number: " + Mobilenumber);
             sr.WriteLine("Regular Payment Amount: " + RegularPayAmount);
             sr.WriteLine("Number: " + Number);
             sr.WriteLine("Frequency: " + Frequency);
             sr.WriteLine(" ");
             sr.WriteLine(" ");
             AlertTextBox.Text = " The data has been written successfully";
             sr.Close();
         }
                             

                //Clearing everything in the GUI
                FirstnameBox.Text = "";
                LastnameBox.Text = "";
                MobilenumberBox.Text = "";
                AddressBox.Text = "";
                NumberTxtBox.Text = "";
                MembershipCostBox.Text = "";
                TotalDiscountBox1.Text = "";
                ExtraChargesCostBox.Text = "";
                NetMemberShipCostBox1.Text = "";
                RegularPaymentAmountCostBox.Text = "";
                if (BasicRadBut.Checked) { BasicRadBut.Checked = false; }
                if (RegRadBut.Checked) { RegRadBut.Checked = false; }
                if (PremiumRadBut.Checked) { PremiumRadBut.Checked = false; }
                if (ThreeMonthsRadBut.Checked) { ThreeMonthsRadBut.Checked = false; }
                if (TwevleMonthRadBut.Checked) { TwevleMonthRadBut.Checked = false; }
                if (twentyfourMonthRadBut.Checked) { twentyfourMonthRadBut.Checked = false; }
                if (BankRadBut.Checked) { BankRadBut.Checked = false; }
                if (Access.Checked) { Access.Checked = false; }
                if (PersonalTrainer.Checked) { PersonalTrainer.Checked = false; }
                if (DietConsultation.Checked) { DietConsultation.Checked = false; }
                if (VideoRental.Checked) { VideoRental.Checked = false; }
                if (MonthlyRadButt.Checked) { MonthlyRadButt.Checked = false; }
                if (WeeklyRadButt.Checked) { WeeklyRadButt.Checked = false; }
                if (CreditRadBut.Checked) { CreditRadBut.Checked = false; }

            }

            private void button2_Click(object sender, EventArgs e)
            {
                // Closing the Application
                this.Close();
            }

            private void calculatebutton_Click(object sender, EventArgs e)
            {
                AlertTextBox.Text = "";
                // Checking what membership the customers wants and what the price will change
                if (BasicRadBut.Checked)
                {
                    if (ThreeMonthsRadBut.Checked) { valueMemCost = 13; }
                    if (TwevleMonthRadBut.Checked) { valueMemCost = 11; }
                    if (twentyfourMonthRadBut.Checked) { valueMemCost = 10; }

                }
                if (RegRadBut.Checked)
                {
                    if (ThreeMonthsRadBut.Checked) { valueMemCost = 14; }
                    if (TwevleMonthRadBut.Checked) { valueMemCost = 12; }
                    if (twentyfourMonthRadBut.Checked) { valueMemCost = 11; }

                }
                if (PremiumRadBut.Checked)
                {
                    if (ThreeMonthsRadBut.Checked) { valueMemCost = 16; }
                    if (TwevleMonthRadBut.Checked) { valueMemCost = 14; }
                    if (twentyfourMonthRadBut.Checked) { valueMemCost = 12; }
                }

                //Setting everything back to zero 
                AccessValue = 0;
                PersonalValue = 0;
                Dietvalue = 0;
                VideoRentalvalue = 0;

                //Extra Features Cost
                if (Access.Checked == true)
                {
                    AccessValue = 1;

                }
                if (PersonalTrainer.Checked == true)
                {
                    PersonalValue = 20;

                }
                if (DietConsultation.Checked == true)
                {
                    Dietvalue = 20;

                }
                if (VideoRental.Checked == true)
                {
                    VideoRentalvalue = 2;

                }
                //Giving Bank Discount
                if (BankRadBut.Checked) {

                    Discount = Convert.ToDecimal(valueMemCost * 0.01);
                    TotalDiscountBox1.Text = Discount.ToString();
                }

                //Costs being displayed in the GUI
                valueExtraCost = VideoRentalvalue + Dietvalue + PersonalValue + AccessValue;
                RegularPayAmount = valueMemCost - Discount + Convert.ToDecimal(valueExtraCost);
                NetMemberShipCostBox1.Text = Convert.ToString(valueMemCost + valueExtraCost - Convert.ToDouble(Discount));


                //NetMemberShipCostBox1.Text = Convert.ToString(RegularPayAmount);
                ExtraChargesCostBox.Text = valueExtraCost.ToString();
                MembershipCostBox.Text = valueMemCost.ToString();
                RegularPaymentAmountCostBox.Text = Convert.ToString(RegularPayAmount);

                // Deciding in between weekly or Monthly Payment
                if (WeeklyRadButt.Checked) { Frequency = "Weekly"; }
                if (MonthlyRadButt.Checked)
                {
                    RegularPaymentAmountCostBox.Text = Convert.ToString(RegularPayAmount * 4);
                    Frequency = "Monthly";
                }

            }
           
        }

    }


