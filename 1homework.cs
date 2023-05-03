using System;

public class Program {
    private static void Main() {
        Console.WriteLine("Enter how much the notebook costs:");
        int notebookCost = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter how many notebooks:");
       int notebookCount = int.Parse(Console.ReadLine());

         Console.WriteLine("Enter how much the pen costs:");
        int penCost = int.Parse(Console.ReadLine());
       Console.WriteLine("Enter how many pens:");
       int penCount = int.Parse(Console.ReadLine());

       int totalSum = (notebookCost * notebookCount) + (penCost * penCount);
Console.WriteLine("the total cost is " + totalSum);

    }
}