using workshop.console;

namespace workshop.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PersonNameTest()
    {
        Person person = new Person();
        person.Name = "Test";
        Assert.AreEqual("Test", person.Name);
    }
}