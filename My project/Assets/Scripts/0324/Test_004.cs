using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_004 : MonoBehaviour
{
    public int hp = 180;
    public Text textUI;
    public Text hpTextUI;

    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))             //조건문으로 마우스 입력 감지 0인수는 왼쪽 마우스
        {
            hp -= 10;
        }
        if (Input.GetMouseButtonDown(1))            //조건문으로 마우스 입력 감지 1인수는 오른쪽 마우스
        {
            hp += 10;
        }

        if (hp <= 50)                           //50이하 일때
        {
            Debug.Log("도망 !");
            textUI.text = "도망 !";
        }
        else if (hp <= 200)                     //200이상 일때
        {
            Debug.Log("공격 !");
        }
        else
        {
            Debug.Log("방어 !");
        }

        hpTextUI.text = "HP : " + hp.ToString();
    }
}
