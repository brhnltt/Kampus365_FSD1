using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Common
{
    public interface ILog
    {
        void Error(string message);
        void Info(string message);
        void Warning(string message);
    }

    public class Log : ILog
    {
        public void Error(string message)
        {

        }

        public void Warning(string message)
        {

        }

        public void Info(string message)
        {

        }
    }
}
