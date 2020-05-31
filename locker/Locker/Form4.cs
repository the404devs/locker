using System;
using System.Windows.Forms;

namespace Locker
{
    public partial class Rename : Form
    {
        public Rename()
        {
            InitializeComponent();
        }        

        /*Action when a key is pressed in the text input*/
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)//If its the enter key
            {
                btnDone.PerformClick();//pretend they clicked done. this will close the dialog
            }     
        }
    }
}
