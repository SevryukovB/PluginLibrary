using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginLibrary;
using PluginLibrary.Models;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> lstCountry = new List<Country>() //List of countries
            {
                new Country(){Name = "Ukraine"},
                new Country(){Name = "Russia"},
                new Country(){Name = "England"}
            };

            List<City> lstCities = new List<City>() //List of cities
            {
                new City(){Name = "Kyiv"},
                new City(){Name = "Moscow"},
                new City(){Name = "Kaliningrad"}
            };

            //PLUGIN1
            #region
            Console.WriteLine("Plugin 1. Print input values:");
            lstCountry.ForEach(v => Console.WriteLine(v.Name)); //print input values

            GetItems<Country> getItems = new GetItems<Country>(); //we can use any type of Base model class 

            getItems.Modify(lstCountry); //Call modify method and return list of values

            Console.WriteLine();
            Console.WriteLine("Print values after modify:");
            lstCountry.ForEach(z=>Console.WriteLine(z.Name)); //print modify items
            Console.WriteLine();
            #endregion

            //PLUGIN2
            #region
            Console.WriteLine("Plugin 2. Print input values:");
            lstCountry.ForEach(v => Console.WriteLine(v.Name));

            AbbreviationItems<Country> abbreviationItems = new AbbreviationItems<Country>();
            abbreviationItems.Modify(lstCountry);

            Console.WriteLine();
            Console.WriteLine("Print values after modify:");
            lstCountry.ForEach(z => Console.WriteLine(z.Name));
            Console.WriteLine();
            #endregion

            //PLUGIN3
            #region
            Console.WriteLine("Plugin 3. Print input values:");
            lstCountry.ForEach(v => Console.WriteLine(v.Name));

            LineOfItems<Country> lineOfItems = new LineOfItems<Country>();
            lineOfItems.Modify(lstCountry);

            Console.WriteLine();
            Console.WriteLine("Print values after modify:");
            lstCountry.ForEach(z => Console.WriteLine(z.Name));
           // Console.WriteLine(lineOfItems.Modify(lstCountry));
            Console.WriteLine();
            #endregion

            //PLUGIN4
            #region
            Console.WriteLine("Plugin 4. Print input values:");
            lstCities.ForEach(v => Console.WriteLine(v.Name));

            ReverseList<City> sortList = new ReverseList<City>();
            sortList.Modify(lstCities);

            Console.WriteLine();
            Console.WriteLine("Print values after modify:");
            lstCities.ForEach(x => Console.WriteLine(x.Name));
            Console.WriteLine();
            #endregion


            //PLUGIN5
            #region
            Console.WriteLine("Plugin 5. Print input values:");
            lstCities.ForEach(v => Console.WriteLine(v.Name));

            CamelCase<City> camelCaseList = new CamelCase<City>();
            camelCaseList.Modify(lstCities);

            Console.WriteLine();
            Console.WriteLine("Print values after modify:");
            lstCities.ForEach(x => Console.WriteLine(x.Name));
            Console.WriteLine();
            #endregion

            //PLUGIN6
            //Plugin for modify some data from all plugins
            #region 
            Console.WriteLine("Plugin 6. Print input values:");
            lstCities.ForEach(v => Console.WriteLine(v.Name));

            ListOfPlugins<City> listOfPlugins = new ListOfPlugins<City>();
            listOfPlugins.Modify(lstCities);

            Console.WriteLine();
            Console.WriteLine("Print values after modify:");
            lstCities.ForEach(x => Console.WriteLine(x.Name));
            Console.WriteLine();
            #endregion


            //BaseClass who can use any plugin
            #region
            BaseClass<ReverseList<City>, City> hlBaseClass = new BaseClass<ReverseList<City>, City>
            {
                Data = new List<City>()
            {
                new City(){Name = "Kharkiv"},
                new City(){Name = "Lviv"},
                new City(){Name = "Doneck"}
            }
            };

            Console.WriteLine("Print before modify:");
            hlBaseClass.Data.ForEach(x => Console.WriteLine(x.Name));

            Console.WriteLine("\nPrint after modify:\n");

            hlBaseClass.Output();

            Console.WriteLine();
            #endregion


            //ModifyClass
            #region ModifyClass
            ModifyClass<ReverseList<City>, City> hlModifyClass = new ModifyClass<ReverseList<City>, City>
            {
                Data = new List<City>()
                {
                    new City(){Name = "London"},
                    new City(){Name = "Berlin"},
                    new City(){Name = "Prague"}
                }
            };
            hlModifyClass.Modify(hlModifyClass.Data).ForEach(x=>Console.WriteLine(x.Name));
            Console.ReadKey();
            #endregion
        }
    }
}
