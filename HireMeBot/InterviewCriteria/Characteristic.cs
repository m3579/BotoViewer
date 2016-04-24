using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace HireMeBot.InterviewCriteria
{
    /// <summary>
    /// Qualities that the employer wants in the interviewee.
    /// Taken from http://ideonomy.mit.edu/essays/traits.html
    /// </summary>
    public class Characteristic
    {
        private string characteristicString;
        /// <summary>
        /// A string representing the characteristic
        /// </summary>
        public string CharacteristicString
        {
            get
            {
                return characteristicString;
            }

            set
            {
                characteristicString = value;
            }
        }

        /// <summary>
        /// Creates a new Characteristic object
        /// </summary>
        public Characteristic() : this("")
        {

        }

        /// <summary>
        /// Creates a new Characteristic object
        /// </summary>
        /// <param name="characteristic">The string name of the characteristic
        /// that the employer will specify in the employer web portal</param>
        public Characteristic(string characteristic)
        {
            this.characteristicString = characteristic;
        }

        /// <summary>
        /// Gets the list of characteristics that are stored
        /// in the server. These are the characteristics that the employer
        /// selects that they want in a candidate in the employer web portal.
        /// </summary>
        /// <returns>A list of strings representing characteristics that the server
        /// contains and will use in processing interview
        /// answers</returns>
        public static IList<string> GetCharacteristics()
        {
            IList<string> characteristics = new List<string>();

            // Put this in a database in the future, maybe
            StreamReader fileReader = new StreamReader("C:\\Users\\Mihir Kasmalkar\\Documents\\Visual Studio 2015\\Projects\\HireMeBot\\HireMeBot\\InterviewData\\Characteristics.txt");

            string line;
            while ((line = fileReader.ReadLine()) != null)
            {
                characteristics.Add(line);
            }

            fileReader.Close();

            return characteristics;
        }
    }
}