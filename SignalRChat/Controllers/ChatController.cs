using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatSignalIr.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<int, string> listaChats =
            new Dictionary<int, string>()
        {
            {1, "GrupoClase" },
            {2, "GrupoVacaciones" },
            {3, "GrupoFamilia" },
            {4, "GrupoPueblo" },
            {5, "GrupoPiscina" }
        };

        public IActionResult ListaChats()
        {
            return View(listaChats);
        }

        public IActionResult Chat(int idChat)
        {
            return View("Chat", idChat);
        }
    }
}
