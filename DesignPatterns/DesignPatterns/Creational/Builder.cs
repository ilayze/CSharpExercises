using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational
{

    public interface IBuilder
    {
        string RunBulderTask1();
        string RunBuilderTask2();
    }

    public class Builder1 : IBuilder
    {

        #region IBuilder Members

        public string RunBulderTask1()
        {
            throw new ApplicationException("Task1");
        }

        public string RunBuilderTask2()
        {
            throw new ApplicationException("Task2");
        }

        #endregion
    }

    public class Builder2 : IBuilder
    {
        #region IBuilder Members

        public string RunBulderTask1()
        {
            return "Task3";
        }

        public string RunBuilderTask2()
        {
            return "Task4";
        }

        #endregion
    }

    public class Director
    {
        public IBuilder CreateBuilder(int type)
        {
            IBuilder builder = null;
            if (type == 1)
                builder = new Builder1();
            else
                builder = new Builder2();
            builder.RunBulderTask1();
            builder.RunBuilderTask2();
            return builder;
        }
    }
}
