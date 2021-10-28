using _02.CodeFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            //db.Database.EnsureCreated();

            //db.Categories.Add(new Category
            //{
            //    Title = "Sport",
            //    News = new List<News>
            //    {
            //         new News
            //         {
            //                Title = "Spartak pobedi Dunav",
            //                Content = "Sus 2:0",
            //                Comments = new List<Comment>
            //                    {
            //                        new Comment{ Author = "Gosho", Content = "bravo"},
            //                        new Comment{ Author = "Pesho", Content = "losho"}
            //                    }
            //         }
            //    }
            //});
            //db.SaveChanges();

            //var news = db.News.Select(x => new
            //{
            //    Name = x.Title,
            //    CategoryName = x.Category.Title
            //});

            //foreach (var singleNews in news)
            //{
            //    Console.WriteLine($"{singleNews.CategoryName} => {singleNews.Name}");
            //}

            //Console.WriteLine(db.Comments.Count());
            //Console.WriteLine(db.Comments.Where(x => x.Author == "Pesho").Count());
            //var firstNews = db.News.FirstOrDefault(x => x.Id == 1);
            //var comments = db.Comments.Where(x => x.Author == "Gosho").ToList();

            //foreach (var author in comments)
            //{
            //    db.Comments.Remove(author);
            //}

            db.SaveChanges();
        }
    }
}
