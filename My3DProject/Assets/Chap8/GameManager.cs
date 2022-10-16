using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    GameObject timerText;
    GameObject pointText;
    GameObject generator;
    float time = 30.0f;
    int point = 0;

    public void GetApple()
    {
        point += 100;
    }

    public void GetBomb()
    {
        point /= 2;
    }

    public void NoGet()
    {
        point -= 10;
    }
    public void Minus()
    {
        point *= 2;
    }

    private void Start()
    {
        generator = GameObject.Find("ItemGenerator");
        timerText = GameObject.Find("Time");
        pointText = GameObject.Find("Point");
    }

    private void Update()
    {
        time -= Time.deltaTime;

        if(this.time < 0)
        {
            this.time = 0;
            this.generator.GetComponent<ItemGenerator>().SetParameter(10000.0f, 0, 0);
        }
        else if (0 <= this.time && this.time < 5)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.9f, -0.04f, 3);
        }
        else if (5 <= this.time && this.time < 10)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.4f, -0.06f, 6);
        }
        else if (10 <= this.time && this.time < 20)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.7f, -0.04f, 4);
        }
        else if (20 <= this.time && this.time < 30)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(1.0f, -0.03f, 2);
        }

        

        timerText.GetComponent<TMP_Text>().text = time.ToString("F1");
        pointText.GetComponent<TMP_Text>().text = point.ToString() + " point";
    }
}
