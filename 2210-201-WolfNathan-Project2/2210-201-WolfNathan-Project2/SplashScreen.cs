////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      SplashScreen.cs
//  Description:    VS generated Code for the SplashScreen Form
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        March 16, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////

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
    /// Partial class for the SplashScreen form.
    /// Displays a short splash screen at the beginning of the program
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplashScreen"/> class.
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Tick event of the SplashTimer control.
        /// Closes after an amount of time
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.Close();   //close splash screen when timer expires
        }
    }//end SplashScreen
}//end Project 2
