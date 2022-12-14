using Microsoft.AspNetCore.Mvc;
using SurveyApplication.DAL.Models;
using SurveyApplication.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResponseController : ControllerBase
    {
        private IResponseRepository repository;

        public ResponseController(IResponseRepository responseRepository)
        {
            this.repository = responseRepository;
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var list = repository.Get();
            return Ok(list);
        }

        [HttpPost("{id:int}")]
        public ActionResult<FormResponse> Post(int id, [FromBody] FormResponse response)
        {


            // var rm = new FormResponse(){ Age= 15, Email = "dadaa@adada", FirstName ="Ivan", LastName="T", SurveyId=12};
            repository.Add(response);

            return Ok();
        }
    }
}
