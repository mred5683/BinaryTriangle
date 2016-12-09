using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTriangle {

  class Program {

    private static void Main(string[] args) {

      WriteLine("Enter a phrase to convert to binary...");
      var userInput = ReadLine();
      var triangleBaseLength = int.MinValue;
      var userInputToBinary = new StringBuilder();
      var temp1 = 0;
      var temp2 = 1;

      var listOfTriSequence = new List<int>();
      
      //convert userInput to Binary.
      foreach (char ch in userInput) {
        userInputToBinary.Append(Convert.ToString(ch, 2));
      }

      WriteLine(userInputToBinary.Length);
      int lengthOfUserInputToBinary = userInputToBinary.Length;

      listOfTriSequence.Add(temp2);
      while (listOfTriSequence.Max() <= lengthOfUserInputToBinary) {
        var temp = temp2 - temp1;
        while (temp1 != temp2) {
          temp1 += 1;
        }

        while (temp + 1 != (temp2 - temp1)) {
          temp2 += 1;
        }
        listOfTriSequence.Add(temp2);
      }

      var maxSequenceValue = listOfTriSequence.Max();

      while (lengthOfUserInputToBinary != maxSequenceValue) {
        lengthOfUserInputToBinary += 1;
      }

      for (int i = 0; i < listOfTriSequence.Max(); i++) {

      }

      ReadKey();
    }

    //int p, lastInt = 0, input;
    //WriteLine("Enter the Number of Rows : ");
    //input = int.Parse(ReadLine());
    //for (var i = 1; i <= input; i++) {
    //  for (p = 1; p <= i; p++)
    //    if (lastInt == 1) {
    //      Write("0");
    //      lastInt = 0;
    //    }
    //    else if (lastInt == 0) {
    //      Write("1");
    //      lastInt = 1;
    //    }

    //  Write("\n");
    //}

    //ReadLine();

  }

}
