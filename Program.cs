using System;
using System.Collections;


public class Program
{
    static void Main(string[] args)
    {

        List<int> list = new List<int>();
        list.Add(55);
        list.Add(12);
 
        B<int> b = new B<int>();
        A<int> a = new A<int>();
        C<int> c = new C<int>();



        a.SetNext(c);
        c.SetNext(b);

        a.Execute(list);


    }
}