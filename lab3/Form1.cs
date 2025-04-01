using System.Drawing.Printing;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public string FileFormat { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} (Format: {FileFormat})";
            }
        }

        public class Textbook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} (Subject: {Subject})";
            }
        }

        public class Audiobook : Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Narrated by {Narrator} (Duration: {Duration} hours)";
            }
        }

        
        private void ProcessBooks(Book[] books)
        {
            listBoxBooks.Items.Clear();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] books = new Book[]
            {
                new Book { Title = "C# Programming", Author = "Alice Johnson" },
                new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
                new Ebook { Title = "Behind Her Eyes", Author = "Sarah Pinborough", FileFormat = "EPUB" },
                new Textbook { Title = "Calculus for Dummies", Author = "Mark Ryan", Subject = "Calculus" },
                new Audiobook { Title = "The Last Time I Lied", Author = "Riley Sager", Duration = 5.5, Narrator = "Stephanie Cannon" }
            };

            ProcessBooks(books);
        }
    }
}
