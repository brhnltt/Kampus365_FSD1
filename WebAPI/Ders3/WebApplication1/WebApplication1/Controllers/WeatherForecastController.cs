using Microsoft.AspNetCore.Mvc;
using WebApplication1.SOLID;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IUserDataAccess userDataAccess;

        public WeatherForecastController(IUserDataAccess userDataAccess)
        {
            this.userDataAccess = userDataAccess;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild",
            "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public void AddManager()
        {
            UserManager userManager = new UserManager();

            Manager manager = new Manager()
            {
                Name = "asd",
                Department = "asdasd",
                Email = "asdsa@sdad.com"
            };

            userManager.Add(manager);
        }

        public void AddUser()
        {
            UserManager userManager = new UserManager();

            SOLID.User user = new SOLID.User()
            {
                Name = "asd",
                Email = "asdsa@sdad.com"
            };

            userManager.Add(user);
        }

        public void AddSuperUser()
        {
            UserManager userManager = new UserManager();

            SOLID.SuperUser user = new SOLID.SuperUser()
            {
                Name = "asd",
                Email = "asdsa@sdad.com"
            };

            userManager.Add(user);
        }


        public void UseRobot()
        {
            Robot robot = new Robot();
            robot.Work();

            SuperManager superManager = new SuperManager();
            superManager.Salary = 10;
            superManager.Report();
            superManager.Work();
            superManager.Eat();

            Employee employee = new Employee();
            employee.Eat();
            employee.Work();
            employee.Salary = 20;
            
        }

        public void InsertUser()
        {
            userDataAccess.Insert();
        }

        public void UpdateUser()
        {
            userDataAccess.Update();
        }
    }
}