using System.Collections.Generic;
using PluginLibrary.Models;

namespace PluginLibrary
{
    public class AbbreviationItems<T> : IModifyPlugin<T> where T : Base 
    {
        //Plugin for create Abbreviation
        public List<T> Modify(List<T> param)
        {
            param.ForEach(x => x.Name = x.Name.Substring(0,2));
            return param;
        }
    }
}
