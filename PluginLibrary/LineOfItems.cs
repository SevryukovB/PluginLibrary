using System.Collections.Generic;
using PluginLibrary.Models;

namespace PluginLibrary
{
    public class LineOfItems<T> : IModifyPlugin<T> where T : Base, new()
    {
        //Plugin for convert items to one line
        public List<T> Modify(List<T> param)
        {
            string line = "";
            param.ForEach(x => line+=x.Name+" ");
            param.Clear();
            param.Add(new T() {Name = line});
            return param;
        }
    }
}
