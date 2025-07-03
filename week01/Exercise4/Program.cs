using System;

class Program
{
    static void Main(string[] args) 
    {

        List<int> numbers = new List<int>();
        int num;
        int sum = 0;
        
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do{
            Console.WriteLine("Enter Number:");
                        string num_str = Console.ReadLine();
                        num = int.Parse(num_str);
                        if(num > 0)
                        {
                            numbers.Add(num);
                        }
                        
        }while(num != 0);
    

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        float average = ((float)sum) / numbers.Count;
        
        foreach (int number in numbers)
        {
            if(number > largest)
            {
                largest = number;
            }
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}