using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background2 : MonoBehaviour
{
    public float sensitivity = 1f;
    private float _rotationX, _rotationZ;
    private float angleX, angleZ;

    void Start()
    {

    }

    void Update()
    {
        Route();
    }

    void Route()
    {
        if (Input.GetMouseButton(0))
        {
            _rotationX = Input.GetAxis("Mouse Y") * sensitivity + transform.localEulerAngles.x;
            _rotationZ = -Input.GetAxis("Mouse X") * sensitivity + transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(_rotationX, 0, _rotationZ);
        }
    }
}
