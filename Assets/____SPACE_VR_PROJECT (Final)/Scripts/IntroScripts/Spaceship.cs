using System;
using System.Runtime.Serialization;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float currentS=10f;
    [SerializeField] float accelerationS=4f;
    void Update()
    {
        currentS+=accelerationS * Time.deltaTime;
        transform.Translate(Vector3.forward * currentS * Time.deltaTime); 
    }
}
