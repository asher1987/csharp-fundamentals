namespace MyFirstApplication;

// Exercise 14 Arrays
internal class Exercise14
{

    /*Write a method with no parameters and no return type. Write a 
     single dimensional string array of ice cream flavors. Using a for each 
     loop in your method, print out the results of your array using a 
     Console WriteLine statement.
    */


    public void IceCream() //method
    {
        string[] stringArray = { "Chocolate", "Cookie Dough",
            "Mint", "Vanilla" }; //single dimensional array 

        foreach (string item in stringArray) //foreach loop
        {
            Console.WriteLine(item); //results of array 
        }
    }

    /*Write a method with no parameters and no return type.Write a 
     * two-dimensional array using the int data type. Using the link below, 
     * fill in each dimension with the KC Chiefs Regular season scores. 
     * The first dimensionwill be the home team, while the second dimension 
     * will be the away team. Using a foreach loop, print out the results of 
     * your array using a Console WriteLine statement. To determine whichteam 
     * is home and away, the website includes the link to the box score. The 
     * link label shows both teams. The first team in the label is the away team
    */

    public void FootBall() //method
    {
        int[,] footballScores = new int[,] {{34, 20, 20, 26, 32, 17, 16, 35,
                33, 31, 24, 22, 27, 29, 17, 21 }, {20, 23, 34, 10, 40, 26, 43,
                9, 31, 35, 27, 16, 33, 32,14, 38}}; //home vs. away 
        foreach(int score in footballScores) //foreach 
        {
            Console.WriteLine(score); //results 
        }

    }
}