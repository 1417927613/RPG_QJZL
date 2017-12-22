using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct WeaponStruct
{

}
public class HeroStatus
{
    
    //---属性
    string name;//名字
    public string Name { get { return name; } set { name = value; } }
    int hp;//血量
    public int Hp { get { return hp; } set { hp = value; } }
    int attack;//攻击力
    public int Attack { get { return attack; } set { attack = value; } }
    int defence;//防御力
    public int Defence { get { return defence; } set { defence = value; } }
    int level;//等级
    public int Level { get { return level; } set { level = value; } }
    WeaponStruct weapons;//装备栏
    public WeaponStruct Weapons { get { return weapons; } set { weapons = value; } }


    #region 单例
    static HeroStatus _instance;
    public static HeroStatus Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new HeroStatus(300, 30, 30, 1);
                _instance.weapons = new WeaponStruct();
            }
            return _instance;
        }
    }
    #endregion

    private HeroStatus(int hp, int attack, int defence, int level)
    {
        this.hp = hp;
        this.attack = attack;
        this.defence = defence;
        this.level = level;
    }
}
