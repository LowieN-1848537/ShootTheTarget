using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SceneManager.LoadScene("SampleScene");
    }
     private void OnCollisionEnter(Collision collision){
        if( collision.gameObject.tag == "Bullet"){
           
            SceneManager.LoadScene("SampleScene");
        }
     }
}
