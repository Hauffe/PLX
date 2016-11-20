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


    }
}
