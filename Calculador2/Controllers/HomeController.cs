﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculador2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // POST: Home
        //anotação
        [HttpPost]
        //traz o numero antigo de volta ao controller de modo a poder devolve-lo. 
        public ActionResult Index(string visor, string bt)
        {
            switch (bt) {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    if (visor == "0") {
                        visor = bt;
                    }
                    else{
                        visor += bt;

                    }

                    break;
            }
            ViewBag.Resposta = visor;
            return View();
        }
    }
}