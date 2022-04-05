//Modifier returnValueType methodName(list of parameters) {
// method body;
//}


// This is Lesson 1- Exercise Lab-Value Types


//Write out a method with no arguments and a void return type that will print
//the output of the number 35 based on the number systems below.The values should
//be assigned to a variable inside the method prior to printing them using
//Console WriteLine.Utilize the conversion document from your resources.

//a.Decimal
//b.Hexadecimal
//c.Binary


namespace myfirstapplication;

public class Exercise1
{
    public void Question1()
    {
        int valuea = 35;
        int valueb = 0b100011;
        int valuec = 0x23a;
        Console.WriteLine(valuea);
        Console.WriteLine(valueb);
        Console.WriteLine(valuec);
    }

    //Write a method that will accept 3 argument parametersand a void return type.
    //The first argument should be of type byte. The second argument should
    //be of type short. The third argument should be of type int. Using Implicit
    //conversion, create variables to convert to using the below information.
    //Use the argument paramaters as the values to convert from. Print each line

    public void Question2(int myInt, byte myByte, short myShort)
    {
        int converted = myByte;
        Console.WriteLine(converted);

      
        long converted2 = myShort;
        Console.WriteLine(converted2);

        
        float converted3 = myInt;
        Console.WriteLine(converted3);

    }

    //Write a method that will accept 3 argument parameters and a void return
    //type. The first argument should be of type double. The second argument
    // should be of type float. The third argument should be type long.
    //Using explicit conversion, create variables to convert to using the below
    //information. Use the argument parameters as the values to convert from.
    //Print each line. 

    public void Question3(double ExDouble, float ExFloat, long ExLong)
    {
        //  double to long
        long converted4 = (long)ExDouble;
        Console.WriteLine(converted4);
        // float to int
        int converted5 = (int)ExFloat;
        Console.WriteLine(converted5);
        // long to short
        short converted6 = (short)ExLong;
        Console.WriteLine(converted6);

    }

    //Write a method with no arguments and a void return type. Using the values
    //assign them to a variable that best suits their value type. Utilize the
    //digit separator when assigning them to your variables. Once you have
    //defined your variables, print each line. 

    float aFloat = 123456.987F;
    int bInt = -9516248;
    short cShort = 3500;
    long dLong = 988562486L;
    double eDouble = -19733.14895D;



    public void Problem4()
    {
        Console.WriteLine(aFloat);
        Console.WriteLine(bInt);
        Console.WriteLine(cShort);
        Console.WriteLine(dLong);
        Console.WriteLine(eDouble);
    }

}