using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*该脚本负责角色动画的逻辑*/
[HideInInspector]
public class HeroAnimation : MonoBehaviour
{

    Animator _animator;

    private void Awake()
    {
        _animator = this.GetComponent<Animator>();
    }
    //jump
    public void Jump()
    {
        _animator.SetTrigger("jump");
    }
    //普攻
    public void OnPublicAttack()
    {
        _animator.SetTrigger("attack");
    }
    //1技能
    public void OnSkill1()
    {
        _animator.SetTrigger("skill01");
    }
    //2技能
    public void OnSkill2()
    {
        _animator.SetTrigger("skill02");
    }
    //3技能
    public void OnSkill3()
    {
        _animator.SetTrigger("skill03");
    }
    //死亡
    public void Dead()
    {
        _animator.SetTrigger("die");
    }
    //复活
    public void Rebirth()
    {
        _animator.SetTrigger("fuhuo");
    }
    //被攻击
    public void Hit()
    {
        _animator.SetTrigger("hit");
    }
    //被击倒
    public void Down()
    {
        _animator.SetTrigger("Down");
    }
}
