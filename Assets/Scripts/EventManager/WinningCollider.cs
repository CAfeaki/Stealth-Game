using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningCollider : MonoBehaviour
{
    Collider toActivate;

    public void ActivateCollider()
    {
        toActivate = this.GetComponent<BoxCollider>();
        toActivate.enabled = true;
    }

}
