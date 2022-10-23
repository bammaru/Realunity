using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenceController : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    GameObject _enemy;

    // Update is called once per frame
    void Update()
    {
        if (_enemy == null)
        {
            float angle = Random.Range(0, 360);

            _enemy = Instantiate(enemyPrefab);
            _enemy.transform.position = new Vector3(-6.67f, 1.1f, 14.55f);
            _enemy.transform.Rotate(0, angle, 0);
        }   
    }
}
