using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Capmon_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> list = new List<string>(ExpandSequences("http://www.someserver.com/doc=[1..200]/text.html")); 

            foreach (string url in list)
            {
                Console.WriteLine(url);
            }

        }

        public static List<String> ExpandSequences(String uri) {

            List<String> theList = new List<string>();

            //Remove the Brackets []
            String strNoBracket = Regex.Replace(uri, "[][']", "");

            for (int i = 1; i < 201; i++)
            {
                //Remove the "1..200"-part of the String and replace with the int.ToString
                String result = Regex.Replace(strNoBracket, "1..200", i.ToString());
                theList.Add(result);
                //Console.WriteLine(result);
            }

            return theList;

        }
    }
}
