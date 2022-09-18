using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowMove : MonoBehaviour
{
    public RythmStartManager myRythmStartManager;
    public StartButton mystartbutton;
    public bool isGameStart = false;
    float speed = 2f;

    //0 up | 1 down | 2 right | 3 left
    public int arrowNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        myRythmStartManager = GameObject.Find("GameManager").GetComponent<RythmStartManager>();
        isGameStart = false;
    }    

    // Update is called once per frame
    void Update()
    {

        if (mystartbutton.enabled == false)
        {
            transform.Translate(Vector3.up * 0.01f);
        }

        else if (mystartbutton.isGameStart == true)
        {
            transform.Translate(Vector3.up * 0.01f);   
        }
        else
        {
            transform.Translate(Vector3.up * 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "player")
        {
            PlayerCon pc = collision.gameObject.GetComponentInChildren<PlayerCon>();
            pc.arrows.RemoveAt(pc.arrows.FindIndex(A => A == gameObject));

            myRythmStartManager.HitPlayer();
            Destroy(gameObject);
        }
    }

}
