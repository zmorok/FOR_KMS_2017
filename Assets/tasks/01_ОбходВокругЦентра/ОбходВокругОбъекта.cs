using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ОбходВокругОбъекта : MonoBehaviour {
	[SerializeField] GameObject _target;

	void Start()
	{
		Vector3 pos = _target.transform.position;
		gameObject.transform.position = new Vector3(pos.x, pos.y + 4, pos.z - 4);
        transform.LookAt(_target.transform.position);
    }

	void Update () {
		if (Input.GetMouseButton(1))
		{
			float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");
            transform.RotateAround(_target.transform.position, Vector3.up, x * 3f);
            transform.RotateAround(_target.transform.position, transform.right, -y * 3f);
        }	
	}
}