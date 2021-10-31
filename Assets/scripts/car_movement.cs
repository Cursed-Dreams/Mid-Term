using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_movement : MonoBehaviour
{
    public float speed = 1.0f;
    public CharacterController controller;
    public Transform carbody;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        

        transform.position = newPosition;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = transform.up * z;
        movement = movement.normalized * speed * Time.deltaTime;
        newPosition = newPosition + movement;

        controller.Move(movement);
        carbody.Rotate(Vector3.back * x);
    }
}
