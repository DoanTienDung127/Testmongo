namespace Testmongo.Models
{
    public class TestDatabaseSettings: ITestDatabaseSettings
    {
        public string TestCoursesCollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
