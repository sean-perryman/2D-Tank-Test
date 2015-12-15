using UnityEngine;
using System.Collections;
using XboxCtrlrInput;

public class TurretControl : MonoBehaviour {
    public float turnSpeed = 25.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Turret controls
        bool lbtn = XCI.GetButton(XboxButton.LeftBumper);
        bool rbtn = XCI.GetButton(XboxButton.RightBumper);

        if (lbtn && !rbtn) { transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime); }
        if (rbtn && !lbtn) { transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime); }
    }
}
