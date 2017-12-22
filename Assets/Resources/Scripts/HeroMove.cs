using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    float heroSpeed = 8f;
    float rotateSpeed = 2f;

    //---组件
    CharacterController _charController;
    Animator _animator;

    private void Awake()
    {
        //获取角色控制器组件
        _charController = this.GetComponent<CharacterController>();
        //获取animator
        _animator = this.GetComponent<Animator>();
    }

    private void Update()
    {
        Move();//移动
    }

    //角色移动实现
    void Move()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        if (horizontal != 0 | vertical != 0)
        {
            _animator.SetBool("pao", true);
            transform.rotation = Quaternion.LookRotation(direction);
        }
        else
        {
            _animator.SetBool("pao", false);
        }        
        _charController.Move(direction * Time.deltaTime * heroSpeed);
        

    }


}
