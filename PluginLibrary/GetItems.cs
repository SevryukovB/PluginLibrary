using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginLibrary.Models;

namespace PluginLibrary
{
    //Plugin for Up register for items
    public class GetItems<T> : IModifyPlugin<T> where T : Base
    {
        public List<T> Modify(List<T> param)
        {
            param.ForEach(x=>x.Name = x.Name.ToUpper());
            return param;
        }
    }
}
