using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTriangle {

  class Program {

    public static void Main() {

      WriteLine("Enter a phrase to convert to binary...");
      var userInput = ReadLine();
      var userInputToBinary = new StringBuilder();



      //convert userInput to Binary.
      if (userInput == null) {
        WriteLine("must enter valid text...");
        Main();
      }

      else {
        foreach (var ch in userInput) userInputToBinary.Append(Convert.ToString(ch, 2));
      }

      WriteLine(userInputToBinary.Length);
      int lengthOfUserInputToBinary = userInputToBinary.Length;

      //Gets the triangle number sequence. sequence shows how many "characters" total to make a complete triangle.
      //first row has one, second row has 2, third row has three etc....

      var tempToCreateList1 = 0;
      var tempToCreateList2 = 1;

      var listOfTriSequence = new List<int> {tempToCreateList2};

      while (listOfTriSequence.Max() <= lengthOfUserInputToBinary) {
        var tempToCreateList = tempToCreateList2 - tempToCreateList1;
        while (tempToCreateList1 != tempToCreateList2) {
          tempToCreateList1 += 1;
        }

        while (tempToCreateList + 1 != (tempToCreateList2 - tempToCreateList1)) {
          tempToCreateList2 += 1;
        }

        listOfTriSequence.Add(tempToCreateList2);
      }

      //created a tempUserInputToBinaryLength variable to hold the value of how many characters is needed to fill in
      //the difference between listOfTriSequence.Max() and userInputToBinary.Length (if applicable).  in order to make
      //a 'complete' triangle, the value needs to equal a value in the triangle number sequence. 
      //example ::  https://en.wikipedia.org/wiki/Triangular_number

      var tempUserInputToBinaryLength = userInputToBinary.Length;
      var addSymbolToBeginningOfUserInputToBinary = new StringBuilder();

      while (tempUserInputToBinaryLength < listOfTriSequence.Max()) {
        addSymbolToBeginningOfUserInputToBinary.Append("*");
        tempUserInputToBinaryLength += 1;

        if (addSymbolToBeginningOfUserInputToBinary.Length + userInputToBinary.Length == listOfTriSequence.Max()) {
          addSymbolToBeginningOfUserInputToBinary.Append(userInputToBinary);
          break;
        }
      }

      WriteLine(addSymbolToBeginningOfUserInputToBinary.ToString());
      var appendedSymbolsAndUserInputToBinary = addSymbolToBeginningOfUserInputToBinary.ToString();

      //while (temp < temp1) {
      //  var temp = 0;
      //  var temp1 = 0;
      //  var temp2 = 0;
      //}

      //foreach (char ch in stringSymbolsAndUserInputToBinary) {
      //  WriteLine(stringSymbolsAndUserInputToBinary);
      //}

      ReadKey();
    }


    ////Code for creating a triangle with alternating 0's and 1's
    
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
