using System;

namespace HR_Day13_AbstractClass
{
    abstract class Book
    {
        protected String title;
        protected String author;
        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }

    //Write MyBook class
    class MyBook : Book
    {
        protected int myBookPrice;

        public MyBook(String bookTitle, String bookAuthor,int bookPrice) : base(bookTitle,bookAuthor)
        {
            myBookPrice = bookPrice;

        }
        public override void display()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {myBookPrice}");
        }
    }
    class Solution
    {
        static void Main(String[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
