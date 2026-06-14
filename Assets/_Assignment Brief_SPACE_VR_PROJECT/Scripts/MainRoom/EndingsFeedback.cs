using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndingsFeedback : MonoBehaviour
{
    [SerializeField] AudioSource endingSound;
    [SerializeField] AudioSource assistantSound;
    [SerializeField] AudioClip happyEndingClip,sadEndingClip,sacrificeEndingClip;
    [SerializeField] AudioClip assistantHEC,assistantSEC,assistantSacrificeEC;

    [SerializeField] GameObject greenLight,redLight;
    bool endingDetected=false;
    

    [SerializeField] GameObject earthEffect_sad,earthEffect_happy,earthEffect_current,earth_object;
    [SerializeField] Transform new_earthTransform;
    [SerializeField] Transform cameraTransform;

    [SerializeField] GameObject[] sacrifice_end_effects;
    bool moveCamera;

    [SerializeField] GameObject canvasCredit;
    [SerializeField] AudioClip creditClip;
    public void HappyEnding()
    {
        if(endingDetected)
            return;
        endingSound.clip=happyEndingClip;
        endingSound.Play();
        assistantSound.clip=assistantHEC;
        Invoke("PlayAssistantSound",3f);
        greenLight.SetActive(true);
        endingDetected=true;

        EarthFeedback("happy");
    }
    public void SadEnding()
    {
        if(endingDetected)
            return;
        endingSound.clip=sadEndingClip;
        endingSound.Play();
        assistantSound.clip=assistantSEC;
        Invoke("PlayAssistantSound",1.5f);
        InvokeRepeating("PlayRedLight",0f,0.5f);
        endingDetected=true;

        EarthFeedback("sad");
    }
    public void SacrificeEnding()
    {
        if(endingDetected)
            return;
        endingSound.clip=sacrificeEndingClip;
        endingSound.Play();
        assistantSound.clip=assistantSacrificeEC;
        Invoke("PlayAssistantSound",1.5f);
        InvokeRepeating("PlayRedLight",0f,0.5f);
        endingDetected=true;

        EarthFeedback("sacrifice");
    }
    void PlayAssistantSound() 
    {
        assistantSound.Play();
        Invoke("ShowCredits",assistantSound.clip.length+0.5f);
    }
    void PlayRedLight()
    {
        redLight.SetActive(!redLight.activeSelf);
    }
    void EarthFeedback(string endName)
    {
        if (endName == "sad")
        {
            earthEffect_sad.SetActive(true);
        }else if (endName == "happy")
        {
            earthEffect_current.SetActive(false);
            earthEffect_happy.SetActive(true);
            earth_object.transform.position = new_earthTransform.position;
        }else if (endName == "sacrifice")
        {
            moveCamera=true;
            for(int i=0;i<sacrifice_end_effects.Length;i++)
                sacrifice_end_effects[i].SetActive(true);
        }
    }
    void Update()
    {
        if (moveCamera)
        {
            float speed=5f;
            speed+=2f * Time.deltaTime;
            cameraTransform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    void ShowCredits()
    {
        canvasCredit.SetActive(true);
        endingSound.clip=creditClip;
        endingSound.Play();
    }
    public void RestartScene()
    {
        SceneManager.LoadScene("Intro");
    }
    
}
