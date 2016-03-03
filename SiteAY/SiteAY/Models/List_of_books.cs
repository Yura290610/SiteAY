using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteAY.Models
{
    public class List_of_books
    {
        public static IEnumerable<Book> CreateBooks()
        {
            List<Book> books =new List<Book>();
            books.Add(new Book()
            {
                Name = "Cracking the CODING INTERVIEW",
                Author = "Gayle Laakmann",
                About = "Эта книга представляет собой описание интервью в компания ИТ.\n Здесь представлены различные задачи по проверки навыков программирования",
                MyOpinion = "Нравится: книга отражает наиболее полный перееь практических задач, которые могут помочь при решении разного рода проблем в программированиии."

            });
            books.Add(new Book()
            {
                Name = "Алгоритмы и структуры данных",
                Author = "Третьяков А. С.",
                About = "Книга рассказывает о различных алгоритмах и структурах данных, показывает их применение в реальной жизни",
                MyOpinion = "Нравится: можно подчерпнуть интересные идеи, освоить новые алгоритмы, которые помогут в задачам."

            });
            books.Add(new Book()
            {
                Name = "Адам Фриман",
                Author = "ASP.NET MVC 4",
                About = "Книга по разработке в ASP.NET MVC 4",
                MyOpinion = "Настольная книга: обучает с низов программированию сайтов, позволяет на примерах опробывать различные техники."

            });
            return books;
        }
    }
}