using System.Web.Mvc;
using javax.swing.text.html;
//using System.Text.Encodings.Web; //deixou de ser usado
using System.Web;


namespace PwT4.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        /*public string Index()
        {
            return "Indice - Em construção PWT4...";
        }*/
        // Evocação do View Controler method em vez de responder diretamente como em cima
        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            //return ($"Este é o Métdo de Boas vindas {name}, Numero de vezes {numTimes} em ação... ");
            return HttpUtility.HtmlEncode($"Hello {name}, NumTimes is: {numTimes}");
            //return HTMLEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}