using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;
    private int Power = 50;

    //메소드 Attack 생성
    public void Attack()
    {
        Debug.Log(this.Power + " 데미지를 입혔다.");
    }

    //메소드 Damage 생성
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + " 데미지를 입었다.");
    }
    public int GetHp()
    {
        return hp;
    }
}

public class Test_008 : MonoBehaviour
{
    public Text playerHp;
    public Text playerHp2;

    Player mPlayer = new Player();
    Player mPlayer2 = new Player();

    void Start()
    {
        //Player 메소드 Attack 호출
        //    mPlayer.Attack();
        //Player 메소드 Damage 호출
        //    mPlayer.Damage(30);
        //Player Hp 보여줌
        //    Debug.Log(mPlayer.GetHp());
    }

    void Update()
    {
        playerHp.text = "Player1 HP : " + mPlayer.GetHp().ToString();
        playerHp2.text = "Player2 HP : " + mPlayer2.GetHp().ToString();

        if (Input.GetMouseButtonDown(0))
        {
            mPlayer.Damage(1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            mPlayer2.Damage(1);
        }
    }
}
