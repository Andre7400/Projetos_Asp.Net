using Aula1206.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1206.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {

           // List<string> categorias = new List<string>();
            List<Categoria> categorias = new List<Categoria>();


                 categorias.Add(new Categoria() { Nome = "Carros" , Descricao = "Super Carros de coleção"});
                 categorias.Add(new Categoria() { Nome = "Motos", Descricao = "As Motos maneiras de coleção" });
                 categorias.Add(new Categoria() { Nome = "Barcos", Descricao = "Barcos com Turbina de coleção" });
                 categorias.Add(new Categoria() { Nome = "Aviões", Descricao = "Aviões com  Carros de coleção" });
                 categorias.Add(new Categoria() { Nome = "Caminhões", Descricao = "Caminhões com Carros de coleção" });
           // categorias.Add("Carros");
           // categorias.Add("Motos");
           // categorias.Add("Barcos");
           // categorias.Add("Aviões");
           // categorias.Add("Caminhões");

            ViewBag.ListaCategorias = categorias;

            return View(categorias);

        }
        //GET
        public ActionResult Create()
        {
            return View();
        }

       [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            return View(categoria);
        }
    }
}