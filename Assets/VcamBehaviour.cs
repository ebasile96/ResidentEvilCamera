using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;



public class VcamBehaviour : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    public CineManager CineMgr;
        

    void Awake()
    {
        vcam = GetComponentInChildren<CinemachineVirtualCamera>();
        vcam.gameObject.SetActive(false);
        CineMgr = FindObjectOfType<CineManager>();
    }

 public void OnTriggerEnter(Collider other)
{
    if(other.gameObject.tag == "Player")
    {
        vcam.gameObject.SetActive(true);
        CineMgr.currentCam = vcam;
    }
}

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            vcam.gameObject.SetActive(false);
        }
           
    }
}

    
