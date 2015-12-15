using UnityEngine;
using System.Collections;
using XboxCtrlrInput;
using System;

//Idea from here: http://gamedev.stackexchange.com/questions/97765/move-2d-tank-with-independently-controlled-treads
// http://www.scriptscoop.net/t/f2885b2638eb/unity-2d-gameobject-movement-and-rotation.html

public class TankControl : MonoBehaviour {
    public float moveSpeed = 1.0f;
    public float turnSpeed = 25.0f;

    void Start () {
    }
	
	void Update () {
        //Tank movement controls
        float lts = XCI.GetAxis(XboxAxis.LeftTrigger);
        float rts = XCI.GetAxis(XboxAxis.RightTrigger);

        float turnLeft = turnSpeed * lts;
        float turnRight = turnSpeed * rts;

        if (rts > 0 && lts > 0)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        if (lts > 0) {
            transform.Rotate(Vector3.forward, -turnLeft * Time.deltaTime);
        }
        if (rts > 0) {
            transform.Rotate(Vector3.forward, turnRight * Time.deltaTime);
        }
    }
}
