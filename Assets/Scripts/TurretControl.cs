using UnityEngine;
using System.Collections;
using XboxCtrlrInput;

public class TurretControl : MonoBehaviour {
    public float turnSpeed = 25.0f;
    public GameObject bulletPrefab;
    public int fireDelay = 0;
    public int turretFireDelay = 0;

    void Start () {
	
	}
	
	void Update () {
        //Turret controls
        bool lbtn = XCI.GetButton(XboxButton.LeftBumper);
        bool rbtn = XCI.GetButton(XboxButton.RightBumper);

        //Delay the movement of the turret so the bullet can leave
        if (turretFireDelay == 0)
        {
            if (lbtn && !rbtn) { transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime); }
            if (rbtn && !lbtn) { transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime); }
        }

        if (XCI.GetButton(XboxButton.A) && fireDelay >= 30)
        {
            turretFireDelay = 30;
            Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), transform.rotation);
            fireDelay = 0;
        }
        else { fireDelay++; }

        if (turretFireDelay > 0) { turretFireDelay--; }
    }
}
