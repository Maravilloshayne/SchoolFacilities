﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShaneMaravillo.SchoolFacilities.Web.Areas.Manage.ViewModels.Posts;
using ShaneMaravillo.SchoolFacilities.Web.Infrastructures.Data.Helpers;
using ShaneMaravillo.SchoolFacilities.Web.Infrastructures.Data.Models;

namespace ShaneMaravillo.SchoolFacilities.Web.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class PostsController : Controller
    {
        private readonly DefaultDbContext _context;

        public PostsController(DefaultDbContext context)
        {
            _context = context;
        }



        [HttpGet, Route("manage/posts/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("manage/posts/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            Post post = new Post()
            {
                Id = Guid.NewGuid(),
                Content = model.Content,
                Description = model.Description,
                IsPublished = true,
                PostExpiry = model.PostExpiry,
                TemplateName = "post1",
                Title = model.Title
            };

            this._context.Posts.Add(post);
            this._context.SaveChanges();

            return View();
        }


        [HttpGet, Route("manage/posts/index")]
        [HttpGet, Route("manage/posts")]
        public IActionResult Index(int pageIndex = 1, int pageSize = 2, string keyword = "")
        {
            Page<Post> result = new Page<Post>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Post> postQuery = (IQueryable<Post>)this._context.Posts;

            if (string.IsNullOrEmpty(keyword) == false)
            {
                postQuery = postQuery.Where(u => u.Title.ToLower().Contains(keyword.ToLower()));
            }

            long queryCount = postQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Post> users = postQuery.ToList();

            result.Items = users.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Posts = result
            });
        }

        [HttpPost, Route("manage/posts/unpublish")]
        public IActionResult Unpublish(PostIdViewModel model)
        {
            var post = this._context.Posts.FirstOrDefault(p => p.Id == model.Id);

            if (post != null)
            {
                post.IsPublished = false;
                this._context.Posts.Update(post);
                this._context.SaveChanges();
                return Ok();
            }

            return null;
        }

        [HttpPost, Route("manage/posts/publish")]
        public IActionResult Publish(PostIdViewModel model)
        {
            var post = this._context.Posts.FirstOrDefault(p => p.Id == model.Id);

            if (post != null)
            {
                post.IsPublished = true;
                this._context.Posts.Update(post);
                this._context.SaveChanges();
                return Ok();
            }

            return null;
        }

        [HttpGet, Route("/manage/posts/update-title/{postId}")]
        public IActionResult UpdateTitle(Guid? postId)
        {
            var post = this._context.Posts.FirstOrDefault(p => p.Id == postId);

            if (post != null)
            {
                var model = new UpdateTitleViewModel()
                {
                    Id = post.Id,
                    Description = post.Description,
                    Title = post.Title,
                    PostExpiry = post.PostExpiry,
                    TemplateName = post.TemplateName
                };

                return View(model);
            }

            return RedirectToAction("Create");
        }

        [HttpPost, Route("/manage/posts/update-title")]
        public IActionResult UpdateTitle(UpdateTitleViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var post = this._context.Posts.FirstOrDefault(p => p.Id == model.Id);

            if (post != null)
            {
                post.Title = model.Title;
                post.Description = model.Description;
                post.PostExpiry = model.PostExpiry;
                post.TemplateName = model.TemplateName;

                this._context.Posts.Update(post);
                this._context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet, Route("/manage/posts/update-content/{postId}")]
        public IActionResult UpdateContent(Guid? postId)
        {
            var post = this._context.Posts.FirstOrDefault(p => p.Id == postId);

            if (post != null)
            {
                var model = new UpdateContentViewModel()
                {
                    Id = post.Id,
                    Content = post.Content
                  
                };

                return View(model);
            }

            return RedirectToAction("Create");
        }

        [HttpPost, Route("/manage/posts/update-title")]
        public IActionResult UpdateContent(UpdateContentViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var post = this._context.Posts.FirstOrDefault(p => p.Id == model.Id);

            if (post != null)
            {
                post.Content = model.Content;
                

                this._context.Posts.Update(post);
                this._context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}