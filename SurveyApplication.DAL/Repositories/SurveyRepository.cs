using SurveyApplication.DAL.Properties;

namespace SurveyApplication.DAL.Repositories
{
    public class SurveyRepository : ISurveyRepository
    {
        public string GetSurveyByID(int surveyId)
        {
            return Resources.details;
        }

        public string GetSurveys()
        {
            return Resources.list;
        }
    }
}
