using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositioning : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private Transform[] cameraPoints;
    [SerializeField] private Animator[] animatorsOfTeam;
    private int currentCameraIndex;



    // Start is called before the first frame update
    void Start()
    {
        animatorsOfTeam[currentCameraIndex].SetBool("Talk", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            animatorsOfTeam[currentCameraIndex].SetBool("Talk", false);
            currentCameraIndex = (currentCameraIndex>=cameraPoints.Length-1)?0:currentCameraIndex + 1;
            animatorsOfTeam[currentCameraIndex].SetBool("Talk",true);
            animatorsOfTeam[currentCameraIndex].GetComponent<LookAtCamera>().enabled = true;
            Debug.Log(currentCameraIndex);
        }

        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, cameraPoints[currentCameraIndex].position,velocity);
        Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, cameraPoints[currentCameraIndex].rotation, velocity);
    }

}
