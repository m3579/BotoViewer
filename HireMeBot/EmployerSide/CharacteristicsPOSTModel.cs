using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HireMeBot.EmployerSide
{
    /// <summary>
    /// The object that the JSON of the characteristics the employer web portal
    /// sends (the ones that the employer has selected to look for during
    /// the interview) will be deserialized into
    /// </summary>
    public class CharacteristicsPOSTModel
    {
        public IList<string> characteristics;
    }
}