using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {

	// Use this for initialization
	public Transform Truck;
	public float smoothTime = 0.3f;
	public float height = 20;
	private Vector3 velocity = Vector3.zero;

	void FixedUpdate () {
		Vector3 goalPos = Truck.position;
		goalPos.y = height + Truck.transform.position.y;
		transform.position = Vector3.SmoothDamp (transform.position, goalPos, ref velocity, smoothTime);
	}
}
