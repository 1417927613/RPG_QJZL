using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
 

public class CameraShake : MonoBehaviour
{
    
    /// <summary>
    /// 相机震动
    /// </summary>
    public void CameraShakePosition()
    {
        transform.DOShakePosition(1, new Vector3(2, 2, 0));
    }

    private void Awake()
    {
        //实现相机震动的触发条件
    }
}
