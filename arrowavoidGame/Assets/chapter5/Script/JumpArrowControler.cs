using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpArrowControler : MonoBehaviour
{
    //cat
    GameObject player;
    bool isHit = false;
    bool isOn = false;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 등속으로 낙하시킨다
        gameObject.transform.Translate(0, -0.03f, 0);

        //화면 밖으로 나가면 소멸
        if(gameObject.transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //충돌판정
        Vector2 p1 = gameObject.transform.position; //arrow
        Vector2 p2 = this.player.transform.position; // player

        Vector2 dir = p1 - p2;

        float d = dir.magnitude;

        float r1 = 0.5f; //화살표의 반경
        float r2 = 1.0f; //플레이어의 반경
        
        //닿은경우
        if(d <= r1 + r2)
        {
            GameObject director = GameObject.Find("GameManager");
            director.GetComponent<GameManager>().DecreaseHp();
            player.GetComponent<JumpPlayerControler>().isHit = true;

            
            Destroy(gameObject);
        }
       

    }


}
