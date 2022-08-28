using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcontroller : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //마우스 클릭했을때
        if (Input.GetMouseButtonDown(0))
        {
            //마우스의 위치좌표 저장
            startPos = Input.mousePosition;
        }

        //마우스 클릭에서 땠을때
        else if (Input.GetMouseButtonUp(0))
        {
            //마우스의 위치좌표 저장
            Vector2 endPos = Input.mousePosition;
            float swipeLiength = endPos.x - startPos.x;

            speed = swipeLiength / 500.0f;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(speed, 0, 0);

        speed *= 0.98f;

    }
}
