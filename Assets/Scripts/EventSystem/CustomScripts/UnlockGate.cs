using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockGate : MonoBehaviour
{

    public Collider collider;

    public void UnlockGateLock()
    {
        collider.enabled = true;
    }
}
