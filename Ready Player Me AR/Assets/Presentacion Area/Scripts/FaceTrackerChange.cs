using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceTrackerChange : MonoBehaviour
{
    public Unity.LiveCapture.ARKitFaceCapture.FaceActor[] actors;
    public Unity.LiveCapture.ARKitFaceCapture.FaceDevice device;
    public enum ActorIndex 
    {
        Adan,Ramon,Diego,Iris,Eduardo,Claudia
    }

    public void SetActor(ActorIndex index)
    {
        device.Actor = actors[(int)index];
    }
}
