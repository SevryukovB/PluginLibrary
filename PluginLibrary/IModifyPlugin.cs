using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginLibrary.Models;
namespace PluginLibrary
{
    public interface IModifyPlugin<T> where T : Base
    {
        List<T> Modify(List<T> param);
    }
}
