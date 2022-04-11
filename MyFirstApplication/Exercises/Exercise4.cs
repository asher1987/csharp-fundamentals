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


    public void Question2(char arg1)
    {
        switch (arg1)
        {
            case 'E':
                Console.WriteLine("Excellent");
                break;

            case 'V':
                Console.Write("Very Good");
                break;
            case 'G':
                Console.WriteLine("Good");
                break;
            case 'A':
                Console.WriteLine("Average");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Not a valid grade.");
                break;
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
 
    
    