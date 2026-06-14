using UnityEngine;

public class Reticle : MonoBehaviour
{
    float y=0;
    
    void Update()
    {
        y+=60f * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0,y,0);
        float scale = 1 + 0.1f * Mathf.Sin(Time.time * 4f);
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
