using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform cameraTransform;
    public float rotationSpeed = 2f;
    public bool isSelectingHalo = false;

    // Update is called once per frame
    void Update()
    {
        if(!isSelectingHalo)
        {
            Vector3 cameraRotation = cameraTransform.rotation.eulerAngles;
            Quaternion newRotation = Quaternion.Euler(0f,cameraRotation.y,0f);
            transform.rotation = Quaternion.Slerp(transform.rotation,newRotation,rotationSpeed * Time.deltaTime);
        }
       
    }
}
