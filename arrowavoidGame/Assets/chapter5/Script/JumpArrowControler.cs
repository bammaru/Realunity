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
        //�����Ӹ��� ������� ���Ͻ�Ų��
        gameObject.transform.Translate(0, -0.03f, 0);

        //ȭ�� ������ ������ �Ҹ�
        if(gameObject.transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //�浹����
        Vector2 p1 = gameObject.transform.position; //arrow
        Vector2 p2 = this.player.transform.position; // player

        Vector2 dir = p1 - p2;

        float d = dir.magnitude;

        float r1 = 0.5f; //ȭ��ǥ�� �ݰ�
        float r2 = 1.0f; //�÷��̾��� �ݰ�
        
        //�������
        if(d <= r1 + r2)
        {
            GameObject director = GameObject.Find("GameManager");
            director.GetComponent<GameManager>().DecreaseHp();
            player.GetComponent<JumpPlayerControler>().isHit = true;

            
            Destroy(gameObject);
        }
       

    }


}
