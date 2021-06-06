using System;
using System.Text.RegularExpressions;

namespace BasicWebCalculator.Methods
{
    public class Forms
    { 
       public string ValidateName(string givenName)
        {
            string name = givenName;
            if (!Regex.Match(name, "^[A-Z][a-zA-Z]*$").Success)
            {
                throw new Exception("Niepoprawne imie");
            }
            return name;

        }


    }
}
