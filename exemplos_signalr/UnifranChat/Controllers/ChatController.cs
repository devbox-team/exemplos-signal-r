﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnifranChat.Hubs;

namespace UnifranChat.Controllers
{
    public class ChatController : Controller
    {
        //
        // GET: /Chat/
        public ActionResult Index(FormCollection form)
        {
            Chat.NomeUsuario = form["txtNome"];
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult JogoVelha()
        {
            return View();
        }

	}
}