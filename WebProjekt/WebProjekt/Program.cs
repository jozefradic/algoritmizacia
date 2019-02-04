using System;
using System.Text;

namespace WebProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            var whole = Add("158571215196947729068702741797592250102411516099601255153352876341491148382282186537728572579444990915305314413058880931341342280820095989619752421078253137964566924772331382709378742145406162104998557",
"58571215196947729068702741797592250102411516099601255153352876341491148382282186537728572579444990915305314413058880931341342280820095989619752421078253137964566924772331382709378742145406162104998557");

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < whole.Length; i++)
            {
                if (i % 3 == 0)
                    sb.Append(' ');
                sb.Append(whole[i]);
            }


            string formatted = sb.ToString();
        
            Console.WriteLine(formatted);

            Console.ReadKey();
        }

            public static string Add(string s1, string s2)
            {
                bool prenasac = false;
                string result = string.Empty;

                if (s1.Length < s2.Length)
                    s1 = s1.PadLeft(s2.Length, '0');
                if (s2.Length < s1.Length)
                    s2 = s2.PadLeft(s1.Length, '0');

                for (int i = s1.Length - 1; i >= 0; i--)
                {
                    var scitanec = Convert.ToInt64(s1.Substring(i, 1));
                    var scitetel = Convert.ToInt64(s2.Substring(i, 1));
                    var sum = scitanec + scitetel;
                    sum += (prenasac ? 1 : 0);
                    prenasac = false;
                    if (sum > 9)
                    {
                        prenasac = true;
                        sum -= 10;
                    }
                    result = sum.ToString() + result;
                }
                if (prenasac)
                {
                    result = "1" + result;
                }

                return result;
            }       



        
    }
}
