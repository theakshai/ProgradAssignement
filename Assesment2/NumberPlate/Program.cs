using System;

namespace NumberPlate;

public class NumberPlateGroupingService{

  protected static string NumberPlateString;
  protected static int GroupLimit;

  static void Main(String[] args){
    GettingData();
    Console.WriteLine(GroupingString(NumberPlateString, GroupLimit));
  }

  static void GettingData(){

    Console.WriteLine("Enter the Number Plate String:");
    NumberPlateString = Console.ReadLine();


      Console.WriteLine("Enter the Group Limit to be Seperated:");
      GroupLimit = Convert.ToInt32(Console.ReadLine());

  }

  static string GroupingString(string numberPlateString, int groupLimit){
    string SanitizingString = new string(numberPlateString.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToUpper();


    List<string> ModifiedString = new List<string>();
    int i = SanitizingString.Length;
    while (i > 0) {
      int Length = Math.Min(groupLimit, i);
      ModifiedString.Add(SanitizingString.Substring(i - Length,Length));
      i -= Length;
    }
    ModifiedString.Reverse();
    
    return string.Join("-", ModifiedString);
  } 
}
