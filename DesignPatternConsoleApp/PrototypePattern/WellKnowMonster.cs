using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class WellKnowMonster : Monster
    {
        public Monster Clone()
        {
            Monster clone = JsonConvert.DeserializeObject<WellKnowMonster>(JsonConvert.SerializeObject(this));
            return clone;
        }
    }
}
