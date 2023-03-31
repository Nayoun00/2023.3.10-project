using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    //배열 5개 공간을 선언하고 이름을 array라고 함
    public int[] array = new int[5];
    public int[] points = { 83, 99, 53, 93, 15 };

    void Start()
    {
        //각각의 배열에 정수를 입력

        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        //for문을 통해 console창에 모든 array배열 안에 있는 0~4까지 내용을 표시

        for (int i = 0; i < 5; i++)
        {

            Debug.Log(array[i]);

        }

        Debug.Log("=========================================");

        //배열의 길이를 가져오는 변수(배열이름.Length)

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] > 90)
            {
                Debug.Log(points[i]);
            }
        }

        //합을 구하기 위해 임시적으로 sum변수 선언

        int sum = 0;

        //선언된 배열의 합 값

        for (int i = 0; i < points.Length; i++)
        {
            sum += points[i];
        }

        //값에서 배열 길이 만큼 나눔(평균값)

        int average = sum / points.Length;

        //평균값 출력

        Debug.Log(average);

    }

    void Update()
    {

    }
}
