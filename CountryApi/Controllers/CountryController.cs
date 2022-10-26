using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace CountryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        private readonly IMyDbContext myDbContext;

        private readonly ILogger<CountryController> _logger;

        public CountryController(ILogger<CountryController> logger, IMyDbContext myDbContext)
        {
            _logger = logger;
            this.myDbContext = myDbContext;
        }

        [HttpGet("countries")]
        public Object GetAllCountries()
        {
            try
            {
                List<SelectAllRegioReturnModel> regions = myDbContext.SelectAllRegio();
                List<SelectAllCountriesReturnModel> countries = myDbContext.SelectAllCountries();
                return countries;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }            
        }

        [HttpPost("add")]
        public Object AddCountry(Country country)
        {
            try
            {
                return myDbContext.CreateCountry(country.Ctyid, country.Ctyname, country.Ctyregid);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("filter/{id}")]
        public Object GetCountryFiltered([FromRoute] String id)
        {
            try
            {
                return myDbContext.SelectCountryNameContains(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPut("{id}")]
        public Object UpdateCountry([FromRoute] String id, Country country)
        {
            try
            {
                /*
                List<SelectCountryReturnModel> cty = myDbContext.SelectCountry(id);
                if(cty.Count != 1)
                {
                    throw new Exception("SELECT ERROR");
                }
                else
                {
                    return myDbContext.UpdateCountry(country.Ctyid, country.Ctyname, country.Ctyregid);
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
        public Object DeleteCountry([FromRoute] String id)
        {
            try
            {
                return myDbContext.DeleteCountry(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpDelete("delts")]
        public Object DeleteCountry(String[] ids)
        {
            try
            {
                foreach(String id in ids)
                {
                    myDbContext.DeleteCountry(id);
                }
                return Ok("Ok");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
