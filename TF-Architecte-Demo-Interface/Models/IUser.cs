﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Architecte_Demo_Interface.Models
{
    internal interface IUser
    {
        string UserName { get; set; }
        string Password { get; set;}
        EnumRole Role { get; set; }
        void ReadArticle(Article article);
    }
}
