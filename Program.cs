using Delegate_Hometask.Models;

namespace Delegate_Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForPerson

            //List<Person> people= new List<Person>();
            //people.Add(new Person("Nihat", "Khidirov", "Sumgayit", 3000));
            //people.Add( new Person("Samir", "Alakbarov", "Baku", 2000));
            //people.Add(new Person("Senan", "Allahverdiyev", "Ganja", 1000));
            //people.Add(new Person("Aqil", "Alakbarov", "Novxani", 500));
            //people.Add(new Person("Murad", "Cabbarov", "Lenkeran", 950));

            //Predicate<Person> isHighSalaryPredicate = IsHighSalary;
            //ShowAllInfo(people, isHighSalaryPredicate);

            #endregion
            #region ForBooks
            //List<Book> book = new List<Book>();
            //book.Add(new("4 Saatliq Is Heftesi", "Timoti Ferris", 10));
            //book.Add(new("Zafer Sizlanarak Kazanilmaz", "Haluk Tatar", 20));
            //book.Add(new("Fitne", "Nizami", 100));
            //Predicate<Book> IsAuthorNameCorrect = AuthorNameCorrection;
            //ShowCountOfBook(book, IsAuthorNameCorrect);
            #endregion
            #region ForEmployee
            List<Employee> employees = new List<Employee>();
            employees.Add(new("Nihat", "Khidirov", 45));
            employees.Add(new("Samir", "Alakbarov", 25));
            employees.Add(new("Cavid", "Suleymanli", 30));
            employees.Add(new("Lorem", "Ipsum", 35));
            Console.WriteLine(Avarage(employees));
            #endregion


        }
        #region ForEmployee
        static double Avarage(List<Employee>employee)
        {
            double count = 0;
            double sum = 0;
            foreach (var item in employee)
            {
                if(item.Age>20 && item.Age < 40)
                {
                    sum = sum + item.Age;
                    count++;
                }
            }
            return sum / count;
            
        }
        #endregion
        #region ForBooks
        //static void ShowCountOfBook(List <Book>books, Predicate <Book> predicate)
        //{
        //    foreach (var book in books)
        //    {
        //        if (predicate(book))
        //        {
        //            Console.WriteLine("#################");
        //            Console.WriteLine($" Author Name: {book.AuthorName}\n BookName: {book.BookName}\n Count: {book.Count}");

        //        }
        //    }
        //}

        //static bool AuthorNameCorrection(Book book)
        //{
        //    return book.AuthorName == "Nizami";
        //}
        #endregion
        #region ForPerson
        //static void ShowAllInfo(List <Person>people, Predicate<Person> predicate)
        //{
        //    foreach (Person person in people)
        //    {
        //        if (predicate(person))
        //        {
        //            Console.WriteLine("############");
        //            Console.WriteLine($" Name: {person.Name}\n Surname: {person.Surname}\n Address:{person.Address}\n Salary:{person.Salary}");
        //        }
        //    }
        //}
        #endregion

        #region ForPerson
        //static bool IsHighSalary(Person person)
        //{
        //    return person.Salary > 1000;

        //}
        #endregion
    }
}