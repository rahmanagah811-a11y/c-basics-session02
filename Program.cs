namespace ConsoleApp1
{

    class Book

    {
        public string Title;
        public int Pages;
    }
    class Program
    {
       static void Main()
        {
            Book b1 = new Book();
            b1.Title = " Harry Potter ";
            b1.Pages = 150;
            object obj = b1;
            Console.WriteLine(obj);

            //Q2
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1.Equals(b1));
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b1.GetType());

            //Q3
            // Compile-time error
            int pages = 464;

            //Q4
            try
            {
                int zero = 0;
                int result = 10 / zero; 
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            //Q5
            int pages = 300;
            double dblePages = pages;
            Console.WriteLine(dblePages);

            //Q6
            double price = 49.99;
            int newPrice = (int)price;
            Console.WriteLine(newPrice);

            //Q7
            string pagesText = "464";
            int nwPages = Convert.ToInt32(pagesText);
            Console.WriteLine(nwPages);

            //Q8
            string yearText = "2023";
            int newYear = int.Parse(yearText);
            Console.WriteLine(newYear);
            string badText = "abc";
            int bad;
            bool result = int.TryParse(badText, out bad);
            if (result == false)
            {
                Console.WriteLine("Invalid number");
            }

            //Q9
            int pages = 464;
            string pagesText = pages.ToString();
            Console.WriteLine(pagesText.GetType());

            //Q10
            int copies = 100;
            object obj = copies;
            int newCopies = (int)obj;
            Console.WriteLine(obj);
            Console.WriteLine(newCopies);

    }
}
