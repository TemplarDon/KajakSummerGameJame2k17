﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateList : MonoBehaviour {

    public GameObject elementPrefab;
    InventoryData invRef;

	// Use this for initialization
	void Start () {
        invRef = FindObjectOfType<InventoryData>();

        foreach (KeyValuePair<Item, int> pair in invRef.GetDictionary())
        {
            GameObject go = Instantiate(elementPrefab) as GameObject;
            go.GetComponent<ItemElement>().attachedItem = pair.Key;
            go.GetComponent<ItemElement>().amount = pair.Value;
            go.transform.parent = transform;
            go.transform.localScale = new Vector3(1, 1, 1); // Hardcode to (1,1,1) cus when spawned normally it scaled up to 1.8

            go.SetActive(true);

            Debug.Log("run");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
