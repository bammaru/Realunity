using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject CubePrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject Cube = Instantiate(CubePrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            Cube.GetComponent<CubeController>().Shoot(worldDir.normalized * 2000);
        }
    }
}
