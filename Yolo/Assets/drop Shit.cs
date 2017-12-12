using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropShit : MonoBehaviour {
    public GameObject fence;

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            print(Input.mousePosition);
            Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 12.51f));
            print(p);
            print(p.x);
            print(p.y);
            Instantiate(fence, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
        }

		Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
		Debug.DrawRay(transform.position, forward, Color.green);
		print ("draw");
	}
}

