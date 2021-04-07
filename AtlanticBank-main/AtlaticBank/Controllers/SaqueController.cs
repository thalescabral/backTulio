using AtlanticBankDomain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlaticBank.Controllers
{
    [Authorize]
    [ApiController]
    [Route("AtlanticBank/[controller]")]
    public class SaqueController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPost]
        /*public async Task<IActionResult> SaqueCashMachine(SaqueViewModel saqueViewModel)
        {
            try
            {
                var caixa = await _saquesService.SaqueAsync(saqueViewModel, _correlationId);

                if (caixa != null)
                {
                    await _caixaHub.Clients.All.SendAsync("atualizacaoCaixa", caixa);

                    //log

                    return Ok("Saque Efetuado com Sucesso");
                }
                else
                {
                    //log

                    return BadRequest("Saque invalido");
                }
            }
            catch (Exception ex)
            {
                //log

                throw;
            }
        }*/

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
