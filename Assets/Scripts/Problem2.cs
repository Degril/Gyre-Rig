public struct ApiSetup<T>
{
    
}

public static class ApiSetup
{
    public static void SetupObjectA(this ApiSetup<ObjectA> obj) { }
    public static void SetupObjectB(this ApiSetup<ObjectB> obj) { }
    
}
class Api
{
    public ApiSetup<T> For<T>(T obj)
    {
        return new ApiSetup<T>();
    }
}
interface ISomeInterfaceA
{ }
interface ISomeInterfaceB
{ }
public class ObjectA : ISomeInterfaceA
{ }
public class ObjectB : ISomeInterfaceB
{ }
class Problem2
{
    public void Setup()
    {
        Api apiObject = new Api();

        apiObject.For(new ObjectA()).SetupObjectA();
        apiObject.For(new ObjectB()).SetupObjectB();
    }
}