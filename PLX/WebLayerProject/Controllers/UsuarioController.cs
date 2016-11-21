using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebLayerProject.Models;
using WebLayerProject.ServiceUsuario;

namespace WebLayerProject.Controllers
{
    public class UsuarioController : Controller
    {

        public ActionResult NovoUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NovoUsuario(string nome, string email, string senha, string contato, int telefone)
        {
            try
            {
                using (ServiceUsuarioClient usuario = new ServiceUsuario.ServiceUsuarioClient())
                {
                    usuario.SalvarUsuario(nome, email, senha, contato, telefone);
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

            using (ServiceUsuarioClient usuario = new ServiceUsuario.ServiceUsuarioClient())
            {
                var ret = await usuario.buscarPorIdAsync(id);
                return View(AutoMapper.Mapper.Map<UsuarioVM>(ret));
            }
        }

        public async Task<ActionResult> ListarTodos()
        {

            using (ServiceUsuarioClient usuario = new ServiceUsuario.ServiceUsuarioClient())
            {
                var ret = await usuario.ListarTodosAsync();
                return View(AutoMapper.Mapper.Map<UsuarioVM[]>(ret));
            }
        }
    }
}
