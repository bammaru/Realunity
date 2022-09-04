using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayerControler : MonoBehaviour
{
    public bool isHit = false;
    bool isOn = false;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isHit == false)
        {
            //���� ȭ��ǥ = �����̵�
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.Translate(-0.05f, 0, 0);
            }

            //������ ȭ��ǥ = ������ �̵�

            if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.Translate(0.05f, 0, 0);
            }
        }
        else
        {
            delta += Time.deltaTime;
            if (delta > 0.7f)
            {
                delta = 0;
                isHit = false;
                //�����ִ°��
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                if (isOn == true)
                {
                    isOn = false;
                    gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    //����
                }
                else if (isOn == false)
                {
                    isOn = true;
                    gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    //�ѱ�
                }
            
            }
        }
    }
}

