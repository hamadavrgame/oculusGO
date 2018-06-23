using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myConrollerMNG : MonoBehaviour {

    [SerializeField]
    private Rigidbody cubeRigid;

    [SerializeField]
    private float thrust;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //スペースキー押されたら
            cubeRigid.AddForce(transform.up * thrust, ForceMode.VelocityChange);
        }


        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            ////トリガー押されたら

            //yellow.SetActive(false);
        }

        if (OVRInput.GetDown(OVRInput.Button.Back))
        {
            ///戻るボタン押されたら

            //pink.SetActive(false);
        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
        {
            ////タッチパッド押されたら

            //pink.SetActive(true);
            ////pink.SetActive(false);
            cubeRigid.AddForce(transform.up * thrust, ForceMode.VelocityChange);
        }
        if (OVRInput.GetDown(OVRInput.Touch.PrimaryTouchpad))
        {
            ///タッチパッド触れられたら

        }
    }
}
