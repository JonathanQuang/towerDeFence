using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {

	

	// Use this for initialization
	void Start () {
		
	}
	
	public float speed = 5.0f;
	public float yOil = 0.0f;
	
	// Update is called once per frame
	void Update () {
		
		if (yOil > 360){
				yOil -= 360.0f;
		}
		if (yOil < 360){
			yOil += 360.0f;
		}
		
		transform.eulerAngles = new Vector3(45, yOil, 0);
		
		
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.A)) {
			transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.S)){
         transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(new Vector3(0,speed*Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.LeftControl)){
         transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
		}
		if(Input.GetKey(KeyCode.LeftShift)){
			transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
		}
		if(Input.GetKey(KeyCode.E)){
			yOil += speed * Time.deltaTime * 5.0f; 
		}
		if(Input.GetKey(KeyCode.Q)){
			yOil += -speed * Time.deltaTime * 5.0f;
		}
	}
}

