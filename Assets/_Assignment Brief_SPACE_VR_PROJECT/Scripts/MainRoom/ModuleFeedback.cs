using UnityEngine;
using TMPro;

public class ModuleFeedback : MonoBehaviour
{
    [SerializeField] TMP_Text leftScreen;
    [SerializeField] TMP_Text rightScreen;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip GS_clip,QB_clip,EA_clip,SC_clip,EP_clip ;
    

    bool hasGS,hasQB,hasEA,hasSC,hasEP;
    int stability,containment;
    public void UpdateFeedback(string name)
    {
        stability= 13;
        containment=0;

        if (name == "GRAVITY STABILIZER")
        {
            audioSource.clip=GS_clip;
            audioSource.Play();
            hasGS=true;
        }
            
        else if (name == "QUANTUM BEACON")
        {
            audioSource.clip=QB_clip;
            audioSource.Play();
            hasQB=true;
        }
            
        else if (name == "ENERGY AMPLIFIER")
        {
            audioSource.clip=EA_clip;
            audioSource.Play();
            hasEA=true;
        }
            
        else if (name == "SINGULARITY CHARGE")
        {
            audioSource.clip=SC_clip;
            audioSource.Play();
            hasSC=true;
        }
            
        else if (name == "EVACUATION PROTOCOL")
        {
            audioSource.clip=EP_clip;
            audioSource.Play();
            hasEP=true;
        }
        if (hasGS)
        {
            stability += 16;
            containment += 25;
        }
        if (hasQB)
        {
            stability += 14;
            containment += 28;
        }
        if (hasEA)
        {
            stability += 19;
            containment += 38;
        }
        if (hasEP)
        {
            stability += 5;
        }
        if(hasGS && hasQB)
        {
            containment += 10;
        }

        leftScreen.text ="PLANETARY STABILITY\n\n" + stability + "%";
        rightScreen.text ="CONTAINMENT CHANCE\n\n" + containment + "%";
    }
}
