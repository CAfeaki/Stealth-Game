using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGuardNavPoints : MonoBehaviour
{

    //[Header("Changing Agent Details")]
    public bool jobBecomesPatrol;
    public bool jobBecomesStandGuard;

    //[Header("Changing Path")]
    public GameObject[] newWayPoints;

    public void GuardRush()
    {
        ChangeGuardType();
        ChangeAIState();
        ChangeNavPath();
    }

    void ChangeGuardType()
    {
        this.GetComponent<NavmeshAgentScript>().jobIsPatrol = jobBecomesPatrol;
        this.GetComponent<NavmeshAgentScript>().jobIsStandGaurd = jobBecomesStandGuard;

    }

    void ChangeAIState()
    {
        if (jobBecomesPatrol == true)
        {
            this.GetComponent<NavmeshAgentScript>().AIState = 3;
        }
        if (jobBecomesStandGuard == true)
        {
            this.GetComponent<NavmeshAgentScript>().AIState = 4;
        }
    }

    void ChangeNavPath()
    {
        this.GetComponent<NavmeshAgentScript>().wayPoints = newWayPoints;
    }

}
