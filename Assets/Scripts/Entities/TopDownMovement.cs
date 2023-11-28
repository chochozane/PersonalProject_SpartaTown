using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody; // ���� ó���� ���� rigidbody �غ� !

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move; // Move �� �����Ѵ� !
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction) // �̵� ó��
    {
        direction = direction * 5; // direction �� �޾ƿ��� �ӵ�(5)�� ���ؼ� velocity ���ӵ��� �������ִ� ��.

        _rigidbody.velocity = direction; // �׷��� �� ���ӵ���ŭ rigidbody �� �˾Ƽ� �����δ� ~!
    }
}
