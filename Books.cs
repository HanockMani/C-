using System;

namespace PartialClasses
{
    public partial class Books
    {
        public String authorName;
        public String bookNo;
        public void printDet()
        {
            Console.WriteLine("Author Name: " + authorName+"\nBook No: "+bookNo);
        }
    }

    public partial class Books
    {
        public String bookName;
        public String publisherName;
        public void printPublisherDetails()
        {
            Console.WriteLine("Book Name: " + bookName + "\nPublisher Name: " + publisherName);
        }
    }
    public partial class Books
    {
        static void Main(string[] args)
        {
           Books b1 = new Books();
            b1.authorName = "J K Rowling";
            b1.bookNo = "101";
            b1.bookName = "Harry Potter";
            b1.publisherName = "ABC Publishers";
            b1.printDet();
            b1.printPublisherDetails();
        }
    }
}
