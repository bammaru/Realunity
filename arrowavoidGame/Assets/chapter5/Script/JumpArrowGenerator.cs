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
        //Time.deltaTime <- 프레임과 프레임 사이의 시간 1초마다 무언가를 한다.
        delta += Time.deltaTime;
        Debug.Log(delta);
        if(delta > span)
        {
            delta = 0;
            GameObject genObj = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7); //-6 ~7 사이에 랜덤값에서 화살표 생성

            genObj.transform.position = new Vector3(px, 7, 0);
        }
        
    }
}
