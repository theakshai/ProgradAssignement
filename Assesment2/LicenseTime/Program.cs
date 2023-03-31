using System;
namespace License;
class TimeAllocation
{
  protected static string Name;
  protected static int Agents;
  protected static string NameList;

    static void Main(string[] args)
    {

      Console.WriteLine("Enter Your Name: ");
      Name = Console.ReadLine();
      

        Console.WriteLine("Enter the number of Agents Available: ");
        Agents = Convert.ToInt32(Console.ReadLine());

    

      Console.WriteLine("Enter the Other People names with separated spaces: ");
      NameList = Console.ReadLine();
      int minutes = License(Name, Agents, NameList);
      Console.WriteLine(minutes);
    }

    static int License(string name, int agents, string nameList)
    {
      string[] names = nameList.Split(' ');
      List<string> AllWaitingPeople = new List<string>(); 
      foreach(string s in names){
        AllWaitingPeople.Add(s);
      }

      AllWaitingPeople.Add(name);
      AllWaitingPeople.Sort();
      int PeopleAhead = AllWaitingPeople.FindIndex( s => s.StartsWith($"{name}"));
      int numAgentsWorking = Math.Min(agents, PeopleAhead);
      int minutes = PeopleAhead * 20 / numAgentsWorking;

      return minutes;
    }
}
