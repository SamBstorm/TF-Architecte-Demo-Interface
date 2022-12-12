using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Architecte_Demo_Interface.Models
{
    internal class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IAdmin Autor { get; set; }
    }
}
