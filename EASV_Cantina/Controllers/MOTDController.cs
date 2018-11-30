using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CantinaApp.Core.Entity.Entities;
using CantinaApp.InfaStructure.Data;
using CantinaApp.Core.ApplicationServices;

namespace EASV_CantinaRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MOTDController : ControllerBase
    {

        private readonly IMOTDServices _MOTDServices;

        public MOTDController(IMOTDServices MOTDServices)
        {
            _MOTDServices = MOTDServices;
        }



        // GET: api/MOTD
        [HttpGet]
        public IEnumerable<MOTD> GetMOTD()
        {
            return _MOTDServices.GetMOTDs();
        }

        // GET: api/MOTD/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMOTD([FromRoute] int id)
        {
            return null;
        }

        // PUT: api/MOTD/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMOTD([FromRoute] int id, [FromBody] MOTD mOTD)
        {
            return null;
        }

        // POST: api/MOTD
        [HttpPost]
        public ActionResult<MOTD>  post([FromBody]MOTD motd)
        {

            return _MOTDServices.AddMOTD(motd) ;
        }

        // DELETE: api/MOTD/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMOTD([FromRoute] int id)
        {
            return null;
        }
        
    }
}