using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    public float td;
    void Update()
    {
        transform.position += Vector3.left * td * Time.deltaTime;
    }
}
