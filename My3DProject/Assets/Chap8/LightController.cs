using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    Transform tf;
    float speed = -3.0f;

    void Start()
    {
        tf = transform;
    }

    // Update is called once per frame
    void Update()
    {
        tf.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
