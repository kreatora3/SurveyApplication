using System.Collections.Generic;
using SurveyApplication.DAL.Models;

namespace SurveyApplication.DAL.Repositories
{
    public class ResponseRepository : IResponseRepository
    {
        static List<FormResponse> responseList = new List<FormResponse>();

        public void Add(FormResponse response)
        {
            this.ResponseList.Add(response);
        }

        public IEnumerable<FormResponse> Get()
        {
            return this.ResponseList;
        }

        public List<FormResponse> ResponseList
        {
            get { return ResponseRepository.responseList; }
            set { ResponseRepository.responseList = value; }
        }
    }
}
