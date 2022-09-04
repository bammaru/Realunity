using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatPlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxwalkSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //점프
        if (Input.GetKeyDown(KeyCode.UpArrow)&& rigid2D.velocity.y == 0)
        {
            animator.SetBool("JumpTrigger", true);
            rigid2D.AddForce(transform.up * jumpForce);
        }
        else
        {
            animator.SetBool("JumpTrigger", false);
        }

        //좌우이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }

        //플레이어 속도 체크 Abs : 절댓값
        float speedx = Mathf.Abs(rigid2D.velocity.x);

        //스피드제한
        if(speedx < maxwalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * this.walkForce);
        }


        //움직이는 방향 전환
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if(rigid2D.velocity.y == 0)
        {
            //플레이어 속도에 맞춰 에니메이션 속도 변경
            animator.speed = speedx / 2.0f;
        }
        else   //점프
        {
            animator.speed = 1.0f;
        }

        
        


        //플레이어가 화면밖으로 나갔다면 처음부터
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("Jumping");
        }

    }

    //골 도착
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //using Unityenginen.SceneManagement
        SceneManager.LoadScene("ClearScene");
    }

}
