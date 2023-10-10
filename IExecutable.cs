
//handler interface
public interface IExecutable<T>
{
    void Execute(List<T> data);
    void SetNext(IExecutable<T> next);
}
