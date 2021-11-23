using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOfObjects : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;

    void FixedUpdate()
    {
        Quaternion rotationY = Quaternion.AngleAxis(1.5f, Vector3.up);
        cube1.transform.rotation *= rotationY;

        Quaternion rotationX = Quaternion.AngleAxis(1.5f, Vector3.right);
        cube2.transform.rotation *= rotationX;

        Quaternion rotationZ = Quaternion.AngleAxis(1.5f, Vector3.forward);
        cube3.transform.rotation *= rotationZ;

        cube4.transform.rotation *= rotationX * rotationZ * rotationY;
    }
}
