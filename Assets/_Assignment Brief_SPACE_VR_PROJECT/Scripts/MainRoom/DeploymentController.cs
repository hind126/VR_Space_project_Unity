using System.Reflection;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DeploymentController : MonoBehaviour
{
    string module1;
    string module2;
    string module3;
    bool containGS, containQB,containEA,containSC,containEP;
    [SerializeField] ModuleFeedback feedback;
    [SerializeField] AudioSource insertionSound;
    [SerializeField] EndingsFeedback endingsFeedback;
    public void SetModule1(SelectEnterEventArgs args)
    {
        module1 = args.interactableObject.transform.name;
        insertionSound.Play();
        feedback.UpdateFeedback(module1);
        print(module1);
        CheckEnding();
    }
    public void SetModule2(SelectEnterEventArgs args)
    {
        module2 = args.interactableObject.transform.name;
        insertionSound.Play();
        feedback.UpdateFeedback(module2);
        print(module2);
        CheckEnding();
    }
    public void SetModule3(SelectEnterEventArgs args)
    {
        module3 = args.interactableObject.transform.name;
        insertionSound.Play();
        print(module3);
        feedback.UpdateFeedback(module3);
        CheckEnding();
    }
    public void CheckEnding()
    {
        print(module1);
        print(module2);
        print(module3);
        if (string.IsNullOrEmpty(module1) || string.IsNullOrEmpty(module2) || string.IsNullOrEmpty(module3))
        {
            return;
        }

        containGS= module1 == "GRAVITY STABILIZER" || module2 == "GRAVITY STABILIZER" || module3 == "GRAVITY STABILIZER";
        containSC= module1 == "SINGULARITY CHARGE" || module2 == "SINGULARITY CHARGE" || module3 == "SINGULARITY CHARGE";
        containEA= module1 == "ENERGY AMPLIFIER" || module2 == "ENERGY AMPLIFIER" || module3 == "ENERGY AMPLIFIER";
        containQB= module1 == "QUANTUM BEACON" || module2 == "QUANTUM BEACON" || module3 == "QUANTUM BEACON";
        containEP= module1 == "EVACUATION PROTOCOL" || module2 == "EVACUATION PROTOCOL" || module3 == "EVACUATION PROTOCOL";
        if (containEA && containGS && containQB)
        {
            print("happy ending");
            endingsFeedback.HappyEnding();
        }else if (containSC)
        {
            print("SACRIFICE ending");
            endingsFeedback.SacrificeEnding();
        }
        else if(containEP)
        {
            print("sad ending");
            endingsFeedback.SadEnding();
        }
    }




}
