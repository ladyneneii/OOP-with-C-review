// Functions

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // SayHi("Earth");
            // SayHi("slay");
            // Console.WriteLine("Hello, world!!!");

            // int quotient = GetQuotient(10, 0);

            // Console.WriteLine("I have " + quotient + " apples.");

            // Object - instance of a class
            /*
            Book book1 = new Book();

            book1.title = "Heartstopper";
            book1.author = "Alice Oseman";
            book1.pages = 400;
            */

            Book book1 = new Book("Heartstoppurr", "Alice Oseman", 400, "Dog");
            Book book2 = new Book();

            Console.WriteLine("The name of the book is " + book1.title + ".");
            Console.WriteLine("The rating is " + book1.Rating + ".");

            Student student1 = new Student("Charlie Spring", "English", 2.5);
            Student student2 = new Student("Nick Nelson", "Maths", 3.8);

            Console.WriteLine(student1.HasHonours());
            Console.WriteLine(student2.HasHonours());

            Songs song1 = new Songs("Kill Bill", "SZA", 300);

            Console.WriteLine(song1.title);
            Console.WriteLine(Songs.songCount);

            Songs song2 = new Songs("Summertime Sadness", "Lana del Ray", 350);

            Console.WriteLine(song2.title);
            Console.WriteLine(Songs.songCount); 
            // all objects can have different values of the class attributes, but they all have the same value for all static class attributes
            // Therefore, static variables belong to classes, which is why you can ONLY access static attributes through classes (Songs.songCount) and NOT objects (song1.songCount)

            UsefulTools.SayHi("Nene");
            // SayHi is a static method, so you don't have to create an object to access the method. Just access it directly using its class name.
            // Static classes can't have objects. To create static classes, just put 
            // static class myClass{}

            Chef chef = new Chef();

            chef.MakeChicken();

            ItalianChef italianChef = new ItalianChef();

            italianChef.MakeChicken();
            italianChef.MakePasta();
            chef.MakeSpecialDish();
            italianChef.MakeSpecialDish();
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hi, " + name + " !!");
        }

        static int GetQuotient(int num1, int num2)
        {
            try 
            {
                int result = num1 / num2;

                return result;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Error dividing!");
                Console.WriteLine(e.Message);

                return 0;
            }
            catch(Exception e)
            {
                Console.WriteLine("You didn't enter a number!");
                Console.WriteLine(e.Message);

                return 0;
            }
        }
    }
}