using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGameObject : MonoBehaviour
{
    public List<GameObject> objectToSpawn;
    private GameObject currentObject;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            SpawnObject(0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            SpawnObject(1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            SpawnObject(2);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            SpawnObject(3);
        }
        else
        {
            DestroyCurrentObject();
        }
    }

    private void SpawnObject(int index)
    {
        if (currentObject == null)
        {
            currentObject = Instantiate(objectToSpawn[index], this.transform.position, objectToSpawn[index].transform.rotation);
        }
    }

    private void DestroyCurrentObject()
    {
        if (currentObject != null)
        {
            Destroy(currentObject);
            currentObject = null;
        }
    }
    
}
