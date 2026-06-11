using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class КамераЧасти : MonoBehaviour {

	private Vector3 startV, endV;
	private Quaternion startQ, endQ;

	private bool move;
	private float offset = 0f, speed = 0.02f;
	
	public void Click(GameObject _target)
	{
		move = true;

        startV = transform.position;
        startQ = transform.rotation;

        Vector3 direction = (_target.transform.position - transform.position).normalized;
        endV = _target.transform.position - direction * 3f;
        endQ = Quaternion.LookRotation(direction);
    }

    private void Update() {
        if (move) {
            offset += speed;
            transform.position = Vector3.Lerp(startV, endV, offset);
            transform.rotation = Quaternion.Slerp(startQ, endQ, offset);
            if (offset >= 1f) {
                move = false;
                offset = 0f;
			}
		}
	}
}
