using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime <- �����Ӱ� ������ ������ �ð� 1�ʸ��� ���𰡸� �Ѵ�.
        delta += Time.deltaTime;
        Debug.Log(delta);
        if(delta > span)
        {
            delta = 0;
            GameObject genObj = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7); //-6 ~7 ���̿� ���������� ȭ��ǥ ����

            genObj.transform.position = new Vector3(px, 7, 0);
        }
        
    }
}
