using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Held : MonoBehaviour {
    //public Transform originalParent;

	// Use this for initialization
	void Start () {
        //originalParent = gameObject.transform.parent;
        
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(gameObject.transform.parent);
        //SET SNAP OBJ & TARGET
        //This won't work for held objects with multiple attach points.... :(
        if (gameObject.transform.parent != null) {
            if (gameObject.transform.parent.name == "RightHand")
            {
                GameObject.Find("RightHand").GetComponent<Snap>().snapObj = gameObject.transform;
                Debug.Log("SNAP OBJ SET");
            }
            if (gameObject.transform.parent.name == "LeftHand")
            {
                //GameObject.Find("RightHand").GetComponent<Snap>().SnapTarget = gameObject.transform;
                Debug.Log("SNAP TARGET SET");
            }
        }

    }
}
