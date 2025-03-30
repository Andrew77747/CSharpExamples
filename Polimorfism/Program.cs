using System;

namespace Polimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            C b = new C();
            D.Do(b);
        }
    }

    public class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public override void Foo()
        {
            Console.WriteLine("B");
        }
    }

    public class C : B
    {
        public override void Foo()
        {
            Console.WriteLine("C");
        }
    }

    public class D
    {
        public static void Do(A a)
        {
            a.Foo();
        }
    }
}
