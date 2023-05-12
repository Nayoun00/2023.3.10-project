using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;          //적의 속도 선언
    public float rotationSpeed = 1.0f;   //적 포탑회전속도

    public GameObject bulletPrefab;     //총알 프리팹
    public GameObject enemyPiovt;       //적 포탑 피봇

    public Transform firePoint;         //발사 위치
    public float fireRate = 1.0f;       //발사 속도
    public float nextFireTime;


    private Rigidbody rb;               //Rigidbody 선언
    private Transform player;           //플레이어 위치 가져오기 위해 선언

    void Start()
    {
        rb = GetComponent<Rigidbody>();             //시작할떄 자기 자신의 Rigidbody 를 받아온다.
        player = GameObject.FindGameObjectWithTag("Player").transform;         //Scene에서 Player Tag 를 가진 오브젝트를 가져와서 Transform 을 참조
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {


            if (Vector3.Distance(player.position, transform.position) > 1.0f)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
            }


            //포탑회전
            Vector3 targetDirection = (player.position - enemyPiovt.transform.position).normalized;
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            enemyPiovt.transform.rotation = Quaternion.Lerp(enemyPiovt.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);


            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1.0f / fireRate;
                GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
                temp.GetComponent<ProjectileMove>().bulletType = ProjectileMove.BULLETTYPE.ENEMY;
            }
        }
    }
}
