using movies_database;

List<Movie> movies = new List<Movie>
{
    new Movie("The Banshees of Inisherin", "Drama"),
    new Movie("The Lego Movie", "Animated"),
    new Movie("Barbie", "Comedy"),
    new Movie("Infernal Affairs", "Action"),
    new Movie("Young Frankenstein", "Comedy"),
    new Movie("Weird Al", "Comedy"),
    new Movie("Everything Everywhere All At Once", "Action"),
    new Movie("Stop Making Sense", "Documentary"),
    new Movie("The Lincoln Lawyer", "Drama"),
    new Movie("In The Mood for Love", "Drama")
};

foreach(Movie m in movies)
{
    DisplayMovieDetails(m);
}

static void DisplayMovieDetails(Movie inputMovie)
{
    Console.WriteLine($"{inputMovie.Title}: {inputMovie.Category}");
}

Console.WriteLine("Category pull test");

static void DisplayCategory(Movie inputCategory)
{
    Console.WriteLine($"[inputMovie.Category");
}

List<Movie> movie = movies.Where(m => m.Category.ToLower() == category)

//Console.WriteLine("Please enter a category.");
//string category = (Console.ReadLine()).ToLower().Trim();

//if (movies.Any(n => n.ToLower().Trim().Category.Contains(category)))
//{
//    string result = movies.FirstOrDefault(n => n.Category.Contains(category).Trim());

//}



Console.WriteLine(movies);