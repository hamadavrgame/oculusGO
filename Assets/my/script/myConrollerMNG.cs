using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//ゲームシーン用入力判定
public class myConrollerMNG : MonoBehaviour {

    [SerializeField]
    private Rigidbody cubeRigid;

    [SerializeField]
    private float thrust;

    [SerializeField]
    private float roll_thrust;

    // Update is called once per frame
    void Update()
    {

        myDebug_KeyBoardInputChk();      //キーボード入力判定

        oculusGoInputChk();             //oculusGO 入力判定

    }


    //キーボード入力判定
    private void myDebug_KeyBoardInputChk()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //スペースキー押されたら
            cubeRigid.AddForce(transform.up * thrust, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Zキー押されたら続けたら

            //回転を与える。
            cubeRigid.AddTorque((transform.up + transform.right + transform.forward) * roll_thrust, ForceMode.Acceleration);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);      //シーンID 0　へジャンプ。
        }

    }

    //oculusGO 入力判定
    private void oculusGoInputChk()
    {
        //if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            ////トリガー押されている間、

            //回転を与える。
        //    cubeRigid.AddTorque((transform.up + transform.right + transform.forward) * roll_thrust, ForceMode.Acceleration);
            cubeRigid.AddTorque((transform.up + transform.right + transform.forward) * roll_thrust, ForceMode.VelocityChange);

        }

        if (OVRInput.GetDown(OVRInput.Button.Back))
        {
            ///戻るボタン押されたら

            SceneManager.LoadScene(0);      //シーンID 0　へジャンプ。
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
        {
            ////タッチパッド押されたら

            cubeRigid.AddForce(transform.up * thrust, ForceMode.VelocityChange);
        }

        if (OVRInput.GetDown(OVRInput.Touch.PrimaryTouchpad))
        {
            ///タッチパッド触れられたら

        }

    }

}
