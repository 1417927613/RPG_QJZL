using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroModel
{
    //----属性
    string name;//英雄名称
    public string Name { get { return name; } set { name = value; } }
    int money;//金币
    public int Money { get { return money; } set { money = value; } }
    int hp;//英雄血量
    public int Hp { get { return hp; } set { hp = value; } }
    int mp;//英雄蓝量
    public int Mp { get { return mp; } set { mp = value; } }
    int attack;//英雄攻击力
    public int Attack { get { return attack; } set { attack = value; } }
    int magicDamage;//魔法伤害
    public int MagicDamage { get { return magicDamage; } set { magicDamage = value; } }
    int armor;//护甲
    public int Armor { get { return armor; } set { armor = value; } }
    int magicInvocation;//魔抗
    public int MagicInvocation { get { return magicInvocation; } set { magicInvocation = value; } }
    double physicalVampire;//物理吸血
    public double PhysicalVampire { get { return physicalVampire; } set { physicalVampire = value; } }
    double magicVampire;//法术吸血
    public double MagicVampire { get { return magicVampire; } set { magicVampire = value; } }


}
