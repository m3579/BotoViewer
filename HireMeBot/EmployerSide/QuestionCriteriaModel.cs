using HireMeBot.InterviewCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireMeBot.EmployerSide
{
	/// <summary>
    /// The criteria that the employer has specified for
    /// a specific question; this class will be used to represent
    /// questions
    /// </summary>
	public class QuestionCriteriaModel
	{
        private string question;
		/// <summary>
        /// The text of the question that the employer wants to ask
        /// </summary>
        public string Question
        {
			get
            {
                return question;
            }

			set
            {
                question = value;
            }
        }

        private IList<Characteristic> characteristics;
		/// <summary>
        /// The characteristics that the employer wants to see that the
        /// candidate displays during their answer to this question
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

        private Experience experience;
		/// <summary>
        /// The experience that the candidate should show that they have
        /// had during their answer to this question
        /// </summary>
        public Experience Experience
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
        /// A list of keywords that the employer wants to hear the candidate
        /// say
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

		// TODO: add FormFlow to ask candidate the question bluntly with
		// several options in case the bot cannot recognize any regexes
		// This should be a last resort, as it will take away the human
		// side of the interview and turn it into a multiple-choise assessment
		// (or short answer). I may not even include this if it turns out
		// that I don't need to.
	}
}