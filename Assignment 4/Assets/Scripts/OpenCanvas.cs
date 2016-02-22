using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpenCanvas : MonoBehaviour {

	Canvas StatsCanvas;

	void Start(){
		StatsCanvas = gameObject.GetComponent<Canvas>();
		StatsCanvas.enabled = false;
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			StatsCanvas.enabled = !StatsCanvas.enabled;
		}

	}
}
