using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {

	// Use this for initialization
	public GameObject TruckObj;
	public Transform Truck;
	public float smoothTime = 0.3f;
	public float height = 20;
	private Vector3 velocity = Vector3.zero;

	void FixedUpdate () {
		//Vector3 goalRot = new Vector3 

		Vector3 goalPos = Truck.position;
		goalPos.y = height + Truck.transform.position.y;
		transform.position = Vector3.SmoothDamp (transform.position, goalPos, ref velocity, smoothTime);

		transform.localEulerAngles =  new Vector3(70, TruckObj.transform.eulerAngles.y + 180, 0);
	}
}
