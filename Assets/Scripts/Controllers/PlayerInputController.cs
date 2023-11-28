using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera; // 카메라를 main 으로 찾아오게 할 것이다.

    private void Awake()
    {
        _camera = Camera.main; // Scene 에 존재하는 태그가 메인 카메라인 친구를 찾아오겠다는 의미.
    }

    // 밴드 메세지 방식 : Move, Look, Fire 라고 action 을 만들어두었는데 그 앞에 On 을 붙이면 실행됐을 때 돌려받는 함수를 만들어 주는 것.
    public void OnMove(InputValue value)
    {
        //Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized; // normalize 하는 이유 : normalize 를 안 해주면 직선 방향은 느린데 대각선 방향은 대략 1.5배정도 빠르다 (피타고라스 정리에 의해..). 그렇게 때문에 normalized, 즉 단위벡터로 만든다는 이야기.(아무리 긴 벡터를 가지고 있다 해도 길이 1 로 잘라버리겠다 !)
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        //Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>(); // 좌표가 오기 때문에 normalized 안 함.
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
