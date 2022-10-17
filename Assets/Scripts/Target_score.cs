using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Target_score : MonoBehaviour
{
    private Vector3 location;


    [SerializeField]
    private TextMeshPro scoretxtfield;

    private float radius = 0.3f;
    private int maxScore =10;

    private void OnCollisionEnter(Collision collision){
        StopAllCoroutines();
        location = gameObject.transform.position; //location of target
        Vector3 point = collision.GetContact(0).point; // point of impact
        Vector3 newLoc = (-point + location);    // relative position of impact vs target

        double distance = Math.Sqrt(Math.Pow(newLoc.x,2)+ Math.Pow(newLoc.y,2));
        Debug.Log(distance);
        int score =  (int)(10 -(distance/radius)*10)+1; 

        scoretxtfield.SetText(score.ToString());

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
