using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{
    public int herbNum = 1;                 //���� herbNum �����Ŀ� 1�� �Է�(public �߰� , �ν�â���� �����ֱ��ؼ� ����)
    void Start()
    {
        
        if (herbNum == 1)                //���ǽ� herbNum �� 1�� ��� �ȿ� ������ �����Ѵ�.
        {
            Debug.Log("ü���� 50 ȸ��"); //Console.Log â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�.
        }
        else
        {
            Debug.Log("ü���� -50 ");    //Console.Logâ��  ������ ������ ��� �ش� ������ ǥ���Ѵ�.
        }
    }

 
}
