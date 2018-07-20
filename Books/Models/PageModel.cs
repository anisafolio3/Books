using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books.Models
{
    public class PageModel
    {
        public int PageId { get; set; }
        public int BookId { get; set; }
        public int PageNo { get; set; }
        public string Title { get; set; }
        public int Description { get; set; }
    }
}