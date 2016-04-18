using System.Collections.Generic;

namespace HireMeBot.InterviewData
{
    /// <summary>
    /// The experience (college courses, places worked) that the employer
    /// wants the interviewee to have
    /// </summary>
    public class Experience
    {
        private IList<string> fields;
        /// <summary>
        /// The fields of study that it would be good for this interviewee to
        /// have experience with
        /// </summary>
        public IList<string> Fields
        {
            get
            {
                return fields;
            }

            set
            {
                fields = value;
            }
        }

        private IList<string> jobs;
        /// <summary>
        /// The previous jobs that it would be good for this interviewee to
        /// have held
        /// </summary>
        public IList<string> Jobs
        {
            get
            {
                return jobs;
            }

            set
            {
                jobs = value;
            }
        }

        private IList<string> companies;
        /// <summary>
        /// The companies that it would be good for this interviewee to
        /// have worked at
        /// </summary>
        public IList<string> Companies
        {
            get
            {
                return companies;
            }

            set
            {
                companies = value;
            }
        }

        private IList<string> collegeExperience;
        /// <summary>
        /// The colleges or courses that this person should have experience
        /// with (//TODO: make a separate list for colleges and for courses)
        /// </summary>
        public IList<string> CollegeExperience
        {
            get
            {
                return collegeExperience;
            }

            set
            {
                collegeExperience = value;
            }
        }
    }
}