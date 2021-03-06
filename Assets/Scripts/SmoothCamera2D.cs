﻿using UnityEngine;
using System.Collections;

//From: http://answers.unity3d.com/questions/29183/2d-camera-smooth-follow.html
//Updated by Unity 5

public class SmoothCamera2D : MonoBehaviour
{
    public GameObject controlSurface;
    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 point = GetComponent<Camera>().WorldToViewportPoint(target.position);
            Vector3 delta = target.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
            controlSurface.transform.position = new Vector3(transform.position.x, transform.position.y - 4f, transform.position.x);
        }

    }
}