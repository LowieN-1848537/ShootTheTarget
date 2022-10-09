using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck_movement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody m_body;
    float m_speed;
    void Start()
    {
        
        m_body = GetComponent<Rigidbody>();
        m_speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        m_body.velocity = -transform.right * m_speed;
    }
}
