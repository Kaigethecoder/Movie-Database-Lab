using System.Linq;
using System;
public class MyProgram
{
    public static void Main(string[] args)
    {
        // Movie Database Lab-List Movies by category
        //store a list of 10 movies and display them by category
        //user can enter categories: animated, drama, horror, scifi to display those movies in list
        //after displayed, user is asked if he or she wants to continue, if no, end program.

        //Build Specs: 1) movie class with 2 properties: title and category.  Both of these properties should be strings.
        //also provide constructor that accepts a title and category as parameters and uses the values passed in to intialize the properties
        //a. class has properties of correct type. 2 points. b. class has constructor-1 point
        //2.in main, creat list<movie> and store at least 10 movies there.  you can use literals to construct the movies. 
        //a. program constructs list properly-1 point. b. program puts at least 10 properly instantiated Movies into the List-1 point
        //3. when user enters category, program should read through all movies in the List and display a line for any movie
        //whose category matches the category entered. a. takes input correctly -1point. b. gives feedback if invalid-1 point
        //c. iterates through list validly-1point d. only outputs if movie matches category-1 point
        //4. loops if user wants to continue. a. back to category again based on user input-1 point

       List<Movies> moviesList = new List<Movies>();
        moviesList.Add(new Movies("Animated", "Shrek"));
        moviesList.Add(new Movies("Animated", "Shrek 2"));
        moviesList.Add(new Movies("Animated", "Shrek The Third"));
        moviesList.Add(new Movies("Drama", "Pulp Fiction"));
        moviesList.Add(new Movies("Drama", "Django Unchained"));
        moviesList.Add(new Movies("Horror", "It"));
        moviesList.Add(new Movies("Horror", "Friday The 13th"));
        moviesList.Add(new Movies("Horror", "Purge"));
        moviesList.Add(new Movies("Sci-Fi", "Mr.Nobody"));
        moviesList.Add(new Movies("Sci-Fi", "Cloud Atlas"));

        bool search = true;
        bool anotherOne = true;
        var catAnimated = moviesList.Where(x => x.category == "Animated").ToList();
        var catDrama = moviesList.Where(x => x.category == "Drama").ToList();
        var catHorror = moviesList.Where(x => x.category == "Horror").ToList();
        var catSciFi = moviesList.Where(x => x.category == "Sci-Fi").ToList();

        
        
        Console.WriteLine("Hello.  Welcome to the movie database!");
        do
        {
            do
            {

                Console.WriteLine("Please enter a category of movies you wish to look at.");
                string category = Console.ReadLine();

                if (category == "Animated")
                {
                    Console.WriteLine("Here are the Animated Movies:");
                    foreach (var catSearch in catAnimated)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                    search = false;
                }
                else if (category == "Drama")
                {
                    Console.WriteLine("Here are the Drama Movies:");
                    foreach (var catSearch in catDrama)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                    search = false;
                }
                else if (category == "Horror")
                {
                    Console.WriteLine("Here are the Horror Movies:");
                    foreach (var catSearch in catHorror)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                    search = false;
                }
                else if (category == "Sci-Fi")
                {
                    Console.WriteLine("Here are the Sci-Fi Movies:");
                    foreach (var catSearch in catSciFi)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                    search = false;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid category.  Your choices are: Animated, Drama, Horror, or Sci-Fi.  Please check spelling and capitalization.");
                    search = true;
                }
            } while (search);

            Console.WriteLine("Would you like to search another category?  Y/N");
            string choice = Console.ReadLine();

            if (choice == "Y" || choice == "y")
            {
                Console.WriteLine("Sounds good.");
                anotherOne = true;
            }
            else if (choice == "N" || choice == "n")
            {
                anotherOne = false;
                Console.WriteLine("Have a great day!");
            }
        } while (anotherOne);
    }
}
public class Movies
{
    public string title;
    public string category;

    public Movies(string newCategory, string newTitle)
    {
        title = newTitle;
        category = newCategory;
    }
}