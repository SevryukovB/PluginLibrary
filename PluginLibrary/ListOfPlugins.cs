using System.Collections.Generic;
using PluginLibrary.Models;

namespace PluginLibrary
{
    /*Create class, that contains a collection of plugins and is a plugin. In this class, the modify method 
     * will apply all plugins from collection to input.*/
    public class ListOfPlugins<T> : IModifyPlugin<T> where T : Base, new()
    {
        public List<IModifyPlugin<T>> listPlugins = new List<IModifyPlugin<T>>()
        {
            new AbbreviationItems<T>(),
            new CamelCase<T>(),
            new GetItems<T>(),
            new ReverseList<T>(),
            new LineOfItems<T>()
        
        };

        public List<T> Modify(List<T> items)
        {
            listPlugins.ForEach(x=>x.Modify(items));
            return items;
        }
    }
}
