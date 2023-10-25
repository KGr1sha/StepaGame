using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAttackState : BaseUnitState
{
    public override void EnterState(StateController unit)
    {
        Debug.Log("Enter Attack State");
    }
    public override void ExitState()
    {
        Debug.Log("Exit Attack State");
    }
    public override void UpdateState()
    {
        Debug.Log("Update Attack State");
    }
}
