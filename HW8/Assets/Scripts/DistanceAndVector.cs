using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceAndVector : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    private float distance;
    public Vector3 vec1;
    public Vector3 vec2;

    void Update()
    {
        Vector3 SumVec = vec1 + vec2;
        Vector3 SubVec = vec1 - vec2;
        Vector3 MultiVec = vec1 * 3.5f;

        distance = Vector3.Distance(cube1.transform.position, cube2.transform.position);
        Debug.Log("Сумма векторов - " + SumVec);
        Debug.Log("Вычитание векторов - " + SubVec);
        Debug.Log("Умножение вектора на число - " + MultiVec);
        Debug.Log("Расстояние между кубами - " + distance);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        DrawVector(transform.position, vec1);
        Gizmos.color = Color.blue;
        DrawVector(transform.position, vec2);
    }

    private void DrawVector(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector);
        Gizmos.DrawSphere(start + vector, 0.25f);
    }    
}
