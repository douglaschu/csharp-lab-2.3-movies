using System.Linq;
using movies_database;
using CircleLab;

List<Movie> movies = new List<Movie>
{
    new Movie("The Banshees of Inisherin", "Drama"),
    new Movie("The Lego Movie", "Animated"),
    new Movie("Barbie", "Comedy", 2023, 114),
    new Movie("Infernal Affairs", "Action"),
    new Movie("Young Frankenstein", "Comedy"),
    new Movie("Weird: The Al Yankovic Story", "Comedy"),
    new Movie("Everything Everywhere All At Once", "Action", 2022, 139),
    new Movie("Stop Making Sense", "Documentary"),
    new Movie("The Lincoln Lawyer", "Drama"),
    new Movie("In The Mood for Love", "Drama")
};


//start

bool runProgram = true;
while (runProgram)
{
    //Displaying list of categories
    //Complicated linq method to display simple result
        //1. sort categories into groups based on category with GroupBy
        //2. go through groups, puabll first movie from each group.
        //3. create list of first movies in list with distinct categories
        //3. display just the categories from that list of unique movies
        //4. thus we can give the user a list of all categories


    //List<Movie> DistinctCategories = movies
    //    .GroupBy(m => m.Category.ToLower().Trim())
    //    .Select(m => m.First()).ToList();

    //for (int i = 0; i < DistinctCategories.Count(); i++)
    //{
    //    Console.WriteLine($"{i}. {DistinctCategories[i].Category}");
    //}

    //Ethan's simplifed linq  method
    List<string> categories = movies.Select(c => c.Category).Distinct().ToList();
    for (int i = 0; i < categories.Count(); i++)
    {
        Console.WriteLine($"{i}. {categories[i].Category}");
    }



    //Create one list for category property
    //linq will sort categories so there's only one movie per category
    //

    //manual implementation
    //Console.WriteLine("1. Action");
    //Console.WriteLine("2. Comedy");
    //Console.WriteLine("3. Documentary");
    //Console.WriteLine("4. Drama");
    //int menuChoice = Validator.GetPositiveInputInt();
    //string category = "";
    Console.WriteLine("Please enter a category.");
    string category = (Console.ReadLine()).Trim().ToLower();

    //Get categories
        //Use WHERE
    List<Movie> searchResults = movies.Where(m => m.Category.Trim().ToLower() == category).ToList();

    //
    //LINQ step 1:
        //List<Movie> searchResults = movies.Where(m => m.Category == category);
    //Store linq in a list step 2:
        //List<Movie> searchResults = movies.Where(m => m.Category == category).ToList;
    //Clean the string engry
    //List<Movie

    //display movies
        //with foreach loop
        //plain foreach loop: foreach (Movie m in searchResults)
    foreach (Movie m in searchResults.OrderBy(m => m.Title))
    {
        if (m.YearReleased == 0)
        {
            Console.WriteLine($"{m.Title}. Category: {m.Category}");
        }
        else
        {
            Console.WriteLine($"{m.Title}. Category: {m.Category}. Year: {m.YearReleased}. Runtime: {m.Runtime} minutes.");
        }
        
    }

    runProgram = Validator.GetContinue();
}

//attempt at using shopping cart lab search
//if (movies.Any(n => n.ToLower().Trim().Category.Contains(category)))
//{
//    string result = movies.FirstOrDefault(n => n.Category.Contains(category).Trim());

//}

//omar's method
//foreach(Movie m in movies)
//{
//    DisplayMovieDetails(m);
//}


//Console.WriteLine("Category pull test");

//static void DisplayMovieDetails(Movie inputMovie)
//{
//    Console.WriteLine($"{inputMovie.Title}: {inputMovie.Category}");
//}


//static void DisplayCategory(Movie inputCategory)
//{
//    Console.WriteLine($"[inputMovie.Category");
//}

//Console.WriteLine(movies);