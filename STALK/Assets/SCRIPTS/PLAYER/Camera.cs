using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject Player;
    public GameObject reference;
    private Vector3 distance;

    private void Start()
    {
        distance = transform.position - Player.transform.position;
    }

    private void LateUpdate()
    {
        distance = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * distance;

        transform.position = Player.transform.position + distance;
        transform.LookAt(Player.transform.position);

        Vector3 copiaRotation = new Vector3(0, transform.eulerAngles.y, 0);
        reference.transform.eulerAngles = copiaRotation;
    }
}
