using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StripsBL.Exceptions;
using StripsBL.Managers;
using StripsBL.Model;
using StripsREST.Mappers;
using StripsREST.Model.Output;

namespace StripsREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripsController : ControllerBase
    {
        private StripsManager stripsManager;
        private string url = "";

        public StripsController(StripsManager stripsManager)
        {
            this.stripsManager = stripsManager;
        }


        [HttpGet("{id}")]
        public ActionResult<ReeksDTO> GetReeksDetails(int id)
        {
            try
            {
                Reeks reeks = stripsManager.GetReeksDetails(id);

                if (reeks == null)
                {
                    return NotFound($"Reeks with ID {id} not found");
                }

                ReeksDTO reeksDTO = ReeksMapper.MapToReeksDTO(reeks);

                return Ok(reeksDTO);
            }
            catch (StripsManagerException ex)
            {
                return BadRequest(ex.Message);
            }
        }






    }
}
