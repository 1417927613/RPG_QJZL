using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAction : MonoBehaviour
{
    HeroStatus heroStatus;


    private void Awake()
    {
        heroStatus = HeroStatus.Instance;
    }

}
