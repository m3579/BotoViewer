using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HireMeBot.InterviewData;

namespace HireMeBot.EmployerSide
{
    public class EmployerData
    {
        public IList<Question> Questions;
        public IList<Characteristic> Characteristics;
        public IList<Keyword> Keywords;
        public IList<Experience> Experience;
    }
}