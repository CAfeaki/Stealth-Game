using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThing : MonoBehaviour
{
    public GameObject Thing;

    public void DestroyThatThing()
    {
        Destroy(Thing);
    }
}
