using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural
{
    /// <summary>
    /// Defines Flyweight object which repeats iteself.
    /// </summary>
    public class FlyWeight
    {
        public string Company { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyWebSite { get; set; }
        //Bulky Data
        public byte[] CompanyLogo { get; set; } 
    }
    public static class FlyWeightPointer
    {
        public static FlyWeight Company = new FlyWeight
        {
            Company = "Abc",
            CompanyLocation = "XYZ",
            CompanyWebSite = "www.abc.com"
        };
    }
    public class MyObject
    {
        public string Name { get; set; }
        public FlyWeight Company
        {
            get
            {
                return FlyWeightPointer.Company;
            }
        }
    
    }
}
