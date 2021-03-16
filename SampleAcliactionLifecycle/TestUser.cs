namespace SampleAcliactionLifecycle
{
    internal class TestUser
    {
        public TestUser(){}

        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public Gender GenderType { get; internal set; }
    }
}