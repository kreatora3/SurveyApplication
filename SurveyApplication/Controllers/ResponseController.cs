using Microsoft.AspNetCore.Mvc;
using SurveyApplication.DAL.Models;
using SurveyApplication.DAL.Repositories;
using ServiceStack.Text;
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
        public ActionResult<string> Get(int id)
        {
            var list = repository.Get();
            var result = CsvSerializer.SerializeToCsv<FormResponse>(list);
            return result;
        }

        [HttpPost("{id:int}")]
        public ActionResult<FormResponse> Post(int id, [FromBody] FormResponse response)
        {
            repository.Add(response);
            return CreatedAtAction("Get", new { id = response.SurveyId }, response);
        }
    }
}
