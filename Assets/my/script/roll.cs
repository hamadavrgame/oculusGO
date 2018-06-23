using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll : MonoBehaviour {

    [SerializeField]
    private Vector3 vec;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(vec, Space.World);
	}
}
