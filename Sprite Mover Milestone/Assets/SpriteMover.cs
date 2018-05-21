using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour {
    private Transform Spritetransform; // creating a Transform called Spritetransform for later use
    public float movespeed; // creating a public float so that our designer can change the speed without going into the code

    // Use this for initialization
    void Start() {
        Spritetransform = GetComponent<Transform>(); // storing our gameObjects transform information within it with GetComponent
	}
	
	// Update is called once per frame
	void Update () {
        Spritetransform.position = Spritetransform.position + (Vector3.right * movespeed);   // this will move our sprite in the direction it is facing multiplied by the movespeed float   
	}
}
