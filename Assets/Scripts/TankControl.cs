using UnityEngine;
using System.Collections;
using XboxCtrlrInput;
using System;

//Idea from here: http://gamedev.stackexchange.com/questions/97765/move-2d-tank-with-independently-controlled-treads
// http://www.scriptscoop.net/t/f2885b2638eb/unity-2d-gameobject-movement-and-rotation.html

public class TankControl : MonoBehaviour {
    float rotation;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        float dt = Time.deltaTime;
        float speed = 1;

        //float axisX = XCI.GetAxis(XboxAxis.LeftStickX, 1);
        //float axisY = XCI.GetAxis(XboxAxis.LeftStickY, 1);

        float lts = XCI.GetAxis(XboxAxis.LeftTrigger, 1);
        float rts = XCI.GetAxis(XboxAxis.RightTrigger, 1);

        float velocityR = rts * speed;
        float velocityL = lts * speed;

        float width = 1.0f;

        // "width" must be expressed in units
        rotation += (velocityR - velocityL) / width * dt;
        double newX = transform.position.x + 0.5 * (velocityR + velocityL) * Math.Cos(rotation) * dt;
        double newY = transform.position.y - 0.5 * (velocityR + velocityL) * Math.Sin(rotation) * dt;
        

    }
}
