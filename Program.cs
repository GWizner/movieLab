public class Movie
{

    public string title;
    public string category;

    public Movie(string newTitle, string newCategory)
    {
        title = newTitle;
        category = newCategory;
    }
    public static void Main(string[] args)
    {
        var movie = new List<Movie>() { new Movie("Dune", "Adventure"), new Movie("Dune", "Drama"), new Movie("Dune", "Sci-Fi"),
            new Movie("Interstellar 5555", "Adventure"), new Movie("Interstellar 5555", "Anime"), new Movie("Pulp Fiction", "Drama"),
            new Movie("Gummo", "Comedy"), new Movie("Gummo", "Drama"), new Movie("Spirited Away", "Adventure"),
            new Movie("Spirited Away", "Anime"), new Movie("Spirited Away", "Fantasy"), new Movie("Ju-on", "Horror"),
            new Movie("Evil Dead 2", "Comedy"), new Movie("Evil Dead 2", "Horror"), new Movie ("The Princess Bride", "Adventure"),
            new Movie ("The Princess Bride", "Fantasy"), new Movie ("The Princess Bride", "Romance"), new Movie("Army of Darkness", "Comedy"),
            new Movie("Army of Darkness", "Horror"), new Movie("Let the Right One In", "Drama"), new Movie("Let the Right One In", "Fantasy"),
            new Movie("Let the Right One In", "Horror"), new Movie("Let the Right One In", "Romance")};

        string adventure = "Adventure";
        string anime = "Anime";
        string comedy = "Comedy";
        string drama = "Drama";
        string fantasy = "Fantasy";
        string horror = "Horror";
        string romance = "Romance";
        string sciFi = "Sci-Fi";

        int userAns = 0;
        string y = "y";
        string yes = "yes";
        bool keepAsk = true;
        bool trueAns = false;

        while (keepAsk)
        {
            Console.WriteLine("Hello, User. Please select which genre of movie you'd like to see: ");
            Console.WriteLine("1)Adventure 2)Anime 3)Comedy 4)Drama 5)Fantasy 6)Horror 7)Romance 8)Sci-Fi");
            string userAnswer = Console.ReadLine().ToLower();
            trueAns = int.TryParse(userAnswer, out userAns);
            if (userAns == 1 || userAnswer == adventure)
            {
                foreach (var catSearch in movie)
                {
                    if (catSearch.category == adventure)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                }
                keepAsk = false;
            }
            if (userAns == 2 || userAnswer == anime)
            {
                foreach (var catSearch in movie)
                {
                    if (catSearch.category == anime)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                }
                keepAsk = false;
            }
            else if (userAns == 3 || userAnswer == comedy)
            {
                foreach (var catSearch in movie)
                {
                    if (catSearch.category == comedy)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                }
                keepAsk = false;
            }
            else if (userAns == 4 || userAnswer == drama)
            {
                foreach (var catSearch in movie)
                {
                    if (catSearch.category == drama)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                }
                keepAsk = false;
            }
            else if (userAns == 5 || userAnswer == fantasy)
            {
                foreach (var catSearch in movie)
                {
                    if (catSearch.category == fantasy)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                }
                keepAsk = false;
            }
            else if (userAns == 6 || userAnswer == horror)
            {
                foreach (var catSearch in movie)
                {
                    if (catSearch.category == horror)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                    keepAsk = false;
                }
            }
            else if (userAns == 7 || userAnswer == romance)
            {
                foreach (var catSearch in movie)
                {
                    if (catSearch.category == romance)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                }
                keepAsk = false;
            }
            else if (userAns == 8 || userAnswer == sciFi)
            {
                foreach (var catSearch in movie)
                {
                    if (catSearch.category == sciFi)
                    {
                        Console.WriteLine($"{catSearch.title}");
                    }
                }
                keepAsk = false;
            }
            else if (trueAns == false)
            {
                Console.WriteLine("Sorry, we have nothing from that genre. Please try again");
                Console.WriteLine();
                keepAsk = true;
            }
            Console.WriteLine("Would you like to see any more (y/n)? ");
            string more = Console.ReadLine().ToLower();
            more.Trim();
            more = more.Trim();

            if (more == y || more == yes)
            {
                keepAsk = true;
            }
            else
            {
                keepAsk = false;
            }

        }
    }
}    
