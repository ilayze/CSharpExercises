using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational
{
    //Empty vocabulary of Actual object
    public interface IPeople
    {
        string GetName();
    }

    public class Villagers : IPeople
    {

        #region IPeople Members

        public string GetName()
        {
            return "Village Guy";
        }

        #endregion
    }

    public class CityPeople : IPeople
    {

        #region IPeople Members

        public string GetName()
        {
            return "City Guy";
        }

        #endregion
    }

    public enum PeopleType
    {
        RURAL,
        URBAN
    }

    /// <summary>
    /// Implementation of Factory - Used to create objects
    /// </summary>
    public class Factory
    {
        public IPeople GetPeople(PeopleType type)
        {
            IPeople people = null;
            switch (type)
            {
                case PeopleType.RURAL :
                    people = new Villagers();
                    break;
                case PeopleType.URBAN:
                    people = new CityPeople();
                    break;
                default:
                    break;
            }
            return people;
        }
    }
}
