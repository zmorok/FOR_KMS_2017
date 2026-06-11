using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Анимация : MonoBehaviour {

	Animator _animator;
	bool isWorking = false;

	void Start () {
		_animator = gameObject.GetComponent<Animator>();
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q))
		{
			if (isWorking)
			{
				_animator.SetBool("wBool", false);
				
            }
			else
			{
                _animator.SetBool("wBool", true);
                
            }

			isWorking = !isWorking;
		}
	}
}
