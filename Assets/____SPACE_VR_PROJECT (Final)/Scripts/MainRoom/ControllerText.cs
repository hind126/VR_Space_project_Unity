using TMPro;
using UnityEngine;

public class ControllerTexrs : MonoBehaviour
{
    [SerializeField] TMP_Text controllerT;
    public void ShowDefault()
    {
        controllerT.text=
        "M.E.R.I.D.I.A.N.\n\n" +
        "Mission Status: ACTIVE\n\n" +
        "Review available modules.\n\n" +
        "Grab a module to view its specifications.";
    }
    public void ShowGS()
    {
        controllerT.text = 
        "GRAVITY STABILIZER\n\n" +
        "Function:\n" +
        "Reduces anomaly pull.\n\n" +
        "AI Recommendation:\n" +
        "RECOMMENDED\n\n" +
        "Success Rate:\n" +
        "64%\n\n" +
        "Compatibility:\n" +
        "Works with Quantum Beacon.\n" +
        "Cannot operate with Singularity Charge.";
    }
    public void ShowQB()
    {
        controllerT.text = 
        "QUANTUM BEACON\n\n" +
        "Function:\n" +
        "Attempts to redirect the anomaly.\n\n" +
        "AI Recommendation:\n" +
        "RECOMMENDED\n\n" +
        "Success Rate:\n" +
        "52%\n\n" +
        "Compatibility:\n" +
        "Works with Gravity Stabilizer.";
    }
    public void ShowEA()
    {
        controllerT.text = 
        "ENERGY AMPLIFIER\n\n" +
        "Function:\n" +
        "Boosts deployed modules.\n\n" +
        "AI Recommendation:\n" +
        "OPTIONAL\n\n" +
        "Success Rate:\n" +
        "38%";
    }
    public void ShowSG()
    {
        controllerT.text = 
        "SINGULARITY CHARGE\n\n" +
        "Function:\n" +
        "Creates a controlled singularity.\n\n" +
        "AI Recommendation:\n" +
        "NOT RECOMMENDED\n\n" +
        "Success Rate:\n" +
        "UNKNOWN\n\n" +
        "Warning:\n" +
        "Ship destruction possible.";
    }
    public void ShowEP()
    {
        controllerT.text = 
        "EVACUATION PROTOCOL\n\n" +
        "Function:\n" +
        "Preserves a portion of humanity.\n\n" +
        "AI Recommendation:\n" +
        "LAST RESORT\n\n" +
        "Success Rate:\n" +
        "81%\n\n" +
        "Warning:\n" +
        "Does not save Earth.";
    }
}
