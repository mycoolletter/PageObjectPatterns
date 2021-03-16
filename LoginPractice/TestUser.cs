using NLog;

namespace LoginPractice
{
    internal class TestUser
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public TestUser(){}

        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public Gender GenderType { get; internal set; }
    }
}