using Aula1406.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aula1406.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias (GET = carregamento da pagina)
        public ActionResult Index()
        {
            //Retornar a Lista de objetos Cadastrados
            List<Categoria> categorias = new List<Categoria>();
            return View(categorias);
        }
        // GET 
        public ActionResult Create()
        {
            return View();
        }
        //Post
        [HttpPost]
        public ActionResult Create(Categoria categoria) //(FormColletion campos) recuperar campo a campo, sem ter model
        {
            if (ModelState.IsValid)
            {

            }
            return View(categoria);
        }


        //GET
        public ActionResult Edit(int? id)

        {
            // verificar se não veio id => BadRequest
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Pesquisa na fonte de dados o objeto a editar
            //Categoria categoria = null;
            Categoria categoria = new Categoria()
            {
                CategoriaID = id.Value,
                Nome = "Carros",
                Descricao = "Anda",
                Ativo = true
            };

            //se objeto nao foi encontrado na fonte de dados
            if (categoria == null)
            {
                // Erro - 404
                return HttpNotFound();
            }
            return View(categoria);
        }
        //POST
        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //Fazer update na fonte de dados
                    //redirecionar


                }
                catch (Exception ex)
                {
                    throw ex;
                }
                // fazer update na fonte de dados 
            }
            return View(categoria);

            //GET

        }
    }
}