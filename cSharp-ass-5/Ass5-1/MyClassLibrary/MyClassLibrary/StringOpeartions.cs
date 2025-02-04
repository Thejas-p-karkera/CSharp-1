using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLibrary
{
    public class StringOpeartions
    {
        public string ReplaceSpaces(string s)
        {
            Console.WriteLine("Replacing spaces with hyphens.");
            return s.Replace(' ', '-');
        }
        public string RemoveSpaces(string s)
        {
            string temp = "";
            int i;
            Console.WriteLine("Removing spaces.");
            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ') temp += s[i];
            return temp;
        }
        public string Reverse(string s)
        {
            string temp = "";
            int i, j;
            Console.WriteLine("Reversing string.");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                temp += s[i];
            return temp;
        }
        public virtual string Palindrome(string s)
        {
            string str = Reverse(s);
            if (str == s)
                return String.Format("String {0} is Palindrome", s);
            else
                return String.Format("String {0} is not Palindrome", s);
        }

    }
    public class AdvancedStringOperations : StringOpeartions
    {
        public void EMailIDValidation()
        {
            string email = "";
            string subemail = "";
            Console.Write("Enter your e-mail address:");
            email = Console.ReadLine();
            int pos = email.IndexOf('@');

            if (pos != -1)
                subemail = email.Substring(email.IndexOf('@'));
            if (subemail.IndexOf('.') != -1)
                Console.WriteLine("Valid e-maild address!");

            else Console.WriteLine("Invalid e-mail address!");
        }
    }
}
