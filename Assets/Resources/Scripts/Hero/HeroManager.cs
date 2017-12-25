using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : MonoBehaviour
{
    #region 单例
    static HeroManager _instance;
    public static HeroManager Instance
    {
        get
        {
            return _instance;
        }
    }
    #endregion

    //---属性
    HeroModel hero;//属性模型
    GameObject nameText;//名字
    int hp;//hero血量
    int mp;//hero蓝量
    int exp;//hero经验


    private void Awake()
    {
        //给单例赋值
        _instance = this;
    }

    private void Start()
    {
        //1.为hero属性赋值
        hero = SetSQliteData.Instance().GetHeroData("hero_id", "001", hero);
        if(hero.Name == null)
        {
            //为hero定义一个名字

            //给角色名字赋值
            this.transform.Find("NameText").GetComponent<TextMesh>().text = hero.Name;
        }
        //2.为角色hp， mp，exp赋值
        hp = hero.Max_Hp;
        mp = hero.Max_Mp;
        exp = 0;        
    }


    private void OnApplicationQuit()
    {
        //更新数据模型，上传数据库
        SetSQliteData.Instance().UpdateDataBase(hero, "hero_id", "001");
    }


    /// <summary>
    /// 攻击
    /// </summary>
    /// <param name="target">目标</param>
    /// <param name="damage">伤害值</param>
    public void Attack(MonsterModelBase target, int damage)
    {
        target.Hp -= damage;
    }

    /// <summary>
    /// 被攻击
    /// </summary>
    /// <param name="damage">伤害值</param>
    public void BeAttacked(int damage)
    {
        this.hp -= damage;
    }
}
