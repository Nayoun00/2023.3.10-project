using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int age;            //���� age�� ����
        age = 30;           //���� age�� 30�� ���� �Է�
        Debug.Log(age);     //age�� �Էµ� ���� ����Ƽ console â�� ������ 

        float height1 = 160.5f;     //height1�� 160.5 �� ����
        float height2;              //height2 ����

        height2 = height1;          //heught2�� height���� �Է�
        Debug.Log(height2);         //heoght2�� �Էµ� ���� ����Ƽ console â�� ������

        string name;                //name�� ����
        name = "sara";              //name�� sara �Է�
        Debug.Log(name);            //name�� �Էµ� ���� ����Ƽ console â�� ������  


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
