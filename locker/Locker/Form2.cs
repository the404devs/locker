using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Locker
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        /*Method to create a new locker*/
        private void createLocker()
        {
            if (txtPass.Text != "")//Ensure they actually gave us a password
            {
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);//path to appdata
                StreamWriter sw = new StreamWriter(appData + "/.locker/pass.txt");//begin writing to pass.txt
                string pass = txtPass.Text;//get their chosen password
                sw.WriteLine(pass);//write it to the file
                sw.Close();//stop writing to the file
                this.Hide();//get rid of this form
                LockerView lockerView = new LockerView();//create a new instance of the LockerView form
                lockerView.Show();//show it
            }
            else//didn't give a password
            {
                label2.Text = "Please enter a password!";//Tell them they really should give us a password
                label2.ForeColor = Color.Red;//Turn the text red to really drive home our point
            }
        }

        /*Action when a key is pressed in the input box*/
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//If its the enter key
            {
                createLocker();//Create the locker
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            createLocker();//Create the locker
        }
    }
}
