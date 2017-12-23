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

    HeroModel hero;//属性模型
    GameObject nameText;//名字

    private void Awake()
    {
        //给单例赋值
        _instance = this;
    }

    private void Start()
    {
        //1.为角色属性赋值
        hero = SetSQliteData.Instance().GetHeroData("hero_id", "001", hero);
        if(hero.Name == null)
        {
            //为角色定义一个名字

            //给名字赋值
            this.transform.Find("NameText").GetComponent<TextMesh>().text = hero.Name;
        }
        


    }

    private void OnApplicationQuit()
    {
        //更新数据模型，上传数据库
        SetSQliteData.Instance().UpdateDataBase(hero, "hero_id", "001");
    }
}
