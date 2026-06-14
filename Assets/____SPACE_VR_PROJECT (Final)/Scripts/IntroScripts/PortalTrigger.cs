using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalTrigger : MonoBehaviour
{
    [SerializeField] AudioSource explosionS;
    void OnTriggerEnter(Collider other)
    {
        explosionS.Play();
        Invoke("LoadScene",2f);
    }
    void LoadScene()
    {
        SceneManager.LoadScene("Scene 1");
    }
}
