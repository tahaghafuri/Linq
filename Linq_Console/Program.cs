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
            var lambda1 = nums.ToArray();

            int[] reuslt2 = (from n in nums orderby n descending select n).ToArray();
            var lambda2 = nums.OrderByDescending(n => n).ToArray();

            int[] result3 = (from n in nums where n > 3 && n < 5 orderby n descending select n).ToArray();
            var lambda3 = nums.Where(n => n > 3 && n < 5).OrderByDescending(n => n).ToArray();

            int result4 = (from n in nums where n == 3 select n).First();
            var lambda4 = nums.First(n => n == 3);

            int result5 = (from n in nums where n == 4 select n).FirstOrDefault();
            var lambda5 = nums.FirstOrDefault(n => n == 4);

            int result6 = (from n in nums where n == 3 select n).Single();
            var lambda6 = nums.Single(n => n == 3);

            int result7 = (from n in nums where n == 6 select n).SingleOrDefault();
            var lambda7 = nums.SingleOrDefault(n => n == 6);

            var i1 = 123;
            var i2 = "Taha";
            var i3 = DateTime.Now;

            bool result8 = (from n in nums where n == 3 select n).Any();
            var lambda8 = nums.Any(n => n == 3);

            int Count = (from n in nums select n).Count();
            var count = nums.Count();

            int Max = (from n in nums select n).Max();
            var max = nums.Max();

            int Min = (from n in nums select n).Min();
            var min = nums.Min();

            int Sum = (from n in nums select n).Sum();
            var sum = nums.Sum();

            List<string> Names = new List<string>();
            Names.Add("Taha");
            Names.Add("Amin");
            Names.Add("Ghafuri");

            var res1 = (from n in Names select n).ToList();
            var lam1 = Names.ToList();

            var res2 = (from n in Names where n.ToLower().Contains("i") select n).ToList();
            var lam2 = Names.Where(n => n.ToLower().Contains("i")).ToList();

            var res3 = (from n in Names where n.ToLower().StartsWith("i") select n).ToList();
            var lam3 = Names.Where(n => n.ToLower().StartsWith("i")).ToList();

            var res4 = (from n in Names where n.ToLower().EndsWith("i") select n).ToList();
            var lam4 = Names.Where(n => n.ToLower().EndsWith("i")).ToList();
        }
    }
}
