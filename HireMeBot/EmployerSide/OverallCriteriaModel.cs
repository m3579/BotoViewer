using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HireMeBot.InterviewCriteria;

namespace HireMeBot.EmployerSide
{
    /// <summary>
    /// A collection of the criteria (including questions, characteristics,
    /// experiences, etc.) that the employer wants the bot to look for during
    /// the entire interview; it is configured via the employer web portal.
    /// </summary>
    public class OverallCriteriaModel
    {
        private IList<Characteristic> characteristics;
        /// <summary>
        /// The list of characteristics that the interviewer wants to
        /// see throughout the interview
        /// </summary>
        public IList<Characteristic> Characteristics
        {
            get
            {
                return characteristics;
            }

            set
            {
                characteristics = value;
            }
        }

        private IList<Experience> experience;
        /// <summary>
        /// The experience that the employer is looking for in the candidate
        /// that the bot should look for throughout the entire interview
        /// </summary>
        public IList<Experience> Experience
        {
            get
            {
                return experience;
            }
            
            set
            {
                experience = value;
            }
        }

        private IList<Keyword> keywords;
        /// <summary>
        /// The keywords that the bot should look for in the candidate's answers
        /// throughout the entire interview
        /// </summary>
        public IList<Keyword> Keywords
        {
            get
            {
                return keywords;
            }

            set
            {
                keywords = value;
            }
        }

        private About about;
        /// <summary>
        /// Information about the candidate (such as hobbies or a
        /// favorite sports team)
        /// </summary>
        public About About
        {
            get
            {
                return about;
            }

            set
            {
                about = value;
            }
        }

        /// <summary>
        /// The singleton instance of this class
        /// </summary>
        private static OverallCriteriaModel instance = new OverallCriteriaModel();

        private OverallCriteriaModel()
        {

        }

        /// <summary>
        /// Returns a singleton instance of this class
        /// </summary>
        /// <returns>A singleton instance of this class</returns>
        public static OverallCriteriaModel GetInstance()
        {
            return instance;
        }
    }
}