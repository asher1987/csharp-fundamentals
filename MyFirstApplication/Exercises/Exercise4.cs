namespace MyFirstApplication;


//Write a method that takes 2 string arguments and a void return type.
//Using and if-else statement, compare the two strings to each other.
//Using a Console WriteLine statement, print out the results of whether
//the strings are equal. Provide a comment inside the method that says
//what strings you used during testing
public class Exercise4
{



    public void Question1(string arg1, string arg2)
    {
        if (arg1 == arg2)
        {
            Console.WriteLine("The arguments are equivalent.");
        }
        else
        {
            Console.Write("The arguments are not equivalent.");
        }

    }


    //Write a method that will take 1 char argument and a string return type.
    //Using a switch and the table below, return the description. If the value
    //does not match the grade, return the default message, “Not a valid grade”


    public string Question2(char arg1)
    {
        switch (arg1)
        {
            case 'E':
                return"Excellent";

            case 'V':
                return "Very Good";
            case 'G':
                return"Good";
            case 'A':
                return "Average";
            case 'F':
                return"Fail";
            default:
                return"Not a valid grade.";
                
        }



    }

    //Write a method that takes no argumentsand a void return type.
    //Using an iteration statement, display all the numbers divisible
    //by 3 from 0 to 30. Utilize a modulus to obtain your results.

    public void Question3()
    {
        for (int i = 0; i <= 30; i++)
        {
            if ((i % 3) == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
 
    
    