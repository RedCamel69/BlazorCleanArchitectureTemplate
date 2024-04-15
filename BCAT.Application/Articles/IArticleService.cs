﻿using BCAT.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Articles
{
    public interface IArticleService
    {
        Task<List<Article>> GetAllArticles();
    }
}
