using System;

namespace ObjectOrientedProgramming_Ders3_Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listem<MyType2, MyType1> listem = new Listem<MyType2, MyType1>();
        }
    }

    public interface IMyType
    {

    }

    public class MyBaseType
    {
        public int Value { get; set; }
    }

    //public abstract class MyType1 : MyBaseType, IMyType
    public class MyType1 : MyBaseType, IMyType
    {
        //private MyType1()
        //{

        //}
    }

    public class MyType2 : IMyType
    {

    }

    // Constraints(Kısıtlar)
    public class Listem<T, K>
        where T : class, IMyType, new()
        where K : class
    {
        
        // Metot seviyesinde generic kısıt belirleme
        public void Add<T1, T2>(T1 param1, T2 param2)
            where T1 : IMyType
            where T2 : class, new()
        {

        }
    }
}
