using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominion_of_Kings
{
    public class Program
{
    static void Main(string[] args)
    { 
        //Change the window title
        Console.Title = "Defense of Consolas";

        //ask user for variables and assign them
        Console.WriteLine("Enter target row");
        int row = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter target column");
        int column = int.Parse(Console.ReadLine());



        //Calculate squad positions
        int topMan = row + 1;
        int eastMan = column + 1;
        int bottomMan = row - 1;
        int westMan = column - 1;

        //Convert variables to strings to be used in writing results to console
        string topManpos = topMan.ToString();
        string eastManPos = eastMan.ToString();
        string bottomManpos = bottomMan.ToString();
        string westManpos = westMan.ToString();


        //change color of text
        Console.ForegroundColor = ConsoleColor.Blue;

        //write results to console
        Console.WriteLine("deploy squad to:");
        Console.WriteLine(topManpos, column);
        Console.WriteLine(row, eastManPos);
        Console.WriteLine(bottomManpos, column);
        Console.WriteLine(row, westManpos);
        //this works because you only need to change 1 variable to move 1 square away from the protected square
        //make a beep
        Console.Beep();

    }
}
}