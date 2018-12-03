using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CantinaApp.Core.ApplicationServices;
using CantinaApp.Core.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EASV_CantinaRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllergensController : ControllerBase
    {
        private readonly IAllergenServices _alrgService;

        public AllergensController(IAllergenServices alrgService)
        {
            _alrgService = alrgService;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<Allergen>> Get()
        {
            return _alrgService.GetAllergens();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<Allergen> Get(int id)
        {
            return _alrgService.FindAllergenId(id);
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult<Allergen> Post([FromBody]Allergen alrg)
        {
            return _alrgService.AddAllergen(alrg);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult<Allergen> Put(int id, [FromBody]Allergen alrg)
        {
            var entity = _alrgService.UpdateAllergen(alrg);
            entity.AllergenType = alrg.AllergenType;
            entity.FoodIconType = alrg.FoodIconType;
            return entity;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult<Allergen> Delete(int id)
        {
            return _alrgService.DeleteAllergen(id);
        }
    }
}