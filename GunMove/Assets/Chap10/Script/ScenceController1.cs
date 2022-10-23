using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenceController1 : MonoBehaviour
{
    [SerializeField] GameObject ZombiePrefab;
    GameObject _Zombie;

    // Update is called once per frame
    void Update()
    {
        if (_Zombie == null)
        {
            float angle = Random.Range(0, 360);

            _Zombie = Instantiate(ZombiePrefab);
            _Zombie.transform.position = new Vector3(18.2f, 1.1f, -17.4f);
         
        }
    }
}

