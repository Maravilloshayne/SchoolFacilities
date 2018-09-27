using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShaneMaravillo.SchoolFacilities.Web.Infrastructures.Data.Helpers;
using ShaneMaravillo.SchoolFacilities.Web.ViewModels;

namespace ShaneMaravillo.SchoolFacilities.Web.Controllers
{
    public class PostsController : Controller
    {
            private readonly DefaultDbContext _context;

            public PostsController(DefaultDbContext context)
            {
                _context = context;
            }


            public IActionResult Index()
            {
                return View(new IndexViewModel()
                {
                    Posts = this._context.Posts.ToList()
                });
            }

            public IActionResult Post(Guid? postId)
            {
                return View();
            }

            public IActionResult Carousel()
            {
                return View();
            }

            public IActionResult Gallery()
            {
                return View();
            }
        }
    }