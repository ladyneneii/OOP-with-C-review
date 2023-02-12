// Inheritance

namespace Tutorial
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta.");
        }

        public void MakeSpecialDish() // method overriding
        {
            Console.WriteLine("The chef makes burger steak.");
        }
    }
}