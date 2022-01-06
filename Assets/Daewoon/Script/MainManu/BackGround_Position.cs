using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround_Position : MonoBehaviour
{
    [SerializeField]
    private Transform target; //현재 게임에서는 두개의 배경이 서로가 서로의 타겟
    [SerializeField]
    private float scrollRange = 9.9f;
    [SerializeField]
    private float moveSpeed = 3.0f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.left;
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
        if(transform.position.x <= -scrollRange)
        {
            transform.position = target.position + Vector3.left * scrollRange;
        }
    }
}
