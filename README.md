# [필수요구사항완료]개인과제_스파르타 타운 만들기 (게더 클론)

---
### ✨Things i did :
- 필수요구사항
  - ✅ 캐릭터 만들기
    - Create Empty 를 통해 Player 를 만들고 Player 에 이미지를 드래그하여 추가.
  - ✅ 캐릭터 이동
    - InputSystem 을 사용하여 키보드 키 입력 (W(up), A(left), S(down), D(right) 와 방향키 ↑(up), ←(left), ↓(down), →(right)) 을 통해 캐릭터 이동 구현.
    - 캐릭터가 마우스 방향을 바라보도록 구현을 했는데 아직 수학적인 부분에서 공부가 더 필요한 파트다.<br>
    다음과 같이 코드를 작성하여 구현했다.<br>
      `float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;`<br>
      `characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;`
    
  - ✅ 방 만들기
    - Tilemap 과 2D Tile Palette 를 사용해 Floor, BackDesign, ForeDesign, Collision 구현.
    - 맵 만들 때 사용한 Assets 은 unity 게임 개발 입문 강의에서 사용한 이미지를 활용.
    - collider 를 이용해 캐릭터가 벽을 뚫고 넘어가지 못하도록 구현.
  - ✅ 카메라 따라가기
    - Player 안에 Main Camera 를 드래그해서 넣으면 아무 문제 없이 Player 의 움직임을 잘 따라가는 것을 확인했다.<br>
      하지만 이 방법은 확장성 측면에서 좋은 방법은 아니라고 이야기를 들어서<br>
      Package Manager - Cinemachine 을 통해 Virtual Camera 를 만들고 Player 를 Follow 하게끔 설정해서 카메라가 Player 를 따라가도록 구현했다.
    

---
### 📌TO-DOs :
- 선택요구사항
  - ⬜ 캐릭터 애니메이션 추가
  - ⬜ 이름 입력 시스템
  - ⬜ 캐릭터 선택 시스템
  - ⬜ 참석 인원 UI
  - ⬜ 인게임 캐릭터 선택
  - ⬜ 인게임 이름 바꾸기
  - ⬜ 시간 표시
  - ⬜ NPC 대화

---
### 과제 제출을 하며(a.k.a. 회고)
이번 개인과제는 첫 제출날짜에 필수요구사항을 모두 완료하고 제출할 수 있어서 아주 뿌듯하다.<br>
저번 개인과제 때 받은 피드백을 바탕으로 이번 과제를 할 때 신경을 많이 쓴 부분은 git 을 적극적으로 이용하는 것이었다.<br>
main 에서 branch 를 하나 따로 만들어서 거기서 commit 과 push, 그리고 merge 를 했다.<br>
commit 할 때에는 commit 의 내용을 직관적 & 명확하게 적어보려고 노력했다.

해설강의가 올라오면 참고해서 선택요구사항도 구현해보는 것을 목표로 하고 있다 !

다른 조원분들은 선택요구사항까지 구현을 하셨는데 나는 배우는 속도가 비교적 느리다보니<br>
팀과제 때 조원분들의 빠른 템포를 잘 따라갈 수 있을까 걱정이 살짝 되지만 *(나중 걱정은 나중에 하기로 하고 ~)*<br>
한편으로는 대단하신 조원분들을 만나 든든하기도 하고 이번에도 배울 게 참 많겠구나 생각이 든다.

\+<br>
추가공부할 것s :
- 유니티 스크립트 라이프 사이클 (e.g. 이벤트 함수의 실행 순서)
- Delegate, Func, Action
---
☘
