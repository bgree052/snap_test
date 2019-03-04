using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snap : MonoBehaviour, collider_helper.collider_help_reciever
{
    public Transform snapObj;
    public Transform SnapTarget;
    bool snapped = false;
    private IEnumerator noSnap;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void OnTriggerEnter (Collider other)
    {
        Debug.Log("enter");
        if (snapped == false && other.transform.GetInstanceID() == SnapTarget.GetInstanceID())
        {
            snapObj.position = SnapTarget.position;
            snapObj.rotation = SnapTarget.rotation;
            snapObj.parent = SnapTarget;
            snapped = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {

        Debug.Log("exit");
        if (snapped == true && other.transform.GetInstanceID() == SnapTarget.GetInstanceID())
        {
            snapObj.position = transform.position;
            snapObj.rotation = transform.rotation;
            snapObj.parent = transform;
            snapped = false;
            StartCoroutine(noSnap);
        }
    }
}
