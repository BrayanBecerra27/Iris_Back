using IrisBack.Model;
using IrisBusiness.Interfaces;
using IrisCore.Entities;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrisBack.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ILogger<ToDoController> _logger;
        private readonly IToDoBusiness _toDoBusiness;

        public ToDoController(ILogger<ToDoController> logger, IToDoBusiness toDoBusiness )
        {
            _logger = logger;
            _toDoBusiness = toDoBusiness;
        }

        [HttpGet]
        [Route("toDoList")]
        public async Task<IActionResult> GetToDoList(bool favorite)
        {
            try
            {
                return Ok(await _toDoBusiness.GetToDoList(favorite));//Ok(Mapper.Map<IEnumerable<MachineTypeViewModel>>(results));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get ToDo list: {ex}");
                return BadRequest("Error Occurred");
            }
        }

        [Route("addToDo")]
        [HttpPost]
        public async Task<IActionResult> PostAddToDoList([FromBody] ToDoModel toDo)
        {
            try
            {
                return Ok(await _toDoBusiness.AddToDoList(toDo.Adapt<ToDo>()));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to add ToDo list: {ex}");
                return BadRequest("Error Occurred");
            }

        }

        [Route("checkToDo")]
        [HttpPut]
        public async Task<IActionResult> PutToDoList(int id)
        {
            try
            {
                return Ok(await _toDoBusiness.PutToDoList(id));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to update ToDo list: {ex}");
                return BadRequest("Error Occurred");
            }
        }

        [Route("deleteToDo")]
        [HttpDelete]
        public async Task<IActionResult> DeleteToDoList(int id)
        {
            try
            {
                return Ok(await _toDoBusiness.DeleteToDoList(id));//Ok(Mapper.Map<IEnumerable<MachineTypeViewModel>>(results));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to delete ToDo list: {ex}");
                return BadRequest("Error Occurred");
            }
        }

        [Route("favoriteToDo")]
        [HttpPut]
        public async Task<IActionResult> PutFavoriteToDoList(int id)
        {
            try
            {
                return Ok(await _toDoBusiness.PutFavoriteToDoList(id));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to update ToDo list: {ex}");
                return BadRequest("Error Occurred");
            }
        }
    }
}
