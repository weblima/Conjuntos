using System;
using System.Collections.Generic;
using Conjuntos.Entities;

namespace Conjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<Students> set = new HashSet<Students>();

            string[] courses = new string[3] { "A", "B", "C" };

            foreach (string course in courses) {
                Console.Write($"How many students for course {course}? ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++) {
                    
                    int usuario = int.Parse(Console.ReadLine());

                    set.Add(new Students {Course=course,Usuario=usuario});
                }
            }
            Console.WriteLine("Total students: " + set.Count);
        }
    }
}
