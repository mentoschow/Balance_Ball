using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float sensitivity = 1f;
    private float _rotationX = 0f, _rotationZ = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        Route();
    }

    void Route()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            _rotationX += sensitivity;      
            transform.localEulerAngles = new Vector3(_rotationX, 0, _rotationZ);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rotationX -= sensitivity;
            transform.localEulerAngles = new Vector3(_rotationX, 0, _rotationZ);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rotationZ += sensitivity;
            transform.localEulerAngles = new Vector3(_rotationX, 0, _rotationZ);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rotationZ -= sensitivity;
            transform.localEulerAngles = new Vector3(_rotationX, 0, _rotationZ);
        }
    }
}
