using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
1. 살아있으면 움직임
2. 앞으로만 이동함
3. 내 앞에 특정 물체가 있는지 체크
4. 만약 특정 물체가 있는데 그게 적이면 공격
5. 벽일경우에는 일정거리만큼 가까워지면 다른방향으로 전환
*/


public class WanderingAI : MonoBehaviour
{
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;

    [SerializeField] GameObject fireballPrefab;
    GameObject _fireball;

    bool _isAlive;
    

    // Start is called before the first frame update
    void Start()
    {
        _isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isAlive)
        {
            //살아있는경우
            transform.Translate(0, 0, speed * Time.deltaTime);
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            
            if(Physics.SphereCast(ray,0.75f,out hit))
            {
                GameObject hitobject = hit.transform.gameObject;

                if (hitobject.GetComponent<PlayerCharacter>())
                {
                    if(_fireball == null){
                        _fireball = Instantiate(fireballPrefab) as GameObject;
                        _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                        _fireball.transform.rotation = transform.rotation;
                    }
                }
                else if(hit.distance < obstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }

        }
    }

    public void SetAlive(bool alive)
    {
        _isAlive = alive;
    }

}
