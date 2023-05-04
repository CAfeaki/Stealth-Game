using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatePressed : MonoBehaviour
{
    public int platesTriggered;

    public void OnTriggerEnter(Collider other)
    {
        platesTriggered++;
    }


}
