using System.Security.Cryptography;
using UnityEngine;

public class ThreatRotation : MonoBehaviour
{
    Vector3 scale;
    void Start()
    {
        scale=transform.localScale;
    }
    void Update()
    {
        transform.Rotate(0,40f * Time.deltaTime,0);
        float pulse= 1+Mathf.Sin(Time.time * 2f)*0.1f;
        transform.localScale=scale * pulse;
    }
}
