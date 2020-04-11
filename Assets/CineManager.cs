using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CineManager : MonoBehaviour
{
    public CinemachineBrain Brain;
    public CinemachineVirtualCamera currentCam;

    void Awake()
    {
        Brain = GetComponent<CinemachineBrain>();
    }

    void Update()
    {
        CamDisplay();
    }

    public void CamDisplay()
    {
        Brain.IsLive(currentCam, true);
        
    }
}
