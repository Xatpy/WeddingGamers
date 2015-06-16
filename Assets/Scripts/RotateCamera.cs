using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

	public float mouseSensitivityRightLeft = 5f;
	public float mouseSensitivityUpDown = 5f;
	
	float verticalRotation = 0;
	float verticalVelocity=0;
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
		//Rotation
		
		//right/left
		float rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensitivityRightLeft;
		transform.Rotate(0,rotLeftRight,0);
		
		//up/down
		float rotUpDown = Input.GetAxis ("Mouse Y") * mouseSensitivityUpDown;
		transform.Rotate(-rotUpDown,0,0);
	}
}
