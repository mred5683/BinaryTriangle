using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTriangle {

  class Program {

    public static void Main() {

      WriteLine("Enter text to convert to binary...");
      var userInput = ReadLine();
      var userInputToBinary = new StringBuilder();

      //check if userInput is null.  if it is, then it prompts the user to enter valid text.  
      //if it isn't, then it converts userInput to Binary.

      if (userInput == null) {
        WriteLine("must enter valid text...");
        Main();
      }

      else {
        foreach (var ch in userInput) userInputToBinary.Append(Convert.ToString(ch, 2));
      }
      
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
      
      var stringSplatAndUserInputToBinary = addSymbolToBeginningOfUserInputToBinary.ToString();
      var DictOfChars = new Dictionary<int,string>();
      var count = 0;

      foreach (char ch in stringSplatAndUserInputToBinary) {
        DictOfChars.Add(count,ch.ToString());
        count += 1;
      }
      
      //number of rows equals listOfTriSequence.Count
      count = 0;
      for (int i = 1; i < listOfTriSequence.Count + 1; i++) {
        for (int j = 0; j < i; j++) {
          Write(DictOfChars[count]);
          DictOfChars.Remove(count);
          count += 1;
        }
        Write("\n");
      }
      ReadKey();
    }
  }
}
