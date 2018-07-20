using Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Books.Controllers
{
    public class BooksController : Controller
    {
        Entities db = new Entities();
        // GET: Books
        public ActionResult Index()
        {
            var b = new BookModel();
            b.Authors = db.Authors.ToList();

            return View(b);
        }

        [HttpPost]
        public ActionResult Index(BookModel model)
        {
            try
            {
                Book book = new Book();
                book.Name = model.Name;
                book.NoOfPages = model.Pages.Count();
                book.MainColor = model.MainColor;
                book.PublishDate = model.PublishDate;
                book.AuthorId = model.SelectedAuthorId;
                book.ISBN = model.ISBN;
                
                db.Books.Add(book);
                db.SaveChanges();

                for (int i = 0; i < model.Pages.Count; i++)
                {
                    model.Pages[i].BookId = book.BookId;
                    db.Pages.Add(model.Pages[i]);
                }
                db.SaveChanges();
                model.Authors = db.Authors.ToList();

                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult PageRow()
        {
            return PartialView("Page", new Page());
        }
    }
}