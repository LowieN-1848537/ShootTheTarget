using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Duck_Spawner : MonoBehaviour
{
    
    [SerializeField]
    private GameObject duck;
    [SerializeField]
    private TextMeshPro scoretxtfield;
    [SerializeField]
    private AudioSource audioSource;


    private GameObject[] getCount;
    Vector3 position ;
    private int killCount =0;
    private bool isKillable;
    // Start is called before the first frame update
    void Start()
    {
        position = new Vector3(3.8f,0.26f,6.947f);
        scoretxtfield.SetText(killCount.ToString());
        Instantiate(duck, position, new Quaternion(0.0f,0.0f,0.0f,0.0f) );
        isKillable = true;
    }

    // Update is called once per frame
    void Update()
    {
        getCount = GameObject.FindGameObjectsWithTag ("duck");
        if(OVRInput.Get(OVRInput.Button.One)){
            SceneManager.LoadScene("SampleScene");
        }else if(getCount.Length < 1 && OVRInput.Get(OVRInput.Button.Two)){
                Instantiate(duck, position, new Quaternion(0.0f,0.0f,0.0f,0.0f) );
                isKillable = true;
        }else if (getCount.Length == 0 && isKillable){
            isKillable =false;
            //update score here
            audioSource.time = 24f;
            audioSource.Play();

            ++killCount;
            scoretxtfield.SetText(killCount.ToString());
        }
    }
}

