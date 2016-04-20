using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireMeBot.InterviewData
{
    /// <summary>
    /// Represents the knowledge that the employer wants to get
    /// from a particular question
    /// </summary>
    public class Objective
    {
        private string objective;
        /// <summary>
        /// A string representing the knowledge that the employer wants
        /// to gain from a question; it must be one of the following
        /// values:
        /// 
        /// 
        /// 
        /// </summary>
        public string ObjectiveString
        {
            get
            {
                return objective;
            }

            set
            {
                objective = value;
            }
        }
    }
}