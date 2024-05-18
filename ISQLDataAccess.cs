namespace WebApp.Data.DataAccess
{
    public interface ISQLDataAccess
    {

         Task<IEnumerable<T>> GetData<T, P>(string spName, P parameters, string connnectionId = "DefaultConnection");

         Task SaveData<T>(string spName, T parameters, string connectionId = "DefaultConnection");
    }
}