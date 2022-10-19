using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class shoot_gun : MonoBehaviour
{
    public static event Action GunFired;

    public GameObject bullet;
    private bool triggerPressed;
    private bool wasPressed;
    private float cooldown=0.0f;
    public GameObject gun;
    public GameObject barrel;

    [SerializeField]
    OVRGrabber leftHand;

    [SerializeField]
    private AudioSource audioSource;

    


    [SerializeField]
    OVRGrabber rightHand;
    // Start is called before the first frame update
    void Start()
    {
        gun = GameObject.Find("pistol");
        barrel = GameObject.Find("barrel");
    }

    // Update is called once per frame
    void Update()
    {
        OVRGrabber grabber =GetComponent<OVRGrabbable>().grabbedBy;
        //Debug.Log(grabber == leftHand);
        if ((grabber == leftHand && OVRInput.Get(OVRInput.RawButton.LIndexTrigger)) || (grabber == rightHand && OVRInput.Get(OVRInput.RawButton.RIndexTrigger))){
            triggerPressed = true;
        }else{
            triggerPressed = false;
        }
        

        if (cooldown >=0.5f ){
            if (!wasPressed && triggerPressed){
                //shoot
                Instantiate(bullet, barrel.transform.position , barrel.transform.rotation );
                audioSource.Play();
                cooldown =0.0f;
                GunFired?.Invoke();
            }

        }else {
            cooldown += UnityEngine.Time.deltaTime;
        }
        wasPressed = triggerPressed;
    

    }
}


