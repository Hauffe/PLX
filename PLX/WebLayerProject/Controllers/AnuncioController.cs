using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebLayerProject.Models;
using WebLayerProject.ServiceAnuncio;

namespace WebLayerProject.Controllers
{
    public class AnuncioController : Controller
    {
        public ActionResult NovoAnuncio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NovoAnuncio(string Descricao, string titulo, double preco, int idUsuario, int idCategoria)
        {
            try
            {
                using (ServiceAnuncioClient anuncio = new ServiceAnuncio.ServiceAnuncioClient())
                {
                    anuncio.SalvarAnuncioAsync(idUsuario, idCategoria, Descricao, titulo, preco);
                    ViewBag.Message = "Cadastrado com sucesso ";
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> BuscarPorId(int id)
        {

            using (ServiceAnuncioClient anuncio = new ServiceAnuncio.ServiceAnuncioClient())
            {
                var ret = await anuncio.buscarPorIdAsync(id);
                return View(AutoMapper.Mapper.Map<AnuncioVM>(ret));
            }
        }

        public async Task<ActionResult> ListarTodos()
        {

            using (ServiceAnuncioClient anuncio = new ServiceAnuncio.ServiceAnuncioClient())
            {
                var ret = await anuncio.ListarTodosAsync();
                return View(AutoMapper.Mapper.Map<AnuncioVM[]>(ret));
            }
        }
    }
}
