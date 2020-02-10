using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq_Problems lq = new Linq_Problems();

            var result = lq.ProblemOne(new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" });                     
            result.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            result = lq.ProblemTwo(new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" });
            result.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();


            var result2 = lq.ProblemThree(new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" });
            Console.WriteLine(result2);
            Console.WriteLine();


            Console.WriteLine(lq.ProblemFour("Terrill"));

            Console.ReadLine();

        }
    }
}
