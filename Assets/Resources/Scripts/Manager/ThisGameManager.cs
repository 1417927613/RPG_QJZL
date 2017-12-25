using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisGameManager : MonoBehaviour
{
    #region 单例
    static ThisGameManager _instance;
    public static ThisGameManager Instance
    {
        get
        {
            return _instance;
        }
    }
    #endregion

    StreamingDataLoader loader;//资源复制

    void Awake()
    {
        //1.给单例赋值
        _instance = this;
        //2.StreamingDataLoader加载脚本
        loader = gameObject.AddComponent<StreamingDataLoader>();
        loader.LoadWithPath(new string[] { ConstData.dataBase});
    }
	
}
