////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      UserInformation.cs
//  Description:    Secondary form for User input information
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        March 16, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
using Project1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    /// <summary>
    /// Public class for the Secondary User Information form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class UserInformation : Form
    {
        public String UserName { get; set; }        //holds the user name

        public String EmailAddress { get; set; }    //hold the email address


        /// <summary>
        /// Initializes a new instance of the <see cref="UserInformation"/> class.
        /// </summary>
        public UserInformation()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Handles the Click event of the OkButton control.
        /// Checks to see if valid info was entered
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            User u1 = new User();       //user object for manipulating name and email.
            try
            {
                UserName = UserNameTextBox.Text;
                EmailAddress = EmailAddressTextBox.Text;
            }
            catch(Exception ex1)
            {
                MessageBox.Show($"An error occurred {ex1.Message}");
            }

            this.Close();
      
        }



        /// <summary>
        /// Handles the Click event of the CancelButton control.
        /// Closes the UserInfo form. Sets values for name and email to empty strings
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            UserName = "";
            EmailAddress = "";
            this.Close();
        }
    }//end UserInformation
}//end Project2
