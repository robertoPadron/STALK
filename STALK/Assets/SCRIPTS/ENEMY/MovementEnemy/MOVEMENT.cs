using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEMENT : MonoBehaviour {
    public float MovementSpeed;
    public float Rotation;
    public bool Arrived = false;
    public float Cooldown = 20f;
    public float FirstPosition; // antes estaba a 7 
    public float SecondPosition; // antes estaba a -8
    public bool Detected;
    public float Charge;
    float SecondCharge;
    public Transform PlayerPosition;
    public GameObject Bullet;



    // Use this for initialization
    void Start () {
      
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();

    }


    void EnemyMovement()
    {
       
            this.transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
       

        if (this.transform.position.x >= FirstPosition & Arrived == false)
        {
            Rotation = 20f;
            this.transform.Rotate(Vector3.up * Rotation * Time.deltaTime);
            Cooldown = Cooldown - 1 * Time.deltaTime;
            MovementSpeed = 0;
            if (Cooldown <= 0)
            {
                Cooldown = 9f;
                MovementSpeed = 3f;
                Arrived = true;
                Rotation = 0f;
            }
        }
        if (this.transform.position.x <= SecondPosition & Arrived == true)
        {
            MovementSpeed = 0;
            Rotation = 20f;
            this.transform.Rotate(Vector3.up * Rotation * Time.deltaTime);
            Cooldown = Cooldown - 1 * Time.deltaTime;
            if (Cooldown <= 0)
            {
                Rotation = 0;
                MovementSpeed = 3f;
                Cooldown = 9f;
                Arrived = false;
            }

        }
    }
}
