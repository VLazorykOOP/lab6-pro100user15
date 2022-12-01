namespace pro100user.task2;

//Випробування
public class ExaminationImpl : Examination
{
    protected string name;
    
    public ExaminationImpl()
    {
        name = "somename";
        Console.WriteLine("Constructor \"ExaminationImpl\"");
    }
    
    public ExaminationImpl(string name)
    {
        Console.WriteLine("Constructor \"ExaminationImpl\"");
    }
    
    public ExaminationImpl(string name, string finalDate)
    {
        Console.WriteLine("Constructor \"ExaminationImpl\"");
    }
    
    ~ExaminationImpl()
    {
        Console.WriteLine("Destructor \"ExaminationImpl\"");
    }
    
    public void Show()
    {
        Console.WriteLine($"ExaminationImpl \"{name}\"");
    }
}