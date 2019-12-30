using System;

namespace basic
{
    /// <summary>
    /// class to replace a specific word in a sentence
    /// </summary>
    class Replace
    {
        /// <summary>
        /// Replaces the word. 
        /// </summary>this method make use of Replace method present in string class to 
        /// replace the given string with a new string
        /// <param name="name">The name.</param>
        /// <returns>string</returns>
        public void ReplaceWord( )
        {
            string input = "sumit";
            string template = "hello <<username>>,how are you?";

            Console.WriteLine("enter your name : ");

            string name = Utility.Util.ReadString();

            // Replace() method does not modify the value of the current instance. 
            //Instead, it returns a new string in which all occurrences of Oldvalue are replaced by Newvalue
            string newtemplate = template.Replace("<<username>>",input);

            Console.WriteLine(newtemplate);

        }
    }
}
