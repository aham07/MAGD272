using UnityEngine;
using System.Collections;

public class CloseCanvas : MonoBehaviour {

	Canvas MainCanvas;

	void Start(){
		MainCanvas = gameObject.GetComponent<Canvas>();
		MainCanvas.enabled = true;
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			MainCanvas.enabled = !MainCanvas.enabled;
		}

	}
}
