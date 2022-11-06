using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 3, 5 };

            int[] result1 = (from n in nums select n).ToArray();

            int[] reuslt2 = (from n in nums orderby n descending select n).ToArray();

            int[] result3 = (from n in nums where n > 3 && n < 5 orderby n descending select n).ToArray();

            int result4 = (from n in nums where n == 3 select n).First();

            int result5 = (from n in nums where n == 4 select n).FirstOrDefault();

            int result6 = (from n in nums where n == 3 select n).Single();

            int result7 = (from n in nums where n == 6 select n).SingleOrDefault();

            var i1 = 123;
            var i2 = "Taha";
            var i3 = DateTime.Now;

            bool result8 = (from n in nums where n == 3 select n).Any();

            int Count = (from n in nums select n).Count();

            int Max = (from n in nums select n).Max();

            int Min = (from n in nums select n).Min();

            int Sum = (from n in nums select n).Sum();

            List<string> Names = new List<string>();
            Names.Add("Taha");
            Names.Add("Amin");
            Names.Add("Ghafuri");

            var res1 = (from n in Names select n).ToList();

            var res2 = (from n in Names where n.ToLower().Contains("i") select n).ToList();

            var res3 = (from n in Names where n.ToLower().StartsWith("i") select n).ToList();

            var res4 = (from n in Names where n.ToLower().EndsWith("i") select n).ToList();
        }
    }
}
