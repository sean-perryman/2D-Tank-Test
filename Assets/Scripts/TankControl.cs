using UnityEngine;
using System.Collections;
using XboxCtrlrInput;
using System;

//Idea from here: http://gamedev.stackexchange.com/questions/97765/move-2d-tank-with-independently-controlled-treads
// http://www.scriptscoop.net/t/f2885b2638eb/unity-2d-gameobject-movement-and-rotation.html

public class TankControl : MonoBehaviour {
    /*private float rotation;
    public float speed;
    // Use this for initialization
    void Start () {
        rotation = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {       
        float lts = XCI.GetAxis(XboxAxis.LeftTrigger);
        float rts = XCI.GetAxis(XboxAxis.RightTrigger);
        
        float velocityR = rts * speed;
        float velocityL = lts * speed;

        float width = 1.0f;

        // "width" must be expressed in units
        rotation += (velocityR - velocityL) / width * Time.deltaTime;
        double newX = transform.position.x + 0.5 * (velocityR + velocityL) * Math.Cos(rotation) * Time.deltaTime;
        double newY = transform.position.y - 0.5 * (velocityR + velocityL) * Math.Sin(rotation) * Time.deltaTime;
        Vector3 oldTransform = new Vector3(transform.position.x, transform.position.y);
        Vector3 newTransform = Quaternion.Euler((float)newX, (float)newY, rotation);//new Vector3((float)newX, (float)newY);

        transform.Rotate(Quaternion.Euler((float)newX, (float)newY, rotation)); // = Quaternion.FromToRotation(oldTransform, newTransform);

    }*/

    public float speed;
    public float rotationSpeed;
    public float angleCorrect;

    //transform
    Transform myTrans;
    //object position
    Vector3 myPos;
    //object rotation
    Vector3 myRot;
    //object rotation 
    float angle;

    // Use this for initialization
    void Start()
    {
        myTrans = transform;
        myPos = myTrans.position;
        myRot = myTrans.rotation.eulerAngles;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //converting the object euler angle's magnitude from to Radians    
        angle = myTrans.eulerAngles.magnitude * Mathf.Deg2Rad + angleCorrect;
        
        //rotate object Right & Left
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRot.z -= rotationSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRot.z += rotationSpeed;
        }
        
        //move object Forward & Backward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myPos.x += (Mathf.Cos(angle) * speed) * Time.deltaTime;
            myPos.y += (Mathf.Sin(angle) * speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myPos.x -= (Mathf.Cos(angle) * speed) * Time.deltaTime;
            myPos.y -= (Mathf.Sin(angle) * speed) * Time.deltaTime;
        }
        
        //Apply
        myTrans.position = myPos;
        myTrans.rotation = Quaternion.Euler(myRot);

    }
}
