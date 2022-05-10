using E_JOGOS.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_JOGOS.Controllers
{
    public class EquipeController : Controller
    {
        //ActionResult representa os varios codigos HTTP
        //Codigos HTTP https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status
        Equipe equipeModel = new Equipe();
        public IActionResult Index()
        {
            //ViewBag = reserva de espaço para armazenar informações para recuperar na view
            ViewBag.Equipes = equipeModel.LerEquipes();


            return View();

            public Action? Cadastrar(IFormCollection form)
            {
                //criar um objeto equipe a partir do frontend
                //IFormCollection
                Equipe novaEquipe = new Equipe();  
                novaEquipe.idEquipe = int.Parse(form["IdEquipe"]);
                novaEquipe.Nome = form["Nome"];
                novaEquipe.Imagem = form["Imagem"];
                //chamar a função CRIAR passando um objeto do tipo EQUIPE
                equipeModel.Criar(equipeModel);

                ViewBag.Equipes = equipeModel.LerEquipes();


                return null;
            }

        }
    }
}
