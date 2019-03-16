using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour, Collider_helper.collider_help_reciever
{
    public Transform snapObj; //Object being snapped
    float lastSnapTime; //store time when objects un-snapped
    public bool childsnap; //to determine whether or not you want to have the attached object be a child set the boolean to true or false
    Snap target; //is set to the snap script attached to the object you're snapping to


	void Start () {
        
	}
	
	
	void Update () {
        //Debug.Log("Snap Obj: "+snapObj);
	}

    
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        target = other.GetComponent<Snap>(); //target is set to other collider's object's snap script
        if (target && !target.childsnap && childsnap) //if there is a target and that target's childsnap boolean is false and this object's boolean is true
        {
            snapObj = target.transform;
            if (lastSnapTime + 0.1f < Time.time) //if there has been enough time since the last decoupling
            {
                //snap together
                snapObj.position = target.transform.position;
                snapObj.rotation = target.transform.rotation;
                snapObj.parent = target.transform;
            }
        }
    }
    public void OnTriggerExit(Collider other)
    {

        Debug.Log("exit");
        if (other.transform.GetInstanceID() == target.transform.GetInstanceID()) 
        {
            lastSnapTime = Time.time;
            snapObj.position = transform.position;
            snapObj.rotation = transform.rotation;
            snapObj.parent = transform;
        }
    }
}
