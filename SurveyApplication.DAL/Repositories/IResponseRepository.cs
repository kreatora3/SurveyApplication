
using System.Collections.Generic;
using SurveyApplication.DAL.Models;

namespace SurveyApplication.DAL.Repositories
{
    public interface IResponseRepository
    {
        void Add(FormResponse response);
        IEnumerable<FormResponse> Get();
    }
}
