using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera; // ī�޶� main ���� ã�ƿ��� �� ���̴�.

    private void Awake()
    {
        _camera = Camera.main; // Scene �� �����ϴ� �±װ� ���� ī�޶��� ģ���� ã�ƿ��ڴٴ� �ǹ�.
    }

    // ��� �޼��� ��� : Move, Look, Fire ��� action �� �����ξ��µ� �� �տ� On �� ���̸� ������� �� �����޴� �Լ��� ����� �ִ� ��.
    public void OnMove(InputValue value)
    {
        //Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized; // normalize �ϴ� ���� : normalize �� �� ���ָ� ���� ������ ������ �밢�� ������ �뷫 1.5������ ������ (��Ÿ��� ������ ����..). �׷��� ������ normalized, �� �������ͷ� ����ٴ� �̾߱�.(�ƹ��� �� ���͸� ������ �ִ� �ص� ���� 1 �� �߶�����ڴ� !)
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        //Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>(); // ��ǥ�� ���� ������ normalized �� ��.
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= 0.9f)
        {
            CallLookEvent(newAim);
        }

    }
    public void OnAttack(InputValue value)
    {
       //Debug.Log("OnAttack" + value.ToString());

    }
}
