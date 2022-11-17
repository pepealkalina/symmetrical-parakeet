using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovement : MonoBehaviour
{
    public float speedMovement = 5;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        transform.position += Vector3.back * x * speedMovement * Time.deltaTime;
        transform.position += Vector3.right * z * speedMovement * Time.deltaTime;
    }
}
