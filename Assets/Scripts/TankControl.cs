using UnityEngine;
using System.Collections;
using XboxCtrlrInput;
using System;

//Idea from here: http://gamedev.stackexchange.com/questions/97765/move-2d-tank-with-independently-controlled-treads
// http://www.scriptscoop.net/t/f2885b2638eb/unity-2d-gameobject-movement-and-rotation.html

public class TankControl : MonoBehaviour {
    public float speed;

    private Transform trans;
    private Vector3 rot;
    private Vector3 pos;
    float angle;

    void Start () {
        trans = transform;
        pos = trans.position;
        rot = trans.rotation.eulerAngles;
    }
	
	// Update is called once per frame
	void Update () {
        angle = trans.eulerAngles.magnitude * Mathf.Deg2Rad;

        float lts = XCI.GetAxis(XboxAxis.LeftTrigger);
        float rts = XCI.GetAxis(XboxAxis.RightTrigger);
        
        float velocityR = rts * speed;
        float velocityL = lts * speed;

        if (velocityL > 0 && velocityR > 0)
        {
            pos.x += (Mathf.Cos(angle) * speed) * Time.deltaTime;
            pos.y += (Mathf.Sin(angle) * speed) * Time.deltaTime;
        }

        else if (velocityL > 0) { rot.z -= velocityL; }
        else if (velocityR > 0) { rot.z += velocityR; }
                
        trans.position = pos;
        trans.rotation = Quaternion.Euler(rot);
    }
}
