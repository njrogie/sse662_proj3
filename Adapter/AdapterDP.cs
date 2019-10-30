using System;

namespace Adapter
{
    static class AdapterDP
    {
        static void Main(string[] args)
        {
            LibraryBook ExampleBook = new LibraryBook("King Arthur", "A king leads his knights to find the legendary blade Excalibur");
            OutputInfo(ExampleBook);

            string[] TableOfContents = { "FrontPage", "Sports", "Advertisements" };
            Newspaper ExamplePaper = new Newspaper("The Cluster", TableOfContents);

            ILibraryBook AdaptedNewspaper = new NewspaperLibraryBookAdapter(ExamplePaper);

            OutputInfo(AdaptedNewspaper);

            Console.WriteLine("This program uses the Adapter Design Pattern.");
            Console.ReadLine();
        }

        static void OutputInfo(ILibraryBook book)
        {
            Console.WriteLine(book.GetTitle());
            Console.WriteLine(book.GetSynopsis());
            Console.WriteLine();
        }
    }

    class NewspaperLibraryBookAdapter : ILibraryBook
    {
        Newspaper newspaper;
        public string Title { get; set; }
        public string Synopsis { get; set; }

        public NewspaperLibraryBookAdapter(Newspaper _newspaper)
        {
            newspaper = _newspaper;
        }

        public void SetTitle(string _title)
        {
            newspaper.SetTitle(_title);
        }

        public void SetSynopsis(string _toc)
        {
            newspaper.SetToC(_toc.Split('\n'));
        }

        public string GetTitle()
        {
            return newspaper.GetTitle();
        }

        public string GetSynopsis()
        {
            return newspaper.GetToC();
        }
    }
}