using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseUnitState
{
    public abstract void EnterState(StateController unit);
    public abstract void ExitState();
    public abstract void UpdateState();
}
