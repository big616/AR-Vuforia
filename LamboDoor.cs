using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamboDoor : MonoBehaviour {

	private float currAngle = 0;
	private float desiredAngle = 0;


	
	// Update is called once per frame
	void Update () {

		currAngle = Mathf.LerpAngle (currAngle, desiredAngle, Time.deltaTime *3f);
		transform.localEulerAngles = new Vector3 (currAngle, 0, 0);

	}

	void OpenDoors(){

		desiredAngle = 60f;
	}

	void CloseDoors(){
		desiredAngle = 0;
	}

		
	void OnTriggerEnter(Collider col){
		if (col.CompareTag ("MainCamera")) {
			OpenDoors ();
		}
	}
	void OnTriggerExit(Collider col){
		if (col.CompareTag ("MainCamera")) {
			CloseDoors ();
		}
	}
			
}
