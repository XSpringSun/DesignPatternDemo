using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class MonsterRegistry
    {
        Dictionary<string, Monster> monsterDic = new Dictionary<string, Monster>();
        public void RegisterMonster(string key,Monster monster) {
            monsterDic.Add(key, monster);
        }
        public Monster GetMonster(string key) {
            Monster monster = monsterDic[key];
             return monster.Clone();
        }
    }
}
