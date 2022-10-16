using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;
    AudioSource aud;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Apple")
        {
            GameManager.instance.GetApple();
            aud.PlayOneShot(appleSE);
        }
        else if(other.gameObject.tag == "Bomb")
        {
            GameManager.instance.GetBomb();
            aud.PlayOneShot(bombSE);
        }
        else
        {
            GameManager.instance.NoGet();
        }
        Destroy(other.gameObject);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
                //RounfToInt ¹Ý¿Ã¸²

            }
        }
    }
}
