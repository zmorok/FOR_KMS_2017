using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Приближение : MonoBehaviour {

	[SerializeField] GameObject _target;
	private float min = 1f, max = 20f;

	private bool ControlPosition(Vector3 position)
	{
		float distance = Vector3.Distance(position, _target.transform.position);
		return distance > min && distance < max;
	}

	void Start () {
		transform.LookAt(_target.transform.position);
	}
	
	void Update () {
		float d = Input.GetAxis("Mouse ScrollWheel");
		if (d != 0)
		{
			Vector3 newPos = transform.position + transform.TransformDirection(Vector3.forward * d * 3);
			if (ControlPosition(newPos))
				transform.position = newPos;

			transform.LookAt(_target.transform.position);
		}

		if (Input.GetMouseButton(1))
		{
			float x = Input.GetAxis("Mouse X");
			float y = Input.GetAxis("Mouse Y");

			transform.RotateAround(_target.transform.position, Vector3.up, x);
            transform.RotateAround(_target.transform.position, transform.right, -y);
        }
	}
}
