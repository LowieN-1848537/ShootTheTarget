using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck_movement : MonoBehaviour
{
    [SerializeField]
    public GameObject duck;
    [SerializeField]
    private Rigidbody m_body;
    [SerializeField]
    private ParticleSystem m_particles;
    [SerializeField]
    private GameObject m_prefab;

    float m_speed;
    bool rotate = false;


    private void OnCollisionEnter(Collision collision){
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "wall"){
        rotate = true;
        }else if( collision.gameObject.tag == "Bullet"){
           
            Instantiate(m_particles,  m_body.transform.position , m_body.transform.rotation);
            Object.Destroy(gameObject);
        }
        

    }






    void Start()
    {
        duck = GameObject.Find("duck");
        m_body = GetComponent<Rigidbody>();
        m_speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        m_body.velocity = - transform.right * m_speed;
        if (rotate){
            duck.transform.Rotate(0,90,0);
            rotate = false;
            Debug.Log("turned");
        }
    }
}
