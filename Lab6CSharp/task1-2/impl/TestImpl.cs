namespace pro100user.task2;

//Тест
public class TestImpl : Test
{
    protected string name;
    
    public TestImpl()
    {
        name = "somename";
        Console.WriteLine("Constructor \"TestImpl\"");
    }
    
    public TestImpl(string name)
    {
        Console.WriteLine("Constructor \"TestImpl\"");
    }
    
    public TestImpl(string name, string finalDate)
    {
        Console.WriteLine("Constructor \"TestImpl\"");
    }
    
    ~TestImpl()
    {
        Console.WriteLine("Destructor \"TestImpl\"");
    }
    
    public void Show()
    {
        Console.WriteLine($"TestImpl \"{name}\" <- Examination");
    }

    public void Close()
    {
        Console.WriteLine("Close");
    }
}