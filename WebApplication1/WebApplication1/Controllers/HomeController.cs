using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication1.Models;
using WebApplication3.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        HttpClient client = new HttpClient();
        public async Task<ActionResult> Index()
        {
            var retornoDaOutraApi = await SelectAllEndereco();

            ViewBag.Title = "Home Page";

            return View(retornoDaOutraApi);

        }

        public async Task<List<Endereco>> SelectAllEndereco()
        {
            try
            {
                string url = "https://localhost:44374/api/Endereco";
                var response = await client.GetStringAsync(url);
                var api1 = JsonConvert.DeserializeObject<List<Endereco>>(response);
                return api1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        HttpClient CadastroC = new HttpClient();
        public async Task<ActionResult> IndexC()
        {
   
            var retornoDaOutraApiCt = await SelectAllCadastroTeste();
            ViewBag.Title = "Home Page";

            return View(retornoDaOutraApiCt);
        }

        public async Task<List<CadastroTeste>> SelectAllCadastroTeste()
        {
            try
            {
                string url = "https://localhost:44374/api/CadastroTeste";
                var response = await client.GetStringAsync(url);
                var api1 = JsonConvert.DeserializeObject<List<CadastroTeste>>(response);
                return api1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        HttpClient CadastroT = new HttpClient();
        public async Task<ActionResult> IndexT()
        {

            var retornoDaOutraApiT = await SelectAllTransporte();
            ViewBag.Title = "Home Page";

            return View(retornoDaOutraApiT);
        }

        public async Task<List<Transporte>> SelectAllTransporte()
        {
            try
            {
                string url = "https://localhost:44374/api/Transporte";
                var response = await client.GetStringAsync(url);
                var api1 = JsonConvert.DeserializeObject<List<Transporte>>(response);
                return api1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
