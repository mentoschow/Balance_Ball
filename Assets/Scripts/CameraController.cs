using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float movementX, movementZ;
    public float moveSpeed = 1f;

    void Start()
    {

    }

    void LateUpdate()
    {
        CameraMove();
    }

    void CameraMove()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            movementZ += moveSpeed;
            transform.localPosition = new Vector3(movementX, 20, movementZ);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movementZ -= moveSpeed;
            transform.localPosition = new Vector3(movementX, 20, movementZ);
        }
    }
}
