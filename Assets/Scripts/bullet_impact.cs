using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_impact : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    private void OnCollisionEnter(Collision collision)
        {
           
            if (collision.gameObject.CompareTag("Bullet")){
                audioSource.Play();
            }
        }
}
