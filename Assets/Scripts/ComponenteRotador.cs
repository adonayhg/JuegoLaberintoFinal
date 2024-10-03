using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteRotador : MonoBehaviour
{

    [SerializeField]
    float rotationY = 10f;

    void Update()
    {
        transform.Rotate(0f, rotationY * Time.deltaTime, 0f);
    }
}
