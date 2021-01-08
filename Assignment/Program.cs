using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        // List to hold information entered by user
        List<string> list = new List<string>();

        // prompt and allow the user to input information
        Console.Write("Enter First Name: ");
        list.Add(Console.ReadLine());
        Console.Write("Enter Last Name: ");
        list.Add(Console.ReadLine());
        Console.Write("Enter Street: ");
        list.Add(Console.ReadLine());
        Console.Write("Enter City: ");
        list.Add(Console.ReadLine());
        Console.Write("Enter State: ");
        list.Add(Console.ReadLine());
        Console.Write("Enter Zip Code: ");
        list.Add(Console.ReadLine());


        // Linq statement to select all values in the list and convert the first letter of every word to uppercase
        var userInformation =
            from item in list
            let uppercaseString = UppercaseWords(item)
            select uppercaseString;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Customer's Information:");
        // foreach loop to cycle through and display the user-entered information
        foreach (var item in userInformation)
            Console.WriteLine("{0}", item);

    }
    // Method to convert the first letter of each word to uppercase 
    public static string UppercaseWords(string value)
    {
        char[] array = value.ToCharArray();

        if (array.Length >= 1)
        {
            if (char.IsLower(array[0]))
            {
                array[0] = char.ToUpper(array[0]);
            }
        }

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == ' ')
            {
                if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
        }
        return new string(array);
    }
}

