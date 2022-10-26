using System;
using System.Collections.Generic;

namespace P03_Articles2Project
{
    class P03_Articles2Project
    {
        static void Main(string[] args)
        {
            int numOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < numOfArticles; i++)
            {
                string[] currentArticle = Console.ReadLine().Split(", ");
                var article = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);
                articles.Add(article);
            }

            string typeOrder = Console.ReadLine();

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public List<Article> Articles { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}