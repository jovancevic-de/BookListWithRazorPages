using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListWithRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListWithRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            this._db = db;
        }

        public IEnumerable<Book> Books { get; set; }

        

        public async Task OnGet()
        {
            this.Books = await _db.Book.ToListAsync();
        }
    }
}
