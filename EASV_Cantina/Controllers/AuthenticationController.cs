using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CantinaApp.Core.DomainServices;
using CantinaApp.Core.Entity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EASV_CantinaRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserRepositories<Users> repository;

        public AuthenticationController(IUserRepositories<Users> repos)
        {
            repository = repos;
        }

        // GET: api/Todo
        [Authorize]
        [HttpGet]
        public IEnumerable<Users> GetAll()
        {
            return repository.GetAll();
        }

        // GET: api/Todo/5
        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            var item = repository.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // POST: api/Todo
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public IActionResult Post([FromBody] Users item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            repository.Add(item);

            return CreatedAtRoute("Get", new { id = item.Id }, item);
        }

        // PUT: api/Todo/5
        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Users item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var todo = repository.Get(id);
            if (todo == null)
            {
                return NotFound();
            }

            todo.Username = item.Username;
            todo.IsAdmin = item.IsAdmin;

            repository.Edit(todo);
            return new NoContentResult();
        }

        // DELETE: api/ApiWithActions/5
        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = repository.Get(id);
            if (todo == null)
            {
                return NotFound();
            }

            repository.Remove(id);
            return new NoContentResult();
        }
    }
}