////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      P2Driver.cs
//  Description:    Windows driven driver that analyzes a users text file
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        March 16, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1;
namespace Project2
{
    /// <summary>
    /// The driver for the text analysis program
    /// </summary>
    static class P2Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            String strName;                        //For user input name
            String strEmail;                       //For user input email
            User u1;                 //For storing user information



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());        //runs the SplashScreen

            UserInformation UserInfo = new UserInformation();
            UserInfo.ShowDialog();      //Runs the User Information Dialog
            try
            {
                strName = UserInfo.UserName;
                strEmail = UserInfo.EmailAddress;
                u1 = new User(strName, strEmail); //creates new user if valid info is entered
            }
            catch(Exception ex2)
            {
                MessageBox.Show($"An error occurred. Either an invalid name or email was entered. Or" +
                     " The cancel or exit button was chosen"
                    + "\nNames cannot be blank an emails must be valid emails"
                    + "\nExamples of valid emails: \n" +
                    "\nmyname@yahoo.com"
                    +"\nstudent@etsu.edu"
                    + "\n\n The program will continue with no name or email.");
                u1 = new User();    //creates blank user if valid info is not entered
            }

            Application.Run(new TextAnalysisForm()); //runs main text Analysis form

            MessageBox.Show($"I Hope you found this program useful {u1.UserName}, I have emailed you the " +
                $"price of this program at {u1.Email}. The total due is $5.00","Goodbye and Thank you",
                MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,0);

            Application.Run(new TextAboutBox());    //runs About Box

        }//end Main
    }//end P2Driver
}//end Project2
