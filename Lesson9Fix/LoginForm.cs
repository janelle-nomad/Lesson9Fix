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

namespace Lesson9Fix
{
    public partial class LoginForm : Form
    {
        /*
         * <summary>
         * This is the default constructor for the login class
         * </summary>
         * **/
        public LoginForm()
        {
            InitializeComponent();
        }

        private void _clearForm()
        {
            /*
             * <summary>This method clears the form</summary> 
             * @method {private}
             * @return {void}
             * **/

            UserTb.Clear();
            PassTb.Clear();
        }

        private void label1_Click(object sender, EventArgs e)//error, "ask how to delete"
        {

        }

        /*
         * <summary>
         * This is the event handler
         * </summary>
         * @Private {sender}
         * @method 
         * **/
        private void LoginBtn_Click(object sender, EventArgs e)
        {

            Debug.WriteLine("Username: " + UserTb.Text);
            Debug.WriteLine("Password: " + PassTb.Text);
            this._clearForm();

        }
    }
}
