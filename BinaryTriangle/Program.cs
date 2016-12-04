using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTriangle {
  class Program {
    static void Main(string[] args) {
      int p, lastInt = 0, input;
      Console.WriteLine("Enter the Number of Rows : ");
      input = int.Parse(Console.ReadLine());
      for (var i = 1; i <= input; i++) {
        for (p = 1; p <= i; p++)
          if (lastInt == 1) {
            Console.Write("0");
            lastInt = 0;
          }
          else if (lastInt == 0) {
            Console.Write("1");
            lastInt = 1;
          }
        Console.Write("\n");
      }
      Console.ReadLine();
    }
  }
}
