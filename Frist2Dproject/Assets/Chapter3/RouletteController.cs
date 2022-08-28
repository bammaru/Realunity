using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //회전속도

    // Start is called before the first frame update
    void Start()
    {
        


    }
    bool isStop = true;
    bool isPlay = true;


    // Update is called once per frame
    void Update()
    {
        //클릭하면 회전한다.
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
            isPlay= true;
        }
        //속도를 줄인다.
        rotSpeed *= 0.96f;

        //회전 속도만큼 룰렛을 회전시킨다.
        gameObject.transform.Rotate(0, 0, rotSpeed); 

    }
}
