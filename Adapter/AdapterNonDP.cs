using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdapterNonDP
    {
        static void notcurrMain(string[] args)
        {
            LibraryBook ExampleBook = new LibraryBook("King Arthur", "A king leads his knights to find the legendary blade Excalibur");
            OutputInfo(ExampleBook);

            string[] TableOfContents = { "FrontPage","Sports","Advertisements" };
            Newspaper ExamplePaper = new Newspaper("The Cluster", TableOfContents);
            OutputInfo(ExamplePaper);

            Console.ReadLine();
        }

        static void OutputInfo(LibraryBook book)
        {
            Console.WriteLine(book.GetTitle());
            Console.WriteLine(book.GetSynopsis());
            Console.WriteLine();
        }

        static void OutputInfo(Newspaper newspaper)
        {
            Console.WriteLine(newspaper.GetTitle());
            Console.WriteLine(newspaper.GetToC());
            Console.WriteLine();
        }


    }

    interface ILibraryBook
    {
        string Title { get; set; }
        string Synopsis { get; set; }
        void SetTitle(string _title);
        void SetSynopsis(string _synopsis);
        string GetTitle();
        string GetSynopsis();
        
    }

    class LibraryBook : ILibraryBook
    {
        public string Title { get; set; }
        public string Synopsis { get; set; }

        public LibraryBook(string _title, string _synopsis)
        {
            Title = _title;
            Synopsis = _synopsis;
        }
        public void SetTitle(string _title) { Title = _title; }
        public void SetSynopsis(string _synopsis) { Synopsis = _synopsis; }
        public string GetTitle()
        {
            return "Title: "+ Title;
        }
        public string GetSynopsis()
        {
            return "Synopsis: "+ Synopsis;
        }
    }

    interface INewspaper
    {
        string Title { get; set; }
        string[] ToC { get; set; }
        void SetTitle(string _title);
        void SetToC(string[] _toc);
        string GetTitle();
        string GetToC();
    }


    class Newspaper : INewspaper
    {
        public string Title { get; set; }
        public string[] ToC { get; set; }

        public Newspaper(string _title, string[] _toc)
        {
            Title = _title;
            ToC = _toc;
        }

        public void SetTitle(string _title) { Title = _title; }
        public void SetToC(string[] _toc) { ToC = _toc; }
        public string GetTitle() { return "Title: " + Title; }
        public string GetToC()
        {
            string buildString = "Table of Contents: \n";
            foreach(string content in ToC)
            {
                buildString += content + "\n";
            }
            return buildString;
        }
    }


}
