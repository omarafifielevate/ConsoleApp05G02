using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp05G02
{
    internal class Student
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public Course Course { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hi I'm Student {Name}");
        }

    }
}
