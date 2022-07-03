namespace WebApplication1.SOLID
{
    public class Robot : IEmployeeBase
    {
        public void Work()
        {
            // working..
        }
    }

    public class SuperManager : Employee
    {
        public void Report()
        {
            // reporting..
        }
    }

    public class Employee : IEmployee, IEmployeeBase
    {
        public int Salary { get; set; }

        public virtual void Work()
        {
            // working..
        }

        public virtual void Eat()
        {
            // eating..
        }
    }

    public interface IEmployee
    {
        int Salary { get; set; }

        void Eat(); 
    }

    public interface IEmployeeBase
    {
        void Work();
    }
}
