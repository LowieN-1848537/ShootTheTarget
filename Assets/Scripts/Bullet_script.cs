using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_script : MonoBehaviour
{
    [SerializeField]
    float m_speed;

    
    private Rigidbody m_body;
    

    private void OnCollisionEnter(Collision collision){
        Debug.Log(collision.gameObject.tag);
        //if (collision.gameObject.tag == "target"){
            Object.Destroy(gameObject);
        //}
        

    }





    // Start is called before the first frame update

    void Start()
    {
        Object.Destroy(gameObject, 2);
        m_body = GetComponent<Rigidbody>();
     
    }

    // Update is called once per frame
    void Update()
    {
        m_body.velocity = -transform.right * m_speed;
    }
}
