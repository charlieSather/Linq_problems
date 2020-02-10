using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Linq_Problems
    {
        public List<string> ProblemOne(List<string> strings)
        {
            return strings.Where(x => x.Contains("th")).ToList();
        }

        public List<string> ProblemTwo(List<string> strings)
        {
            return strings.Distinct().ToList();
        }

        public double ProblemThree(List<string> grades)
        {
            return grades.Select(x => x.Split(',')).Select(x => x.Select(y => double.Parse(y)).OrderBy(z => z).Skip(1)).SelectMany(x => x).Average();
        }

        public string ProblemFour(string letters)
        {
            string LETTERS = letters.ToUpper();
            //return new string(letters.ToUpper().OrderBy(c => c).Distinct().Select(x => $"{x}{letters.ToUpper().Count(y => y == x)}").SelectMany(x => x.ToCharArray()).ToArray());  
            return string.Join("", LETTERS.OrderBy(c => c).Distinct().Select(x => $"{x}{LETTERS.Count(y => y == x)}"));  
        }
    }
}
