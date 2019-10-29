using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int A = 0, B = 100;
            int c = 1;
            while(B > A + 1)
            {
                int C = (A + B) / 2;
                Console.WriteLine("Q{0}: Is your number greater than {1}?", c, C);
                c++;
                answer = Console.ReadLine();
                if (answer == "Y")
                    A = C + 1;
                if (answer == "N")
                    B = C;
            }
            Console.WriteLine("Q{0}: Is your number {1}", c, A);
            answer = Console.ReadLine();
            if (answer == "Y")
                Console.WriteLine("Your number is " + A);
            if (answer == "N")
                Console.WriteLine("Your number is " + B);
        }
    }
}
