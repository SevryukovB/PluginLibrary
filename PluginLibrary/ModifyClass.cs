using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginLibrary.Models;

namespace PluginLibrary
{
    /*Create a class, that will be a plugin and a pluginable at the same time. 
     * In it`s Modify method it will modify data by itself
        and by plugin (eg. Multiply number by 2 and apply plugin).*/

    public class ModifyClass<TPlugin, T> : BaseClass<TPlugin, T>, IModifyPlugin<T> where T : Base, new() 
                                                        where TPlugin : IModifyPlugin<T>, new()
    {
        
        public List<T> Modify(List<T> param)
        {
            Plugin.Modify(param);
            param.Insert(0, new T(){Name = $"This is {typeof(T).Name}"});
            return param;
        }
    }
}
