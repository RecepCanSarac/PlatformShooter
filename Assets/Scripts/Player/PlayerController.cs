using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");


        _animator.SetFloat("Speed", Mathf.Abs(x));

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _animator.SetFloat("Speed", 2);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            _animator.SetFloat("Speed", .5f);
        }
    }

}
