using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 怪物属性基类
/// </summary>
public class MonsterModelBase
{
    public int Level { set; get; }              //等级
    public int EmpiricValue { set; get; }       //杀死获得经验值
    public string Name { set; get; }            //名字
    public int Hp { set; get; }                 //血量
    public int PhysicsAttack { set; get; }      //物理攻击
    public int MagicAttack { set; get; }        //魔法攻击
    public int Armor { set; get; }              //护甲
    public int MagicResist { set; get; }        //魔抗
    public float AttackRate { set; get; }       //攻速(攻击间隔)
    public float RecoverRate { set; get; }      //恢复速率
    public float Speed { set; get; }            //移动速度
}

/// <summary>
/// 低级怪物属性
/// </summary>
public class LowMonsterModel : MonsterModelBase
{


}


/// <summary>
/// 中级怪物属性
/// </summary>
public class MiddleMonsterModel : MonsterModelBase
{

    public float Evade { set; get; }            //闪避概率
    public float CritOdd { set; get; }          //暴击几率
    public float CritTimes { set; get; }        //暴击倍数
}

/// <summary>
/// 高级怪物属性
/// </summary>
public class HighMonsterModel : MonsterModelBase
{

    public float Evade { set; get; }            //闪避概率
    public float CritOdd { set; get; }          //暴击几率
    public float CritTimes { set; get; }        //暴击倍数
    public float SkillColdTime { set; get; }    //技能冷却时间
}


/// <summary>
/// 最终boss属性（dragon）
/// </summary>
public class FinalBossModel : MonsterModelBase
{

    public float Evade { set; get; }            //闪避概率
    public float CritOdd { set; get; }          //暴击几率
    public float CritTimes { set; get; }        //暴击倍数
    public float SkillColdTime { set; get; }    //技能冷却时间
}

