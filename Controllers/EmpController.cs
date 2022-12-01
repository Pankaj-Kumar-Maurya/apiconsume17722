using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using apiconsume17722.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace apiconsume17722.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Employee emp)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44346/api/Reg");
            string data = JsonConvert.SerializeObject(emp);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            client.PostAsync(client.BaseAddress,content);
            return View();
        }
    }
}