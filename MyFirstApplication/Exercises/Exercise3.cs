namespace MyFirstApplication;

public class Exercise3
{
    // Question 1
    //Write a method that takes 1 int argument and an int return type.
    // Utilize the modulus operator to complete this task.
    //Assign the data values to their own variables.
    //Use the console.writeline statement on the first 4 variables and
    //calculate the modulus with the passed in argument parameter.
    //Using the last variable below, calculate the modulus with the passed
    //argument parameter and return it.

    public int Question1(int arg)
    {
        int myARg = arg;
        int arg1 = 15;
        int arg2 = 456;
        int arg3 = 23;
        int arg4 = 89;
        int arg5 = 245;
        Console.WriteLine(arg1 % myARg);
        Console.WriteLine(arg2 % myARg);
        Console.WriteLine(arg3 % myARg);
        Console.WriteLine(arg4 % myARg);
        return arg5 % myARg;
    }

    // Question 2
    //Write a method that takes no arguments and a void return type.
    //Utilizing the math problem in this task, fill in any missing pieces
    //to get the output 10+32*12/3. Write to console

    public void Question2()
    {
        int a = 10;
        int b = 32;
        int c = 12;
        int d = 3;
        Console.WriteLine(a + b * c / d); //138
        Console.WriteLine((a + b) * c / d); // 168
        Console.WriteLine((a + b * c)/ d); // 131
    }

    //Question 3
    // Write a method that takes two short type operators
    // and a void return type. Using the compound assignment operators
    // use the first argument parameter as the left operand to get the result
    //Print each one
    // +=, /=, *=, %=

    public void Question3(short arg1, short arg2)
    {
        arg1 += arg2;
        Console.WriteLine(arg1);

        arg1 /= arg2;
        Console.WriteLine(arg1);

        arg1 *= arg2;
        Console.WriteLine(arg1);

        arg1 %= arg2;
        Console.WriteLine(arg1);
    }
    // Question 4
//Write a method that takes two bool type argumentsand a voidreturn type.
//Using Boolean Logical operators&, |, ^, and ||to complete this task.
//Use a Console WriteLinestatementtocalculate eachresultusing the operators.
//The second argument is the left operand.Use the below values when testing
//your method.Using comments, provide your output resultsinside the method
//after your statements
// a. arg1 = true arg2= false
//b. arg1 = false arg2 = false
//c. arg1 = true arg2 = true
//d. arg1 = false arg2 = true
public void Question4(bool arg1, bool arg2)
    {
        Console.WriteLine(arg2 & arg1);
        Console.WriteLine(arg2 | arg1);
        Console.WriteLine(arg2 ^ arg1);
        Console.WriteLine(arg2 || arg1);


    }


  

}










