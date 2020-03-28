using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class DynamicGeneratedMonster : Monster
    {
        public Monster Clone()
        {
            Monster clone = JsonConvert.DeserializeObject<DynamicGeneratedMonster>(JsonConvert.SerializeObject(this));
            return clone;
        }
    }
}
