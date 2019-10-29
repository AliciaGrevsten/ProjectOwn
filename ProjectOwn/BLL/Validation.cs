using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectOwn
{
    /*  What needs to be validated:
     *      URL
     *      Only characters (for the Category)
     *      If Category already exist (?)
     *      If URL already exist (?)
     */
    public class Validation
    {
        public static bool CharacterInputValidation(string input)
        {
            if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CharacterInputLengthValidation(string input)
        {
            if (Regex.IsMatch(input, @"^[a-zA-Z]{3,}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool URLInputValidation(string url)
        {
            if (Regex.IsMatch(url, @"(?i)(http(s)?:\/\/)?(\w{2,25}\.)+\w{3}([a-z0-9\-?=$-_.+!*()]+)(?i)"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CategoryExistValidation (string category)
        {
            //  Check the file with the category-list if the category already exist in that file.
            return false;
        }

        public static bool URLExistValidation(string category)
        {
            //  Check the file with the podcast-list if the url already exist in that file.
            return false;
        }
    }

    

}
