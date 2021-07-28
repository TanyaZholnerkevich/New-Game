using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    private Animator animator;
    [SerializeField] [Range(0, 1)] private float range;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetFloat("walk_run", range);
            range += 0.005f;
            if (range > 1f)
            {
                range = 1;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetFloat("walk_run", range);
            range -= 0.005f;
            if (range < 0f)
            {
                range = 0;
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetFloat("walk_jump", 1.1f);
        }
        else
        {
            animator.SetFloat("walk_jump", 0.9f);
        }
    }
}
