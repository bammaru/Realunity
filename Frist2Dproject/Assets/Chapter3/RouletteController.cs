using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //ȸ���ӵ�

    // Start is called before the first frame update
    void Start()
    {
        


    }
    bool isStop = true;
    bool isPlay = true;


    // Update is called once per frame
    void Update()
    {
        //Ŭ���ϸ� ȸ���Ѵ�.
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
            isPlay= true;
        }
        //�ӵ��� ���δ�.
        rotSpeed *= 0.96f;

        //ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��.
        gameObject.transform.Rotate(0, 0, rotSpeed); 

    }
}
