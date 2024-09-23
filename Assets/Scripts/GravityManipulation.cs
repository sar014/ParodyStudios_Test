using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManipulation : MonoBehaviour
{
    [SerializeField] GameObject HaloAgent;
    public CameraRotation cameraRotation;
    void Start()
    {
        HaloAgent.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        HaloAgentPos();
    }

    void HaloAgentPos()
    {
        
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            HaloAgent.transform.position = transform.forward;
            
            cameraRotation.isSelectingHalo = true;
            HaloAgent.SetActive(true);
            HaloAgent.transform.rotation = Quaternion.Euler(90f,0,0);
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            HaloAgent.SetActive(false);
            cameraRotation.isSelectingHalo = false;
        }
        else
        {
            cameraRotation.isSelectingHalo = false;
        }
    }

}
