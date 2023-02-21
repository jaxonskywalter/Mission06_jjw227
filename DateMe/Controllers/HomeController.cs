using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private EnterMovieContext movContext { get; set; }

        public HomeController(EnterMovieContext someName)
        {
            movContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            ViewBag.Categories = movContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(ApplicationResponse ar)
        {
            //makes sure the entries meet the critera through validation
            if (ModelState.IsValid)
            {
                movContext.Add(ar);
                movContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = movContext.Categories.ToList();

                return View(ar);
            }
           
        }

        [HttpGet]
        public IActionResult MovieList ()
        {
            //filters the database like sql
            var submissions = movContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(submissions);
        }

        //allows the edit page to fucntion the same as the enter movie page
        [HttpGet]
        public IActionResult Edit(int submissionid)
        {
            ViewBag.Categories = movContext.Categories.ToList();

            var submission = movContext.Responses.Single(x => x.SubmissionId == submissionid);

            return View("EnterMovie", submission);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                movContext.Update(ar);
                movContext.SaveChanges();
                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = movContext.Categories.ToList();

                return View("EnterMovie");
            }
        }
        
        [HttpGet]
        public IActionResult Delete(int submissionid)
        {
            var submission = movContext.Responses.Single(x => x.SubmissionId == submissionid);

            return View(submission);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            movContext.Responses.Remove(ar);
            movContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

    }
}