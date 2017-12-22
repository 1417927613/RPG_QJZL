using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    HeroModel hero;//属性模型
    GameObject nameText;//名字

    private void Start()
    {
        //为角色属性赋值
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
    }
}
