using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATION : MonoBehaviour {
    public float RotateSpeed;
    public float Timer = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);

        Timer = Timer - 1 * Time.deltaTime;

        if (Timer <= 0)
        {
            RotateSpeed = -RotateSpeed;
            Timer = 20f;
        }
	}
}
