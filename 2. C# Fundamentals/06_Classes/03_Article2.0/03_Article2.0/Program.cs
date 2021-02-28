using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Article2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ").ToArray();
                string title = input[0];
                string content = input[1];
                string author = input[2];

                var article = new Article(title, content, author);
                articles.Add(article);
            }

            string word = Console.ReadLine();

            if (word == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }

            else if (word == "content")
            {
                articles = articles.OrderBy(y => y.Content).ToList();
            }

            else if (word == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(String.Join(Environment.NewLine, articles));
        }
    }
}