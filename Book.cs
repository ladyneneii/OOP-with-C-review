// Getters and Setters

namespace Tutorial
{
    class Book 
    {
        // Class attributes
        public string title;
        public string author;
        public int pages;
        private string rating;

        public Book()
        {
            Console.WriteLine("Creating book without parameters.");
        }

        public Book(string _title, string _author, int _pages, string _rating)
        {
            title = _title;
            author = _author;
            pages = _pages;
            // rating = _rating;
            Rating = _rating;

            Console.WriteLine("Creating book.");
        }

        public string Rating
        {
            get 
            { 
                return rating; 
            }
            // getting the value of rating for Console.WriteLin()
            set 
            { 
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value; // rating referring to one of the class properties above
                }
                else 
                {
                    rating = "NR";
                }
            }
            // incoming input from the object in Program.cs
        }
    }
}