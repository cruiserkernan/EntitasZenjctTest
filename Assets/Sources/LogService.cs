
public class LogService : ILoggerService
{
    public void Log(string str)
    {
        UnityEngine.Debug.Log(str);
    }
}
