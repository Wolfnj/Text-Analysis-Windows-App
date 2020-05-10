////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      User.cs
//  Description:    Encapsulates the user's name, email address, and phone number
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        March 16, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// Encapsulates the user's name, email address, and phone number
    /// </summary>
    class User
    {
        public String UserName { get; set; }    //contains the user's name

        public String Email { get; set; }       //contains the user's email

        public String PhoneNumber { get; set; } //contains the user's phone number
        
        /// <summary>
        /// Default Constructor for the User class
        /// </summary>
        public User()
        {
            UserName="";
            Email="";
            PhoneNumber="";
        }//end User()



        /// <summary>
        /// Parameterized constructor for user
        /// </summary>
        /// <param name="name">The user's name.</param>
        /// <param name="email">The user's email.</param>
        /// <param name="phoneNumber">The user's  phone number.</param>
        public User(string name, string email, string phoneNumber)
        {
            
            UserName = FixName(name);
            Email = FixEmail(email);
            PhoneNumber = FixPhone(phoneNumber);
        }//end User(string,string,string)




        /// <summary>
        /// Parameterized constructor for user. For only name and email.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="email">The email.</param>
        public User(string name, string email)
        {
            UserName = FixName(name);
            Email = FixEmail(email);
            PhoneNumber = "";
        }






        /// <summary>
        /// Organizes the name of the user
        /// </summary>
        /// <param name="name">The user input name.</param>
        /// <returns>Properly capitalized and organized full name</returns>
        public string FixName( string name)
        {
            String strName = "";            //The organized name
            Name n1 = new Name(name);       //Name object to alter name
            strName = n1.DisplayFirstNameFirst();   //Organizes the format using the name class method
            return strName;
        }//ends FixName(String)

        /// <summary>
        /// Uses regular expressions to fix the user's name
        /// </summary>
        /// <param name="name">The user's email address.</param>
        /// <returns>The user's email address if correct, empty string if not</returns>
        public string FixEmail(string name)
        {
            String strEmail = "";
            Regex pattern  = new Regex (@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

            Match match = pattern.Match(name);

            if(match.Success)
            {
                strEmail = name;
            }
            else
            {

                throw new Exception ("Email is not valid: Possible examples" +
                    "\n\tmyname@yahoo.com" +
                    "\n\tstudent@etsu.edu");

            }
            return strEmail;
        }


        /// <summary>
        /// Uses a regular expression to fix the user's phone number
        /// </summary>
        /// <param name="name">The user's phone number.</param>
        /// <returns>The user's phone number if correct, empty string if not</returns>
        public string FixPhone (string phone)
        {
            String strPhone = "";
            Regex pattern = new Regex(@"\((?<AreaCode>\d{3})\)\s*(?<Number>\d{3}(?:-|\s*)\d{4})");
            Match match = pattern.Match(phone);

            if (match.Success)
            {
                strPhone = phone;
            }
            else
            {

                throw new Exception("Phone number is not valid: Possible examples" +
                    "\n\t(800) 325-3535" +
                    "\n\t(800) 325 3535");

            }
            return strPhone;
        }//end FixPhone(string)


    


    }//end User
}//end Project1
