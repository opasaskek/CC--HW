using System;

public class Numbers {
    private static void Main() {
        Console.WriteLine("Enter a three-digit number: " );
        int number = int.Parse(Console.ReadLine());
          char[] digits = number.ToString().ToCharArray();

        Array.Sort(digits);
        Array.Reverse(digits);
        string sortedNumber = new string(digits);
        
        int result = int.Parse(sortedNumber);
        Console.WriteLine("Max digit: " + result);
    }
}

        