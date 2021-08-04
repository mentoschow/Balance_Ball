using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime);
    }
}
