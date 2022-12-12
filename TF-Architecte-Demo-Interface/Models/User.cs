using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Architecte_Demo_Interface.Models
{
    internal class User : IUser, IAdmin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public EnumRole Role { get; set ; }

        public void ReadArticle (Article article)
        {
            Console.WriteLine(article.Title);
            Console.WriteLine($"Write by : {article.Autor.UserName}");
            Console.WriteLine();
            Console.WriteLine(article.Content);
        }

        public Article WriteArticle() {
            Article newArticle = new Article();
            Console.WriteLine("Quel est le titre ?");
            newArticle.Title = Console.ReadLine();
            Console.WriteLine("Quel est le Texte ?");
            newArticle.Content = Console.ReadLine();
            newArticle.Autor = this;
            return newArticle;
        }
    }
}
