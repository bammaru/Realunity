using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        //깃발과 차의 거리를 구하는 공식.
        float lenght = flag.transform.position.x - car.transform.position.x;

        distance.GetComponent<Text>().text = "남은거리 : " + lenght.ToString("F2");
    }
}
