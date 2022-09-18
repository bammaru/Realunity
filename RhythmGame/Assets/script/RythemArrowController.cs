using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RythemArrowController : MonoBehaviour
{
    public RythmStartManager rythemStartManager;

    public List<GameObject> arrowList;
    public List<float> genTiming;
    public List<float> genDir;
    int genCount = 0;

    float deltaTime = 0.0f;


    // Update is called once per frame
    void Update()
    {
        if(rythemStartManager.isGameStart == false)
        {
            return;
        }

        if (genTiming.Count <= genCount)
        {
            return;
        }

        deltaTime += Time.deltaTime;
        if(deltaTime > genTiming[genCount])
        {
            GenArrow(genDir[genCount]);
            genCount++;
        }
    }

    public void GenArrow(float number)
    {
        Instantiate(arrowList[(int)number]);
    }
}
