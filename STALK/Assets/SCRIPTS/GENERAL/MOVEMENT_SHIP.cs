using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEMENT_SHIP : MonoBehaviour {
    public float MovementSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.up * MovementSpeed * Time.deltaTime);

        if (this.transform.position.y >= -60)
        {
            MovementSpeed = -MovementSpeed;
        }
        if (this.transform.position.y <= -70)
        {
            MovementSpeed = -MovementSpeed;
        }
	}
}
