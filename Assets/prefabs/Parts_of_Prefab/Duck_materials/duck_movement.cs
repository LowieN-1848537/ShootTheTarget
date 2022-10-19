using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class duck_movement : MonoBehaviour
{
    public static event Action ChickenDead;

    [SerializeField]
    public GameObject duck;
    [SerializeField]
    private Rigidbody m_body;
    [SerializeField]
    private ParticleSystem m_particles;

    float m_speed;
    bool rotate = false;


    private void OnCollisionEnter(Collision collision){
        
        if (collision.gameObject.tag == "wall"){
        rotate = true;
        }else if( collision.gameObject.tag == "Bullet"){
           
            Instantiate(m_particles,  m_body.transform.position , m_body.transform.rotation);
            UnityEngine.Object.Destroy(gameObject);
            ChickenDead?.Invoke();
        }
        

    }


    void Start()
    {
        
        duck = gameObject;
        m_body = GetComponent<Rigidbody>();
        m_speed = 0.7f;
        
    }

    // Update is called once per frame
    void Update()
    {
        m_body.velocity = - transform.right * m_speed;
        if (rotate){
            //int angle = Random.Range(110,250);
            m_speed = UnityEngine.Random.Range(0.5f,2f);
            duck.transform.Rotate(0,180,0);
            rotate = false;
            
        }
    }
}
