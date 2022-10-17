using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Duck_Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject duck;
    
    Vector3 position ;
    // Start is called before the first frame update
    void Start()
    {
        position = new Vector3(3.8f,0.26f,6.947f);
        
        Instantiate(duck, position, new Quaternion(0.0f,0.0f,0.0f,0.0f) );
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.One)){
            SceneManager.LoadScene("SampleScene");
        }else if(OVRInput.Get(OVRInput.Button.Two)){
            Instantiate(duck, position, new Quaternion(0.0f,0.0f,0.0f,0.0f) );
        }
    }
}
