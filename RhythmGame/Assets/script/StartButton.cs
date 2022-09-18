using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private bool state;
    public bool isGameStart = false;

    // Start is called before the first frame update
    void Start()
    {
        state = true;
        isGameStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //마우스입력받음
            if(state == true)
            {
                isGameStart = true;
                state = false;
                gameObject.SetActive(false);

            }

            else
            {
                gameObject.SetActive(true);
                isGameStart = false;
                state = true;
                
            }

        }
    }
}
