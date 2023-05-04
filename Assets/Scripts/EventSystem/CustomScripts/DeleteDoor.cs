using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteDoor : MonoBehaviour
{
    public GameObject door;
    public int platesTriggered;

    public void PlateTriggered()
    {
        platesTriggered++;
        if (platesTriggered == 2)
        {
            RemoveDoor();
        }
    }


    public void RemoveDoor()
    {
        Destroy(door);
    }
}
