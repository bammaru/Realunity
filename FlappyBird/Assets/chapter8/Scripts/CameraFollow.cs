using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;

    private void LateUpdate()
    {
        if (Target == null)
            return;

        transform.position = new Vector3(Target.position.x + 2, transform.position.y, transform.position.z);
    }
}
