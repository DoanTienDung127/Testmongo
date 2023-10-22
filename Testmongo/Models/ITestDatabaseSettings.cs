namespace Testmongo.Models
{
    public interface ITestDatabaseSettings
    {
        string TestCoursesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
