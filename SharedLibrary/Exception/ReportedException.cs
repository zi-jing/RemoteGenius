namespace SharedLibrary.Exception
{
    public class ReportedException : System.Exception
    {
        public ReportedException() : base() { }

        public ReportedException(string message) : base(message) { }

        public ReportedException(string message, System.Exception innerException) : base(message, innerException) { }

    }
}
