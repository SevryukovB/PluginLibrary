using System.Collections.Generic;
using PluginLibrary.Models;

namespace PluginLibrary
{
    public class ReverseList<T> : IModifyPlugin<T> where T : Base
    {
        //Plugin for sorting elements of list
        public List<T> Modify(List<T> param)
        {
            param.Reverse();
            return param;
        }
    }
}
