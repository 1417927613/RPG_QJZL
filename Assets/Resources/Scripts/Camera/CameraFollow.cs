using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject target;//相机跟随的目标

    Vector3 offset;//目标偏移量
    
	void Awake ()
    {
        target = GameObject.FindGameObjectWithTag("Hero");
        offset = target.transform.position - this.transform.position;
    }
	
	void Update ()
    {
        this.transform.position = target.transform.position - offset;

    }
}
