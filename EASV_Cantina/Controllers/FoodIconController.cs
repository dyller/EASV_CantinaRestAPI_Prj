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
    public class FoodIconController : ControllerBase
    {
        private readonly IFoodIconServices _fdIcnService;

        public FoodIconController(IFoodIconServices fdIcnService)
        {
            _fdIcnService = fdIcnService;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<FoodIcon>> Get()
        {
            return _fdIcnService.GetFoodIcon();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<FoodIcon> Get(int id)
        {
            return _fdIcnService.FindFoodIconById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult<FoodIcon> Post([FromBody]FoodIcon icn)
        {
            return _fdIcnService.AddFoodIcon(icn);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult<FoodIcon> Put(int id, [FromBody]FoodIcon icn)
        {
            var entity = _fdIcnService.UpdateFoodIcon(icn);
            entity.FoodIconType = icn.FoodIconType;
            return entity;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult<FoodIcon> Delete(int id)
        {
            return _fdIcnService.DeleteFoodIcon(id);
        }
    }
}