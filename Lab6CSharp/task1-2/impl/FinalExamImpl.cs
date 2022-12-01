namespace pro100user.task2;

//Випускний іспит
public class FinalExamImpl : ExamImpl
{
    public FinalExamImpl()
    {
        Console.WriteLine("Constructor \"FinalExamImpl\"");
    }
    
    public FinalExamImpl(string name) : base(name)
    {
        Console.WriteLine("Constructor \"Exam\"");
    }
    
    public FinalExamImpl(string name, string finalDate) : base(name, finalDate)
    {
        Console.WriteLine("Constructor \"Exam\"");
    }
    
    ~FinalExamImpl()
    {
        Console.WriteLine("Destructor \"FinalExamImpl\"");
    }
    
    public void Show()
    {
        Console.WriteLine($"FinalExamImpl \"{name}\" <- Exam <- Test <- Examination");
    }
}