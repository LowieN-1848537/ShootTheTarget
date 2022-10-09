using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck_movement : MonoBehaviour
{
    [SerializeField]
    public GameObject duck;
    private Rigidbody m_body;
    float m_speed;
    bool rotate = false;
    private void OnCollisionEnter(Collision collision){
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "wall"){
        rotate = true;
        }
        

    }






    void Start()
    {
        duck = GameObject.Find("duck");
        m_body = GetComponent<Rigidbody>();
        m_speed = 0.3f;
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
