namespace Session_2__Assignment_C___numbered_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01 
            //Create a Book class with a Title (string) and Pages (int).
            //Create a Book object and store it in a variable of type object.
            //Print it.
            //object obj = new Book();

            //Console.WriteLine(obj);

            #endregion
            #region 02
            //Using the Book class above, print the result of calling ToString(),
            //Equals() (compare book with itself), GetHashCode(),
            //and GetType() on book.
            //Book book = new Book();
            //Console.WriteLine($"Book TOstring() : {book.ToString()}\nBook Equals() : {book.Equals(book)}\nBook GetHashcode() : {book.GetHashCode}\nBook GetType() : {book.GetType} ");

            #endregion
            #region 03
            //Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
            //Compile-time error — you can't put text (string) into an int variable.
            //int pages = 464;
            #endregion
            #region 04
            //Write code that divides 10 by 0 inside a try block,
            //catches the exception, prints "Cannot divide by zero",
            //and then prints "Done" in a finally block.

            //try
            //{
            //    int num01 = 10;
            //    double result = num01 / 0;
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion
            #region 05
            ////Declare an int pages = 300;
            ////then store it in a double variable without using a cast.
            //int Pages = 300;
            //double Dpages = Pages;
            #endregion
            #region 06
            //double price = 49.99;
            //int Iprice = (int)price;
            //Console.WriteLine(Iprice);
            #endregion
            #region 07
            //string pagesText = "464";
            //int convertInt = Convert.ToInt32(pagesText);
            //Console.WriteLine(convertInt);
            #endregion
            #region 08
            ////Given string yearText = "2023";, convert it using
            ////int.Parse().Then given string badText = "abc";
            ////, use int.TryParse() to safely try converting it,
            ////and print "Invalid number" if it fails.
            //string yearText = "2023";
            //string badText = "abc";
            //int yearT = int.Parse(yearText);
            //Console.WriteLine(yearT);
            //if (int.TryParse(badText, out int yearb))
            //{
            //    Console.WriteLine(yearb);
            //}else 
            //{ Console.WriteLine("Invalid number"); }
            #endregion
            #region 09
            //Given int pages = 464;, convert it into a
            //string using ToString() and print its type
            //using GetType() to prove it's now a string.
            //int pages = 464;
            //string tostring = pages.ToString();
            //Console.WriteLine(tostring.GetType());

            #endregion
            #region 10
            //eclare int copies = 100;. Box it into an object
            //variable, then unbox it back into a new int variable,
            //and print both.
            //int copies = 100;
            //object obj = copies;
            //int Unboxing =(int) obj;
            //Console.WriteLine($"Boxing = {obj} ,Unboxing = {Unboxing}");
            #endregion
            #region 11
            //Declare an int? year = null;.
            //Print whether it has a value,
            //then assign it 2023 and print its value.
            //int? year = null ;
            //Console.WriteLine(year.HasValue);
            //year = 2023;
            //Console.WriteLine(year);
            #endregion
            #region 12
            //Declare a string? reviewer = null;. Print whether it is null.
            //string? reviewer = null;
            //Console.WriteLine(reviewer==null);
            #endregion
            #region 13
            //Declare a Book? book = null;. Use?.to safely read book.
            //Title without crashing the program, and print the result.
            //Book? book = null;
            //  Console.WriteLine(book?.Title);


            #endregion
            #region 14
            //Using title from the previous question, use ?? to print
            //"Untitled" if title is null. Then use ??= to assign title
            //the value "Untitled" only if it's still null
            //Book? book = new Book();
            //   book.Title = null;
            //   Console.WriteLine(book.Title ?? "Untitled");
            #endregion
            #region 15
            //Given string? name = "Ahmed";
            //(you are sure it's not null here), assign
            //it to a non-nullable string confirmedName using the ! operator.
            //string?name = "ahmed";
            //name = null;
            //string confirmedName = name!;
            //Console.WriteLine(confirmedName);
            #endregion
        }
    }
}
