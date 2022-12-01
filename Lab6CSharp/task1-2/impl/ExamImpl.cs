namespace pro100user.task2;

//Іспит
public class ExamImpl : TestImpl
{
    public ExamImpl()
    {
        Console.WriteLine("Constructor \"ExamImpl\"");
    }
    
    public ExamImpl(string name) : base(name)
    {
        Console.WriteLine("Constructor \"ExamImpl\"");
    }
    
    public ExamImpl(string name, string finalDate) : base(name, finalDate)
    {
        Console.WriteLine("Constructor \"ExamImpl\"");
    }
    
    ~ExamImpl()
    {
        Console.WriteLine("Destructor \"ExamImpl\"");
    }
    
    public void Show()
    {
        Console.WriteLine($"ExamImpl \"{name}\" <- Test <- ExamImplination");
    }
}