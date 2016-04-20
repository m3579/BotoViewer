using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HireMeBot.EmployerSide
{
    public class EmployerPortalFunctions
    {
        [WebMethod]
        public static bool SetQuestions(string question)
        {
            Debug.WriteLine("Hello");
            return false;
        }

        [WebMethod]
        public static IList<string> GetCharacteristics()
        {
            return new List<string> { "calm", "mean" };
        }
    }
}