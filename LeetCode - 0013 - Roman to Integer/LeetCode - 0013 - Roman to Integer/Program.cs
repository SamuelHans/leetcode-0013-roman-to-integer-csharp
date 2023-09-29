namespace LeetCode___0013___Roman_to_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

            Symbol       Value
            I             1
            V             5
            X             10
            L             50
            C             100
            D             500
            M             1000
            For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. 
            The number 27 is written as XXVII, which is XX + V + II.
            
            Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. 
            Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle 
            applies to the number nine, which is written as IX. There are six instances where subtraction is used:
            
            I can be placed before V (5) and X (10) to make 4 and 9. 
            X can be placed before L (50) and C (100) to make 40 and 90. 
            C can be placed before D (500) and M (1000) to make 400 and 900.
            Given a roman numeral, convert it to an integer.
                        
            Example 1:
            Input: s = "III"
            Output: 3
            Explanation: III = 3.

            Example 2:
            Input: s = "LVIII"
            Output: 58
            Explanation: L = 50, V= 5, III = 3.

            Example 3:
            Input: s = "MCMXCIV"
            Output: 1994
            Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
            
            Constraints:
            1 <= s.length <= 15
            s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
            It is guaranteed that s is a valid roman numeral in the range [1, 3999].

            */

            //var s = "III";
            //var s = "LVIII";
            var s = "MCMXCIV";
            var original = s;

            var thousands = 0;
            var hundreds = 0;
            var tens = 0;
            var ones = 0;

            int integerOfS;

            // Get 1000 digit
            while (s.StartsWith("M"))
            {
                thousands++;
                s = s.Substring(1);
            }

            // Get if 900
            if (s.StartsWith("CM"))
            {
                hundreds = 900;
                s = s.Substring(2);
            }

            // Get if 400
            if (s.StartsWith("CD"))
            {
                hundreds = 400;
                s = s.Substring(2);
            }

            // Get if 500
            if (s.StartsWith("D"))
            {
                hundreds = 500;
                s = s.Substring(1);
            }

            // Get if 100s
            while (s.StartsWith("C"))
            {
                hundreds = hundreds + 100;
                s = s.Substring(1);
            }

            // Get if 90
            if (s.StartsWith("XC"))
            {
                tens = 90;
                s = s.Substring(2);
            }

            // Get if 40
            if (s.StartsWith("XL"))
            {
                tens = 40;
                s = s.Substring(2);
            }

            // Get if 50
            if (s.StartsWith("L"))
            {
                tens = 50;
                s = s.Substring(1);
            }

            // Get if 10s
            while (s.StartsWith("X"))
            {
                tens = tens + 10;
                s = s.Substring(1);
            }

            // Get if 9
            if (s.StartsWith("IX"))
            {
                ones = 9;
                s = s.Substring(2);
            }

            // Get if 4
            if (s.StartsWith("IV"))
            {
                ones = 4;
                s = s.Substring(2);
            }

            // Get if 5
            if (s.StartsWith("V"))
            {
                ones = 5;
                s = s.Substring(1);
            }

            // Get if 1s
            while (s.StartsWith("I"))
            {
                ones = ones + 1;
                s = s.Substring(1);
            }

            integerOfS = thousands * 1000 + hundreds + tens + ones;

            Console.WriteLine("The original roman numeral {0} is as an integer {1}", original, integerOfS);
        }
    }
}