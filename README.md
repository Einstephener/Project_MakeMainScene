# 💻Project_MakeMainScene
Chapter 3-2 Unity 게임개발 숙련 개인과제입니다.

### 🧾목차
1. [프로젝트에 구현된 요구사항](#프로젝트에-구현된-요구사항)
2. [개발환경](#개발환경)
3. [사용한 에셋](#사용한-에셋)
4. [게임 설명](#게임-설명)
5. [자체 피드백](#자체-피드백)


----

### 프로젝트에 구현된 요구사항
- 필수요구사항
    - 메인 화면 구성
        - 아이디
        - 레벨
        - 골드
        - Status 버튼(  - Status 보기)
        - Inventory 버튼( - Inventory 보기)
    - Status 보기
      - Status 버튼, Inventory 버튼 - 사라지기
      - 우측에 캐릭터 정보 표현
      - 뒤로가기 버튼을 누르면 1번 화면으로 이동
    - Inventory 보기
      - Status 버튼, Inventory 버튼 - 사라지기
      - 우측에 인벤토리 표시
      - 아이템을 클릭하면 장착관리
          - 아이템 장착 중 - X  : 장착 확인 팝업
          - 아이템 장착 중 - O  : 장착해제 확인 팝업
      - 장착중인 아이템은 표시     
- 선택요구사항
    - 상점 기능
      - 상점 버튼 추가
      
        
### 개발환경
- 윈도우 10
- 화면 비율 : [16:9]
- visual studio 2022
- unity 2022.3.2f1 / C#
  

### 사용한 에셋
- https://assetstore.unity.com/packages/2d/environments/free-platform-game-assets-85838
- https://assetstore.unity.com/packages/2d/characters/2d-character-sprite-animation-penguin-236747


### 게임 설명

![image](https://github.com/Einstephener/Project_MakeMainScene/assets/128495083/a937afc9-d865-43e1-bc99-838207a3b8e5)

|상태창|인벤토리|상점|
|---|---|---|
|![image](https://github.com/Einstephener/Project_MakeMainScene/assets/128495083/839c4116-c74c-4e8f-a11c-77d44de1db64)|![image](https://github.com/Einstephener/Project_MakeMainScene/assets/128495083/f693071e-03cc-4467-b18e-53c4c69de788)|![image](https://github.com/Einstephener/Project_MakeMainScene/assets/128495083/df8b9e51-431c-45c5-b55d-d7389f1240e9)|

- 처음 시작화면에 캐릭터 이름, 레벨, 경험치를 확인 할 수 있도록 만들었습니다.
- Status, Inventory, Shop으로 연결되는 버튼들을 만들었습니다.
- 아이템 클릭시 장착확인 Panel이 뜨며, 아이템 장착여부 아이콘이 뜨도록 만들었습니다.
- 미리 설정해놓은 아이템 갯수만큼 상점란에 아이템 구매창이 뜨도록 만들었습니다.


### 자체 피드백
- 아이템을 획득해야지 인벤토리가 해금되도록 하는 부분을 구현하지 못했습니다.
- 아이템 정보를 상점창에 연동되도록 만들지 못했습니다.
- 상점창 그래픽이 깨지는 부분을 해결하지 못했습니다.
- 아이템 장착 시 스탯이 바뀌는 부분을 구현하지 못했습니다.
- 상점에서 아이템 구매 기능을 만들지 못했습니다.
- 게임 시작시 null오류가 발생하는 부분을 수정하지 못했습니다.
