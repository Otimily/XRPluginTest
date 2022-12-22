using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction;

public class InteractTest : MonoBehaviour
{
    public void Test()
    {
        Debug.Log($"{transform.name} Interact Test");
    }

    public void HoverExitTest()
    {
        Debug.Log($"{transform.name} HoverExit");
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
    public void SelectEnterTest()
    {
        //XRControlloer controller = GetComponent<XRController>();
        //controller.SendHaptical

        Debug.Log($"{transform.name} SelectEnter");
    }
    public void SelectExitTest()
    {
        Debug.Log($"{transform.name} SelectExit");
    }

    public void FirstHoverEnterTest()
    {
        Debug.Log($"{transform.name} FirstHoverEnter");
    }
    public void LastHoverExitTest()
    {
        Debug.Log($"{transform.name} LastHoverExit");
    }
    public void FirstSelectEnterTest()
    {
        Debug.Log($"{transform.name} FirstSelectEnter");
    }
    public void LastSelectExitTest()
    {
        Debug.Log($"{transform.name} LastSelectExit");
    }
    public void AcivatedTest()
    {
        Debug.Log($"{transform.name} Acivated");
    }
    public void DeacivatedTest()
    {
        Debug.Log($"{transform.name} Deacivated");
    }

}
