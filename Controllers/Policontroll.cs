using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvaBimestral.Models;

namespace ProvaBimestral.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Policontroll : ControllerBase
    {
        [HttpGet]
        public async Task <IActionResult> Get(int id)
        {
            return Ok("Dados  ");
        } 

        [HttpPost]
        public async Task <IActionResult> Post(Politico politico)
        {
            return Ok(" Político cadastrado");
        }
    }
}
