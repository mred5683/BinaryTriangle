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
      var userInputToBinary = new StringBuilder();
      var addSymbolToBeginningOfUserInputToBinary = new StringBuilder();
      var temp1 = 0;
      var temp2 = 1;

      var listOfTriSequence = new List<int>();
      
      //convert userInput to Binary.
      foreach (char ch in userInput) {
        userInputToBinary.Append(Convert.ToString(ch, 2));
      }

      WriteLine(userInputToBinary.Length);
      int lengthOfUserInputToBinary = userInputToBinary.Length;

      //Gets the triangle number sequence. sequence shows how many "characters" total to make a complete triangle.
      //first row has one, second row has 2, third row has three etc....

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
      
      //created a tempUserInputToBinaryLength variable to hold the value of how many characters is needed to fill in
      //the different between listOfTriSequence.Max() and userInputToBinary.Length (if applicable).  in order to make
      //a complete triangle the value needs to equal a value in the triangle number sequence. 
      //example ::  https://en.wikipedia.org/wiki/Triangular_number

      var tempUserInputToBinaryLength = userInputToBinary.Length;

      while (tempUserInputToBinaryLength < listOfTriSequence.Max()) {
        addSymbolToBeginningOfUserInputToBinary.Append("*");
        tempUserInputToBinaryLength += 1;

        if (addSymbolToBeginningOfUserInputToBinary.Length + userInputToBinary.Length == listOfTriSequence.Max()) {
          addSymbolToBeginningOfUserInputToBinary.Append(userInputToBinary);
          break;
        }
      }
      WriteLine(addSymbolToBeginningOfUserInputToBinary.ToString());
      var stringSymbolsAndUserInputToBinary = addSymbolToBeginningOfUserInputToBinary.ToString();
      //foreach (char ch in stringSymbolsAndUserInputToBinary) {
      //  WriteLine(stringSymbolsAndUserInputToBinary);
      //}

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
