using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireMeBot.InterviewCriteria
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
        
        /// <summary>
        /// A list of possible values for the objective string; these
        /// values (and their synonyms) will each be matched with
        /// a set of regexes to search for in the interviewer's answer
        /// </summary>
        private static IList<string> objectiveValues;
        
        static Objective()
        {
            objectiveValues = new List<string>
            {
                "strengths", "weaknesses", "interests", "passions",
                "experience", "previous jobs", "how candidate heard of company",
                "why candate wants to work there" // TODO: add more by analyzing interview scripts online
            };
        }
    }
}