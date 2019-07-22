using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//EHW
//7.22.19 Current Version 

namespace ProgrammingTemplateForRouter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {

            //input variables

            string NameString = "";
            string SecretString = "";
            string ConString = "";
            string AuxString = "";
            string VtyString = "";
            string VlanNumString = "";
            string VlanIPAString = "";
            string VlanSubString = "";
            string SwitchGateString = "";

            //pulling from user input

            NameString = NameIn.Text;
            SecretString = SecretIN.Text;
            ConString = ConPassIn.Text;
            AuxString = AuxPassIn.Text;
            VtyString = VtyPassIn.Text;
            VlanNumString = VlanNumIn.Text;
            VlanIPAString = VlanIp1st.Text;
            VlanSubString = VlanSub1st.Text;
            SwitchGateString = DefGat1st.Text;

            //validation
            if (SwitchRadio.Checked || RouterRadio.Checked) //if OR, 
            {
                //all good on the western front if either are checked
            }
            else
            {
                //if neither are checked, this fires off
                MessageBox.Show("Error: Please Select a Device Type");
                return;
            }



            string CommandString = ""; //command string to be built upon


            CommandString = CommandString + "enable" + "\r\n"  //so this is the "best practices"
                + "config t" + "\r\n"
                + "hostname " + NameString + "\r\n" //device is named
                + "banner motd *" + "\r\n"
                + "Hello, this is " + NameString + "\r\n" //banner is created
                + "Authorized access only" + "\r\n"
                + "Activity on this device is monitored and recorded" + "\r\n"
                + "This information can and will be used in persecutions" + "\r\n"
                + "Have a nice day!*" + "\r\n"
                + "enable secret " + SecretString + "\r\n" //enable secret is set
                + "service password-encryption" + "\r\n"
                + "line con 0" + "\r\n"
                + "password " + ConString + "\r\n" //Console password is set
                + "login" + "\r\n"
                + "line vty 0 15" + "\r\n"
                + "password " + VtyString + "\r\n" //vty password is set
                + "login" + "\r\n";

            if (RouterRadio.Checked)
            {
                CommandString = CommandString //Aux is set if Router is selected
                    + "line aux 0" + "\r\n"
                    + "password " + AuxString + "\r\n"
                    + "login" + "\r\n";
            }

            CommandString = CommandString //end sequence for now
            + "exit" + "\r\n"
            + "exit" + "\r\n"; //returns to priviledged exec prompt

            if (VLanCheck.Checked == true)
            {
                CommandString = CommandString
                    + "config t" + "\r\n"
                    + "interface vlan" + VlanNumString + "\r\n" //vlan# interface
                    + "ip address " + VlanIPAString + " " + VlanSubString + "\r\n" //ip address and sub created
                    + "no shut" + "\r\n" //no shutdown
                    + "exit" + "\r\n" //back to config t
                    + "ip default-gateway " + SwitchGateString + "\r\n"; //default gateway set
            }

            CommandString = CommandString //end sequence for now
            + "exit" + "\r\n"; //back to priviledged exec prompt




            //outputs
            ConfigOut.Text = CommandString;

        }

        private void SwitchRadio_CheckedChanged(object sender, EventArgs e) //if the router button is clicked, enable and disable as needed
        {
            AuxPassIn.Enabled = false;
            VLanCheck.Enabled = true;
            VlanIp1st.Enabled = true;
            VlanIp2nd.Enabled = true;
            VlanIp3rd.Enabled = true;
            VlanIp4th.Enabled = true;
            VlanNumIn.Enabled = true;
            VlanSub1st.Enabled = true;
            VlanSub3rd.Enabled = true;
            VlanSub3rd.Enabled = true;
            VlanSub4th.Enabled = true;
            DefGat1st.Enabled = true;
            DefGat2nd.Enabled = true;
            DefGat3rd.Enabled = true;
            DefGat4th.Enabled = true;
        }

        private void RouterRadio_CheckedChanged(object sender, EventArgs e) //if the router button is clicked, enable and disable as needed
        {
            AuxPassIn.Enabled = true;
            VLanCheck.Enabled = false;
            VlanIp1st.Enabled = false;
            VlanNumIn.Enabled = false;
            VlanSub1st.Enabled = false;
            DefGat1st.Enabled = false;

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ConfigOut.Text); //copies your command line to the clipboard
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    /*  EVENTUALLY BUILD A PROPER ADDRESS CHECKER TO ESNURE THE NUMBERS ARE RANGED 0.0.0.0 TO 255.255.255.255
    public static class RouterTools
    {
        public static string Addresser(int First, int Second, int Third, int Fourth)
        {
            string addQuart = "";
            addQuart = $"{First}.{Second}.{Third}.{Fourth}";
            return addQuart;
        }
        public static void AddressCheck(int firstQuart, int secondQuart, int thirdQuart, int fourthQuart);
        {
                
        }
    }*/
}
