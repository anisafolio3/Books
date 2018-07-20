using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Books.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string Name { get; set; }

        [Display(Name = "No. of Pages")]
        public int NoofPages { get; set; }
        //    get {
        //        return Pages == null ? 0 : Pages.Count();
        //    }
        //}
        public string MainColor { get; set; }
        public DateTime PublishDate { get; set; }

        [Display(Name = "Author")]
        public int SelectedAuthorId { get; set; }
        public List<Author> Authors { get; set; }
        public Author Author { get; set; }
        public string ISBN { get; set; }
        public List<Page> Pages
        {
            get;
            set;
            //get
            //{
            //    var list = new List<Page>();
            //    list.Add(new Page { BookId = 1, PageNo = 1, Description = "sdsd", Title = "sdsd" });
            //    list.Add(new Page { BookId = 2, PageNo = 2, Description = "sdsd", Title = "sdsd" });
            //    return list;
            //}
            //set
            //{
            //    Pages = value;
            //}
        }
    }
}