using System.Collections.Generic;
using System.Linq;


class Program
{
    private static string[] input = new string[] {"Moscow", "123", "abcd", "-1", "234", "Berlin"};

    public static void Main()
    {

        var output = new List<string>();

        for (var i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                output.Add(input[i]);
            }
        }

        var result = output.ToArray();

        Console.WriteLine("Results: ");
        Console.WriteLine(string.Join(' ', result));
    }
}
