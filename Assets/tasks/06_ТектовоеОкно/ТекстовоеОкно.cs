using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ТекстовоеОкно : MonoBehaviour {

	bool active = false;

	public void Click(GameObject panel)
	{
		active = !active;
		panel.SetActive(active);
	}
}
