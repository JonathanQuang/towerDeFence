using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropshit : MonoBehaviour
{
    public GameObject fence;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            print(Input.mousePosition);
            Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y));
            print(p);
            print(p.x);
            print(p.y);
            Instantiate(fence, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
        }
    }
}

