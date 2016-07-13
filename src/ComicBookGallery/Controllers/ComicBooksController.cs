﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.issueNumber = 700;
            ViewBag.description = "<p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's </p>";
            ViewBag.artists = new String[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();

        }
    }
}