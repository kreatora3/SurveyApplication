using Microsoft.AspNetCore.Mvc;
using SurveyApplication.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SurveysController : ControllerBase
    {
        private ISurveyRepository repository;

        public SurveysController(ISurveyRepository surveyRepository)
        {
            this.repository = surveyRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repository.GetSurveys());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(repository.GetSurveyByID(id));
        }
    }
}
