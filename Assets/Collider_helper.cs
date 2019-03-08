using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_helper : MonoBehaviour {
    public GameObject recieving;
    collider_help_reciever reciever;
    // Use this for initialization
    void Start () {
        reciever = recieving.GetComponent<collider_help_reciever>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay (Collider other)
    {
        reciever.OnTriggerEnter(other);
    }
    public interface collider_help_reciever
    {
        void OnTriggerEnter(Collider other);
    }

}

