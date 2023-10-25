using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitDefendState : IPlayerUnitState
{
    public void EnterState(StateController unit)
    {
        Debug.Log("Enter defending state!");
    }

    public void ExitState(StateController unit)
    {
        Debug.Log("Exit defending state!");
    }

    public void UpdateState(StateController unit)
    {
        
    }
}
