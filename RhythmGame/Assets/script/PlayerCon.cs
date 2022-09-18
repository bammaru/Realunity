using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    public List<GameObject> arrows = new List<GameObject>();
 
    // Update is called once per frame
    void Update()
    {
        //�� ��� ����
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            RemoveNode(0);
        }
        //�Ʒ� ��� ����
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            RemoveNode(1);
        }
        //������ ��� ����
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RemoveNode(2);
        }
        //���� ��� ����
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RemoveNode(3);
        }
    }
    
    public void RemoveNode(int ArrowDir)
    {

        for(int number = 0; number < arrows.Count; number++)
        {
            if(arrows[number].GetComponent<ArrowMove>().arrowNumber == ArrowDir)
            {
                Destroy(arrows[number]);
                arrows.RemoveAt(number);

                number--;
            }

            Debug.Log("�������");
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Arrow")
        {
            arrows.Add(collision.gameObject);
        }
    }
}
