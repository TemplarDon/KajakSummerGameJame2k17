﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(other.name);
            other.GetComponent<PlayerController>().AddInspectObject(GetComponentInParent<Inspect>());
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().RemoveInspectObject(GetComponentInParent<Inspect>());
        }
    }
}
