
using System.Data;

namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        //initalize your testing objects here
        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name, "Product tester");
            Assert.AreEqual(job3.EmployerName.ToString(), "ACME");
            Assert.AreEqual(job3.EmployerLocation.ToString(), "Desert");
            Assert.AreEqual(job3.JobType.ToString(), "Quality control");
            Assert.AreEqual(job3.JobCoreCompetency.ToString(), "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.IsTrue(job3.ToString().Contains("Product tester"));
            Assert.IsTrue(job3.ToString().Contains("ACME"));
            Assert.IsTrue(job3.ToString().Contains("Desert"));
            Assert.IsTrue(job3.ToString().Contains("Quality control"));
            Assert.IsTrue(job3.ToString().Contains("Persistence"));
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.IsTrue(job2.ToString().Contains("Data not available"));
        }
    }
}






