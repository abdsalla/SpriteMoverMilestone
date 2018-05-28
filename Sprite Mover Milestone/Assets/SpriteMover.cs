using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour {
    private Transform Spritetransform; // creating a Transform called Spritetransform for later use
    public float movespeed; // creating a public float so that our designer can change the speed without going into the code
    private SpriteMover Move; // creating a void to reference move to use later
    private GameObject thisObject; // craeting a void for the destroying the sprite

    // Use this for initialization
    void Start() {
        Spritetransform = GetComponent<Transform>(); // storing our gameObjects transform information within it with GetComponent
        Move = GetComponent<SpriteMover>(); // storing our script in move
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            Spritetransform.position = Spritetransform.position + (Vector3.up * movespeed);   // this will move our sprite in the direction it is facing multiplied by the movespeed float   
        }
        if (Input.GetKey(KeyCode.S))
        {
            Spritetransform.position = Spritetransform.position + (Vector3.down * movespeed);    
        }
        if (Input.GetKey(KeyCode.A))
        {
            Spritetransform.position = Spritetransform.position + (Vector3.left * movespeed);   
        }
        if (Input.GetKey(KeyCode.D))
        {
            Spritetransform.position = Spritetransform.position + (Vector3.right * movespeed);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))  // when leftshift is pressed change movespeed to 1
        {
            movespeed = 1.0f;      
        }
        if (Input.GetKeyDown(KeyCode.RightShift))  // same for rightshift
        {
            movespeed = 1.0f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift)) // when shift is released it is set it back to 0.2
        {
            movespeed = 0.2f;
        }
        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            movespeed = 0.2f;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spritetransform.position = new Vector3(0, 0, 0); // when space is pressed move the transform of the object back to 0,0,0
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Move.enabled = !Move.enabled; // when P is pressed set move to whatever it isn't at the moment
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.gameObject.SetActive(false); // when Q is pressed set the gameobject this script is attached to to inactive

        }
        
    }



}
