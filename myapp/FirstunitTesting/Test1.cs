using Firstunittest;
namespace Firstunittestproj;

[TestClass]
public sealed class Test1
{   
    [TestMethod("test2")]
    
    public void Addition()
{

        Mathengine engine = new Mathengine();
        int actual = engine.add(4, 9);
        int expected = 9;
        Assert.AreEqual(expected, actual, "test is failed becuase bug is appeared");

}
   
}
