using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace CountryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegioController : Controller
    {
        private readonly IMyDbContext myDbContext;

        private readonly ILogger<CountryController> _logger;

        public RegioController(ILogger<CountryController> logger, IMyDbContext myDbContext)
        {
            _logger = logger;
            this.myDbContext = myDbContext;
        }

        [HttpGet("regions")]
        public Object GetAllRegio()
        {
            try
            {
                return myDbContext.SelectAllRegio();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("add")]
        public Object AddRegio(Regio regio)
        {
            try
            {
                return myDbContext.CreateRegio(regio.Regid, regio.Regname);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public Object UpdateRegio([FromRoute] int id, Regio regio)
        {
            try
            {
                /*
                List<SelectAllRegioReturnModel> reg = myDbContext.SelectRegio(id);
                if (reg.Count != 1)
                {
                    throw new Exception("SELECT ERROR");
                }
                else
                {
                    return myDbContext.UpdateRegio(regio.Regid, regio.Regname);
                }
                */
                throw new Exception("UPDATE ERROR");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("del/{id}")]
        public Object DeleteRegio([FromRoute] int id)
        {
            try
            {
                return myDbContext.DeleteRegio(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
