using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    public void ReactToHit()
    {
        StartCoroutine(Die());

        WanderingAI behavior = GetComponent<WanderingAI>();
        if(behavior != null)
        {
            behavior.SetAlive(false);
        }
    }

    IEnumerator Die()
    {
        transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1.5f);

        Destroy(gameObject);
    }
}
