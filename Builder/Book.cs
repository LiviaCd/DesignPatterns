using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Book
    {
        public string Title { get; private set; }
        public List<string> Authors { get; private set; }
        public string ISBN { get; private set; }
        public string Genre { get; private set; }
        public string Language { get; private set; }
        public double Rating { get; private set; }

        public Book()
        {
            Authors = new List<string>();
        }

        public static BookBuilder With()
        {
            return new BookBuilder();
        }
        public class BookBuilder()
        {
            private readonly Book _book = new Book();

            public BookBuilder Title(string title)
            {
                _book.Title = title;
                return this;
            }

            public BookBuilder Authour(string authour)
            {
                _book.Authors.Add(authour);
                return this;
            }

            public BookBuilder ISBN(string isbn)
            {
                _book.ISBN = isbn;
                return this;
            }

            public BookBuilder Genre(string genre)
            {
                _book.Genre = genre;
                return this;
            }

            public BookBuilder Language(string language)
            {
                _book.Language = language;
                return this;
            }

            public BookBuilder Rating(double rating)
            {
                _book.Rating = rating;
                return this;
            }

            public Book Build()
            {
                return _book;
            }
        }
    }

    
}
