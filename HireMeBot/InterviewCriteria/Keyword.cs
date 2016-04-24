using System;
using System.Collections.Generic;

namespace HireMeBot.InterviewCriteria
{
    /// <summary>
    /// A word that the employer thinks is good if the interviewee uses
    /// </summary>
    public class Keyword
    {
        private string keywordString;
        /// <summary>
        /// The text of the keyword
        /// </summary>
        public string KeywordString
        {
            get
            {
                return keywordString;
            }

            set
            {
                keywordString = value;
            }
        }

        /// <summary>
        /// Returns any synonyms for this keyword via a REST API call to
        /// an online dictionary API (// TODO: which I will decide on later)
        /// </summary>
        /// <returns>The synonyms for this keyword</returns>
        public IList<string> GetSynonyms()
        {
            throw new NotImplementedException();
        }
    }
}