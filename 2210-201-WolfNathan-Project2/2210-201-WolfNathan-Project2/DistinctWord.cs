////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      DistinctWord.cs
//  Description:    Represents a single word of test (token that contains no punctuation or escape characters)
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
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// Container for distinct words. Gets only the words from the 
    /// text and counts how many times each of the words appear
    /// </summary>
    /// <seealso cref="System.IComparable{Project1.DistinctWord}" />
    /// <seealso cref="System.IEquatable{Project1.DistinctWord}" />
    class DistinctWord : IComparable<DistinctWord>, IEquatable<DistinctWord>
    {
        public String Word { get; set; }        //stores a single word of text, no punctuation

        public int Count { get; set; }          //holds how many times that word appears in the text



        /// <summary>
        /// Default Constructor for the Distinct Word class
        /// </summary>
        public DistinctWord()
        {
            Word = "";
            Count = 0;
        }


        /// <summary>
        /// A parameterized constructor for the word class
        /// </summary>
        /// <param name="word">A single word from the text file.</param>
        public DistinctWord(string word)
        {
            Word = word.ToLower();
            Count = 0;
                            
        }


        /// <summary>
        /// Ordering comparer for the DistinctWord class
        /// </summary>
        /// <param name="other">The other DistinctWord to compare against this DisctinctWord.</param>
        /// <returns> 0 if equal; > 0 if greater, less than 0  if smaller </returns>
        public int CompareTo(DistinctWord other)
        {
            return this.Word.CompareTo(other.Word);
        }

        /// <summary>
        /// Two words are equal if they are the same word
        /// </summary>
        /// <param name="other">DistinctWord to compare against this DisctinctWord.</param>
        /// <returns> true if they are the same word, false if they are not</returns>
        public bool Equals(DistinctWord other)
        {
            return this.Word.Equals(other.Word);
        }


        /// <summary>
        /// Override of Object.Equals
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return base.Equals(obj);
            if (!(obj is DistinctWord))
                throw new ArgumentException($"Cannot compare a DistinctWord object to a" +
                    $"{obj.GetType()} object");
            return Equals(obj as DistinctWord);
        }


        /// <summary>
        /// Override of Object.GetHashCode
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }


        /// <summary>
        /// A overridden toString method for the Distinct word class
        /// </summary>
        /// <returns>
        /// Shows the word and its count as a string to be used in other classes
        /// </returns>
        public override string ToString()
        {
            return $"{Word.PadRight(40,' ')}{Count}";
        }


  

    }//end DistinceWord
}//end Project1
