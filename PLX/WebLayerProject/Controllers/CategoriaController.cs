using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebLayerProject.Models;
using WebLayerProject.ServiceCategoria;

namespace WebLayerProject.Controllers
{
    public class CategoriaController : Controller
    {
        public ActionResult NovaCategoria()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NovaCategoria(string nome, string descricao)
        {
            try
            {
                using (ServiceCategoriaClient categoria = new ServiceCategoria.ServiceCategoriaClient())
                {
                    categoria.SalvarCategoria(nome, descricao);
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

            using (ServiceCategoriaClient categoria = new ServiceCategoria.ServiceCategoriaClient())
            {
                var ret = await categoria.buscarPorIdAsync(id);
                return View(AutoMapper.Mapper.Map<CategoriaVM>(ret));
            }
        }

        public async Task<ActionResult> ListarTodos()
        {

            using (ServiceCategoriaClient categoria = new ServiceCategoria.ServiceCategoriaClient())
            {
                var ret = await categoria.ListarTodosAsync();
                return View(AutoMapper.Mapper.Map<CategoriaVM[]>(ret));
            }
        }
    }
}
