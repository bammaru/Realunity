using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            bamsongi.GetComponent<BamsongCotroller>().Shoot(worldDir.normalized * 2000);
        }
    }
        
}
