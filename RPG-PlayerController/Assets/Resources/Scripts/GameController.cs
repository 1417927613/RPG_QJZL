using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    StreamingDataLoader loader;//资源复制

    void Awake()
    {
        //StreamingDataLoader加载脚本
        loader = gameObject.AddComponent<StreamingDataLoader>();
        loader.LoadWithPath(new string[] { ConstData.dataBase});
    }
	
}
