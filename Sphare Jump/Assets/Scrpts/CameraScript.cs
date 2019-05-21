using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public Transform target;
	public Vector3 offSet;
	public float smoothSpeed = 0.125f;

	private void LateUpdate()
	{
		Vector3 desiredPosition = target.position + offSet;
		Vector3 smoothPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
		transform.position = smoothPosition;

		transform.LookAt (target);
	}
}
