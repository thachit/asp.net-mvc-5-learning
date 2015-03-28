using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BookStoreApplication.Models;
using System.IO;

namespace BookStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        private BookStoreDB db = new BookStoreDB();

        // GET: Store
        public ActionResult Index()
        {
            var books = db.Books.Include(b => b.Author).Include(b => b.Genre);
            return View(books.ToList());
        }

        // GET: /Store/Create
        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Authors, "ID", "Name");
            ViewBag.GenreId = new SelectList(db.Genres, "ID", "Name");
            return View();
        }

        public byte[] ConvertImage(HttpPostedFileBase image)
        {
            byte[] imageByte = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageByte = reader.ReadBytes((int)image.ContentLength);
            return imageByte;
        }

        private void SaveImageToDB(int id, HttpPostedFileBase Image)
        {
            var book = db.Books.Find(id);
            book.Image = ConvertImage(Image);
            db.SaveChanges();
        }

        private void SaveImageToDir(int id, HttpPostedFileBase Image)
        {
            var path = Path.Combine(Server.MapPath(@"~/Content/ProductImage/"), Image.FileName);
            Image.SaveAs(path);
        }

        // POST: /Store/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,DateRelease,Publish,Description,Price,AuthorId,GenreId")]Book book, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)
            {   
                db.Books.Add(book);
                db.SaveChanges();

                if (Image != null)
                {
                    SaveImageToDB(book.ID, Image);
                    SaveImageToDir(book.ID, Image);
                }
                return RedirectToAction("Index");
            }


            ViewBag.AuthorId = new SelectList(db.Authors, "ID", "Name");
            ViewBag.GenreId = new SelectList(db.Genres, "ID", "Name");
            return View(book);
        }
    }
}