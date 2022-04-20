namespace MyFirstApplication;


/*Above the class, write an enum called Favorite Movies. Add your own 
 * favorite movies to the enum. Write a method that has a string return type
 * and an enum parameter. This enum parameter will be your favorite movie enum.
 * Write a switch expression that takes the enum and prints out a string 
 * return. Use string interpolation in your return message that includes 
 * the name of the movie chosen.
 */


public enum favoriteMovies {The_Hangover, Dirty_Dancing, Boss_Baby };//enum

internal class Exercise15
{
    public string AshleyMovies(favoriteMovies movies) //method 
    {
        string message = movies switch //switch expression
        {
            favoriteMovies.The_Hangover => $"My favorite movie is " +
            $"{favoriteMovies.The_Hangover}",
            favoriteMovies.Dirty_Dancing => $"My favorite is " +
            $"{favoriteMovies.Dirty_Dancing}",
            favoriteMovies.Boss_Baby => $"My favorite is " +
            $"{favoriteMovies.Boss_Baby}"
        };
        return message;
    }

    /*Write a method that takes an enum parameter. This enum will be your 
      favorite movie enum. The method will have a tuple return type
     (int num, stringmovie).Using an explicit int cast on one of your enum, 
      assign the value to an int variable. Create a second variable type string. 
      Assign the same enum value you used and use the ToString() at the end  of it. 
      Return both variables as a tuple.
      See examplebelow for clarity
      .a.Int value = (int)Enum.Value;b.string something = Enum.Value.ToString();
    */
    public (int num, string movie) TheMovies(favoriteMovies movies)
    {
        int value = (int)movies;
        string name = movies.ToString();
        return (value, name);
    }


}