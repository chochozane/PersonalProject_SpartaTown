using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    PlayerInputController controller;
    [SerializeField] private Animator anim;

    private void Awake()
    {
        controller = GetComponent<PlayerInputController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += AnimState;
    }

    private void AnimState(Vector2 dir)
    {
        anim.SetBool("walk", dir.magnitude > 0f);
    }

}
