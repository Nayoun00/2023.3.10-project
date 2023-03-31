using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{

    // 인수도 반환값도 없는 메서드
    void SayHello()
    {
        Debug.Log("===================");
        Debug.Log("Hello");
        Debug.Log("===================");
    }

    //인수가 있는 메서드
    void CallName(string name)
    {
        Debug.Log("Hello " + name);
    }
    //인수와 반환값이 있는 메서드
    int Add(int a, int b)
    {
        //int함수를 선언했기 때문에 return도 int여야 함

        int c = a + b;
        return c;
    }
    void Start()
    {
        SayHello();
        SayHello();
        SayHello();

        CallName("Tom");
        CallName("Harry");
        CallName("Lora");

        //변수 answer선언
        //메서드 를 호출하여 2,3의 값을 입력 이후 return값을 answer에 입력
        int answer;
        answer = Add(2, 3);
        Debug.Log(answer);
        //함수에 변수를 넣지 않고도 Debug.Log의 인수로 사용 가능
        Debug.Log(Add(7, 9));

    }

}
