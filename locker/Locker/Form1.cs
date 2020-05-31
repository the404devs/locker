using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Locker
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        /*Method to check their password and open the locker*/
        private void openLocker()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);//path to appdata
            string input = txtPass.Text;//Get the password they entered
            if(File.Exists(appData + "/.locker/pass.txt"))//Make sure pass.txt file exists
            {
                StreamReader sr = new StreamReader(appData + "/.locker/pass.txt");//Start reading from pass.txt
                if (input == sr.ReadLine())//If the given password matches the one on file
                {                    
                    sr.Close();//Stop reading from the file
                    this.Hide();//Hide the welcome form
                    LockerView lockerView = new LockerView();//Instance of the LockerView form
                    lockerView.Show();//Show it
                }
                else//Wrong password
                {
                    label2.ForeColor = Color.Red;//Change the color of the label to red
                    label2.Text = "Incorrect password! Try again.";//change the text
                    sr.Close();//stop reading from the file
                }
            }
            else//The password file doesn't exist. I wonder where it went...
            {
                StreamWriter sw = new StreamWriter(appData + "/.locker/pass.txt");//begin writing to pass.txt
                sw.WriteLine(input);//write it to the file
                sw.Close();//stop writing to the file
                this.Hide();//get rid of this form
                MessageBox.Show("You don't appear to have a password set.\nDid you delete the password file? ( ͡° ͜ʖ ͡°)\n\nDoesn't matter. We've just made the text you inputted your new password.");
                LockerView lockerView = new LockerView();//create a new instance of the LockerView form
                lockerView.Show();//show it                
            }
        }

        /*Code for when a key is pressed in the textbox*/
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Enter
            {
                openLocker();//Open the locker
            }
        }

        /*When the open button is pressed*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openLocker();//Open the locker
        }
    }
}
