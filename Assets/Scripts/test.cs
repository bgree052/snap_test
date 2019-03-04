using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    void Awake() { GetComponent<Rigidbody>().velocity += transform.forward ; }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");
    }
}
