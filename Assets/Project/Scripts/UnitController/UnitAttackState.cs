using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAttackState : IPlayerUnitState
{
    public void EnterState(StateController unit)
    {
        Debug.Log("Enter attack state!");
    }

    public void ExitState(StateController unit)
    {
        Debug.Log("Exit attack state!");
    }

    public void UpdateState(StateController unit)
    {
        
    }
}
