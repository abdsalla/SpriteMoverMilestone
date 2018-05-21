using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour {
    private Transform Spritetransform;
    public float movespeed;

    // Use this for initialization
    void Start() {
        Spritetransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        Spritetransform.position = Spritetransform.position + (Vector3.right * movespeed);      
	}
}
