﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target;
    public float smoothSpeed = 10f;

    public Vector3 offset;

    void LateUpdate() {
        Vector3 desiredPosition = target.position;
        desiredPosition.z = -10;
       // Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.smoothDeltaTime);
        transform.position = desiredPosition;

        //transform.LookAt(target);


      
       
    }
}
