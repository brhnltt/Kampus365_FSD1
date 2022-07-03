namespace WebApplication1.SOLID
{
    public class UserBase
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual void Insert()
        {
            // inserting..
        }
    }

    public class User : UserBase
    {

    }

    public class Manager : UserBase
    {
        public string Department { get; set; }

        public override void Insert()
        {
            //base.Insert();
            // other inserting statement..
        }
    }

    public class Coordinator : UserBase
    {
        public string Company { get; set; }

        public override void Insert()
        {
            //base.Insert();
            // other inserting statement..
        }
    }

    public class SuperUser : UserBase
    {
        public string Company { get; set; }
        public string Section { get; set; }

        public override void Insert()
        {
            //base.Insert();
            // other inserting statement..
        }
    }

    public class UserManager
    {
        public void Add(UserBase user)
        {
            user.Insert();

            //if(type == "user")
            //{
            //    // Add user..
            //}
            //else if (type == "manager")
            //{
            //    // Add manager..
            //} 
            //else if (type == "coordinator")
            //{
            //    // Add Coordinator..
            //}
            //else
            //{
            //    // Add Other..
            //}
        }

        public void Add(string username)
        {
            // user insert..
        }

        public void AddOrEdit(string username)
        {
            if (IsExists(username))
            {
                Edit();
            }
            else
            {
                Add(username);
            }
        }

        public void Edit()
        {
            // user edit..
        }

        public bool IsExists(string username)
        {
            bool isExist = false;

            if (!isExist)
            {
                return false;
            }

            return true;
        }

        public void Delete()
        {

        }
    }
}
