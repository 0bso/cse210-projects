using System;

class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine("What is your grade percentage?");
        string grade_string = Console.ReadLine();
        int grade_int = int.Parse(grade_string);
        string letter_grade;
        string pass_fail;

        if (grade_int >= 90){
            letter_grade = "A";
        }
        else if (grade_int >= 80){
            letter_grade = "B";
        }
        else if (grade_int >= 70){
            letter_grade = "C";
        }
        else if (grade_int >= 60){
            letter_grade = "D";
        }
        else{
            letter_grade = "F";
        }

        if(grade_int >= 70){
            pass_fail = "Congratulations! Your Passed!";
        }
        else{
            pass_fail = "You did not Pass. Keep studying and try again.";
        }


        Console.WriteLine($"Your letter grade is {letter_grade}");
        Console.WriteLine($"{pass_fail}");

    }
}