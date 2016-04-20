using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireMeBot.InterviewData
{
    /// <summary>
    /// A class representing a question that the bot will ask the prospective
    /// employee as part of the interview.
    /// </summary>
    public class Question
    {
        private string questionString;
        /// <summary>
        /// The text of the question being asked
        /// </summary>
        public string QuestionString
        {
            get
            {
                return questionString;
            }

            set
            {
                questionString = value;
            }
        }

        private IList<Objective> objectives;
        /// <summary>
        /// The knowledge that the employer wants to gain from this question,
        /// represented by an <see cref="Objective"/>
        /// </summary>
        public IList<Objective> Objectives
        {
            get
            {
                return objectives;
            }

            set
            {
                objectives = value;
            }
        }

        //private IList<Characteristic> characteristics;
        ///// <summary>
        ///// The qualities that the employer is looking for in the answer
        ///// to this question
        ///// </summary>
        //public IList<Characteristic> Characteristics
        //{
        //    get
        //    {
        //        return characteristics;
        //    }

        //    set
        //    {
        //        characteristics = value;
        //    }
        //}

        private IList<Keyword> keywords;
        /// <summary>
        /// Any words that the employer thinks is a good thing if the
        /// interviewee used during the interview
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

        private IList<Experience> experience;
        /// <summary>
        /// Any previous experience that the interviewee has had, such as
        /// courses in college or previous jobs
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
    }
}