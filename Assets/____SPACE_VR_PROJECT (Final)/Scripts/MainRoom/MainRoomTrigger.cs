using System.Collections;
using DeepSpace;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] AudioSource assistantSound;
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;
    [SerializeField] AudioClip clip3;

    [SerializeField] GameObject screen1;
    [SerializeField] GameObject screen2;
    [SerializeField] GameObject screen3;
    [SerializeField] GameObject controller;
    
    [SerializeField] DSGates gate;
    bool entered=false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (entered)
        {
            return;
        }
        if (other.name == "XR Origin (VR)")
        {
            entered=true;
            gate.StartOpenClose();
            StartCoroutine(SoundsSequence());

        }
    }
    IEnumerator SoundsSequence()
    {
        assistantSound.clip=clip1;
        assistantSound.Play();
        yield return new WaitForSeconds(clip1.length + 2f);

        screen1.SetActive(true);
        screen1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);

        screen2.SetActive(true);
        screen2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);

        screen3.SetActive(true);
        controller.SetActive(true);
        screen3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);

        assistantSound.clip=clip2;
        assistantSound.Play();

        yield return new WaitForSeconds(clip2.length + 2f);
        assistantSound.clip=clip3;
        assistantSound.Play();
    }
}
