
//this class used from programmer B and he can add code in order to add his own code for the list(he does not know the elements of list)- concrete handler
public class B<T>:IExecutable<T> where T:IComparable<T>
{
    private IExecutable<T> next;

    public void SetNext(IExecutable<T> nextClass)
    {
        next = nextClass;
    }

    public void Execute(List<T> data)
    {
        // I want to now if the x variable has value
        // in case variable exists and has value greater than 10
        // stop the chain. Do not continue. In all other cases continue the chain
        if(HasValue(data))
        {
            if(GreaterThan10(data))
            {
                Console.WriteLine("I have to stop the chain");
                return;
            }
            else
            {
                Console.WriteLine("Class B is executed");
                next?.Execute(data);
            }
        }


    }
    public bool HasValue(List<T> data)
    {
        foreach(var item in data)
        {
            if (item!=null)
            {
                return true;
            }
        }
        return false;
    }
    public bool GreaterThan10(List<T> data)
    {
        foreach (var item in data)
        {
            if(Comparer<T>.Default.Compare(item,(T)Convert.ChangeType(10,typeof(T)))>0)
            {
                return true;
            }
        }
        return false;
    }

}
