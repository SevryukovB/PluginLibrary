using System;
using System.Collections.Generic;
using PluginLibrary.Models;

namespace PluginLibrary
{
    public class CamelCase<T> : IModifyPlugin<T> where T : Base
    {
        public List<T> Modify(List<T> param)
        {
        
            foreach (var item in param)
            {
                string temporaryString = "";
            
                for (int i = 0; i < item.Name.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        temporaryString += Char.ToUpper(item.Name[i]);
                    }
                    else
                    {
                        temporaryString += Char.ToLower(item.Name[i]);
                    }
                }
                item.Name = temporaryString;
            }
            return param;
        }
    }
}
