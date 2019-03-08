using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour, Collider_helper.collider_help_reciever
{
    public Transform snapObj;
    //bool snapped = false;
    private IEnumerator noSnap;
    float lastSnapTime;
    public bool cildsnap;
    Snap target;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Snap Obj: "+snapObj);
	}

    //to determine whether or not you want to have the attached object be a child ('cild') set the boolean to true or false
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        target = other.GetComponent<Snap>();
        if (target && !target.cildsnap && cildsnap)
        {
            if (lastSnapTime + 0.1f < Time.time)
            {
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
            //StartCoroutine(noSnap);
        }
    }
}
