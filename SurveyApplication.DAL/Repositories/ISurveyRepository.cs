namespace SurveyApplication.DAL.Repositories
{
    public interface ISurveyRepository
    {
        string GetSurveys();
        string GetSurveyByID(int surveyId);
    }
}
