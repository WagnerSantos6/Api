using ApiTarefasVsStudio.ModelsViews;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefasVsStudio.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        

       

       

        [HttpGet()]
        public HomeView Index()
        {
            return new HomeView
            {
                Mensagem = "Bem vindo a API do restaurante da Amanda Brittes",
                Documentacao = "/swagger"
            };
        }
    }
}