using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody; // 물리 처리를 위해 rigidbody 준비 !

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move; // Move 를 구독한다 !
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction) // 이동 처리
    {
        direction = direction * 5; // direction 을 받아오면 속도(5)를 곱해서 velocity 가속도를 저장해주는 것.

        _rigidbody.velocity = direction; // 그러면 그 가속도만큼 rigidbody 가 알아서 움직인다 ~!
    }
}
