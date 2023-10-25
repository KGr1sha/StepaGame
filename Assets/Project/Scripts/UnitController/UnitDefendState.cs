using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitDefendState : BaseUnitState
{
    public override void EnterState(StateController unit)
    {
        Debug.Log("Enter Defend State");
    }
    public override void ExitState()
    {
        Debug.Log("Exit Defend State");
    }
    public override void UpdateState()
    {
        Debug.Log("Update Defend State");
    }
}
