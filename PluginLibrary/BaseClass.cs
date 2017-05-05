using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PluginLibrary.Models;

namespace PluginLibrary
{
    /*Create a class, that will be a base class for all classes, which will work with plugins. 
     * This class must have a generic param-eter, which shows plugin type. Class must has a plugin property, 
     * data property and method for data output (eg. Print to console). Before output, data must be modified by plugin.
     */

    public class BaseClass<TPlugin, T> where TPlugin : IModifyPlugin<T>, new ()
                                    where T : Base
    {
        public TPlugin Plugin { get; set; }
        public virtual List<T> Data { get; set; }

        public BaseClass()
        {
            Plugin = new TPlugin();
        }

        public void Output()
        {
            Console.WriteLine($"Type of this plugin - {typeof(TPlugin).Name} ");
            Plugin.Modify(Data).ForEach(x=>Console.WriteLine(x.Name));
        }
    }
}
