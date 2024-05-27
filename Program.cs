using System.Net.Cache;

namespace C_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //СТУДЕНТИКИ



            List<Student3> students = new List<Student3>
            {
                new Student3 {Name = "Sasha", Age = 20, AverageGrade = 4.8},
                new Student3 {Name = "Alice", Age = 18, AverageGrade = 4.0},
                new Student3 {Name = "Hloya", Age = 25, AverageGrade = 3.5},
                new Student3 {Name = "Kostyan", Age = 23, AverageGrade = 5.0},
            };
            var studentsOver20 = students.Where(x => x.Age > 20).OrderByDescending(x => x.AverageGrade);
            foreach (var student in studentsOver20)
            {
                Console.WriteLine($"{student.Name},Age: {student.Age},Average grade: {student.AverageGrade}");
            }
            var studenAverageGrade = students.OrderByDescending(x => x.AverageGrade).First();
            Console.WriteLine($"Наивысший бал: {studenAverageGrade.Name}, {studenAverageGrade.Age}, {studenAverageGrade.AverageGrade} ");

            var AverageAge = students.Average(x => x.Age);
            Console.WriteLine($"Средний возраст: {AverageAge}");

            Console.WriteLine($"Кол-во студентов: {students.Count}");

            Console.WriteLine("\nБал выше 4.5");
            var studentsOver20_2 = students.Where(x => x.Age >= 20 && x.AverageGrade > 4.5);
            foreach (var student in studentsOver20_2)
            {
                Console.WriteLine($"{student.Name},Age: {student.Age},Average grade: {student.AverageGrade}");
            }

            var OldAge = students.OrderByDescending(x => x.Age).First();
            Console.WriteLine($"\nСамы старый: {OldAge.Name}");

            var DesAverage = students.OrderByDescending(x => x.AverageGrade);
            foreach (var student in DesAverage)
            {
                Console.WriteLine($"по убыванию балов: {student.Name}, {student.Age}, {student.AverageGrade} ");
            }

            //БИБЛИОТЕКА

            BookStore<IBook> bookStore = new BookStore<IBook>();

            var book1 = new Book1
            {
                Title = "Book1",
                Author = "Author1",
                Genre = "Fiction",
                Price = 39.99,
                PublicationYear = 2020
            };
            var book2 = new Book2
            {
                Title = "Book2",
                Author = "Author2",
                Genre = "Non-Fiction",
                Price = 29.99,
                PublicationYear = 2018
            };
            bookStore.AddBook(book1);
            bookStore.AddBook(book2);

            var booksByAuthor = bookStore.FindBooksByAuthor("Author1");
            var booksByGenre = bookStore.FindBooksByGenre("Fiction");
            Console.Write("Books by author:");
            foreach (var book in booksByAuthor)
            {
                Console.WriteLine($" {book.Title} by {book.Author}");
            }
            Console.Write("Books by genre:");
            foreach (var book in booksByGenre)
            {
                Console.WriteLine($" {book.Title} by {book.Genre}");
            }

            var sortedBooks = bookStore.GetBooksSortedBy(b => b.Price);
            Console.WriteLine("\nBooks sorted by price: ");
            foreach(var book in sortedBooks)
            {
                Console.WriteLine($"{book.Title} - {book.Price}");
            }

            Console.WriteLine($"\nTotal price of all books: {bookStore.CalculateTotalPrice()}");

            var mostExpensiveBook = bookStore.GetMostExpensiveBook();
            Console.WriteLine($"\nMost expensive book: {mostExpensiveBook.Title} - {mostExpensiveBook.Price}");




            StudentCollection<IStudent> studentCollection = new StudentCollection<IStudent>();

            Student2 student1 = new Student2
            {
                Name = "3",
                Age = 20,
                Major = "asd"
            };
            Student2 student2 = new Student2
            {
                Name = "2",
                Age = 21,
                Major = "asde"
            };
            Student2 student3 = new Student2
            {
                Name = "1",
                Age = 22,
                Major = "asew"
            };
            studentCollection.Add(student1);
            studentCollection.Add(student2);
            studentCollection.Add(student3);

            var studentByMajor = studentCollection.FindStudentMajor("asde");
            foreach (var student in studentByMajor)
            {
                Console.WriteLine($"{student.Name} - {student.Major}");
            }

            var YoungStudent = studentCollection.FindYoungStudent();
            Console.WriteLine($"Самый молодой: {YoungStudent.Name} - {YoungStudent.Age}");

            var OldStudent = studentCollection.FindYOldStudent();
            Console.WriteLine($"СМамый старый: {OldStudent.Name} - {OldStudent.Age}");

            Console.WriteLine($"Отсортированный список: ");
            var sortedStudents = studentCollection.GetStodentSortedBy(s => s.Name);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Age}");
            }

            studentCollection.PrintAllStudents();





        }
    }
}
