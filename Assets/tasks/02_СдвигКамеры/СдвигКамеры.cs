using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СдвигКамеры : MonoBehaviour {

	[SerializeField] GameObject _target;

    private float min = 1f;
	private float max = 20f;

    private float minY = 0f;
    private float maxY = 5f;

    private bool ControlPosition(Vector3 position)
    {
        float distance = Vector3.Distance(position, _target.transform.position);
        return distance > min && distance < max && position.y > minY && position.y < maxY;
    }

    void Update () {
        // движение камеры вдоль и вглубь
        float x = Input.GetAxis("Horizontal") / 3;
        float z = Input.GetAxis("Vertical") / 3;
        if (x != 0f || z != 0f)
		{
            Vector3 newPos = transform.position + transform.TransformDirection(new Vector3(x, 0f, z));
            if (ControlPosition(newPos))
                transform.position = newPos;
        }

        // поворот камеры
		if (Input.GetMouseButton(1))
		{
			float xA = Input.GetAxis("Mouse X");
			transform.RotateAround(transform.position, Vector3.up, xA);

            float yA = Input.GetAxis("Mouse Y");
            transform.RotateAround(transform.position, transform.right, -yA);
        }
    }
}
