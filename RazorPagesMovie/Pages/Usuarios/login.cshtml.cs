using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class loginModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public loginModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Usuario Usuario { get; set; }

        public IActionResult OnPost()
        {
            var user1 = _context.Usuario.FirstOrDefault(u=>u.Email.Equals(Usuario.Email)&& u.Senha.Equals(Usuario.Senha));
            
            if (user1==null)
            {
              return Page();
             }



            return RedirectToPage("../Movies/Index");
        }
    }
}