namespace DZ_Loger_Form
{
    public class FileLoggerProvider : ILoggerProvider
    {
        string path;
        public FileLoggerProvider(string path)
        {
            this.path = path;
        }
        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogers(path);
        }

        public void Dispose() { }
    }
}
