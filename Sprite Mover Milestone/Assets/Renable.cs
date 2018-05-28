using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renable : MonoBehaviour {
    private SpriteMover Reenable;

	// Use this for initialization
	void Start () {
        Reenable = GetComponent<SpriteMover>(); // same concept different naming convention for for the P component disable
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Reenable.enabled = !Reenable.enabled;
        }
    }
}
