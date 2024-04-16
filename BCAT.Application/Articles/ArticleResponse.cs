using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Articles
{
    //general article DTO
    public record struct ArticleResponse
    {
        public int Id;
        public string Title;
        public string? Content;
        public DateTime DatePublished;
        bool IsPublished;
    }
}
