using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongCotroller : MonoBehaviour
{
    // Start is called before the first frame update
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    public void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        //isKinematic 위치고정을 할꺼냐 말꺼냐
        //GetComponent<ParticleSystem>().Play();

        if (collision.gameObject.name == "target")
        {
            GetComponent<ParticleSystem>().Play();
        }
    }

}
