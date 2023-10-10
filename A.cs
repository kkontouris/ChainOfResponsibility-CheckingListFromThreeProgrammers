
//this class used from programmer A and he can add code in order to add his own code for the list(he does not know the elements of list)- concrete handler
public class A<T>:IExecutable<T>
{
    private IExecutable<T> next;
    public void SetNext(IExecutable<T> nextClass)
    {
        next = nextClass;
    }
    public void Execute(List<T> data)
    {
        Console.WriteLine("Class A is executed");
        next?.Execute(data);
       
    }

}
