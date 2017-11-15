using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    private Vector3 cameraVelocity = Vector3.zero;

    Vector3 offset;

	void Start ()
    {
        offset = transform.position - target.transform.position;

        transform.position = target.position + offset;
	}
	
	void LateUpdate ()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, target.transform.position, ref cameraVelocity, smoothSpeed);
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, target.transform.position, smoothSpeed);
        smoothedPosition.z = transform.position.z;
        transform.position = smoothedPosition;

        //transform.LookAt(target);
	}
}
