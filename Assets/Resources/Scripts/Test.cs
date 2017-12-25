using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    HeroAnimation _animation;
    LowMonsterModel lowMonsterModel;

    void Start()
    {
        _animation = this.GetComponent<HeroAnimation>();
        //lowMonsterModel = SetSQliteData.Instance().LowMonster("level", "1");
        //Debug.Log(lowMonsterModel.PhysicsAttack + "--" + lowMonsterModel.MagicAttack);

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            _animation.OnPublicAttack();
        }
        if (Input.GetKey(KeyCode.J))
        {
            _animation.OnSkill1();
        }
        if (Input.GetKey(KeyCode.K))
        {
            _animation.OnSkill2();
        }
        if (Input.GetKey(KeyCode.L))
        {
            _animation.OnSkill3();
        }
    }
}
