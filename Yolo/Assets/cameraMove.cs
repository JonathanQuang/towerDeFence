using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {

	

	// Use this for initialization
	void Start () {
		
	}
	
	public float speed = 5.0f;
	public float yOil = 0.0f;
	public GameObject fence;

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

		/*
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Debug.DrawRay(ray.origin,ray.direction);
		Physics.Raycast(ray, out hit);
		Debug.ClearDeveloperConsole ();
		print (hit.ToString());
		*/

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition); //Convert mouse position to raycast
		RaycastHit hit; //Create a RaycastHit variable to store the hit data into
		Vector3 clickedPosition; //Create a vector3 variable to store the clicked position in

		if (Input.GetMouseButtonDown (0) && Physics.Raycast (ray, out hit, 1000)) //If the user clicks the left mouse button and we hit an object with our raycast then
		{
			//clickedPosition = hit.point; //Store the hit position into the clicked position variable
			print(hit.point);
			Quaternion identityThing = new Quaternion (0, 0, 0, 0);
			Instantiate (fence, hit.point, identityThing);
		}




	}
}

