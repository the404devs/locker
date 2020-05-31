using System;
using System.Windows.Forms;

namespace Locker
{
    public partial class PassChange : Form
    {
        public PassChange()
        {
            InitializeComponent();
        }

        /*Code when a key is pressed in the text input*/
        private void txtNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//If its the enter key
            {
                btnDone.PerformClick();//Pretend they clicked done. This will close the dialog
            }
        }
    }
}
