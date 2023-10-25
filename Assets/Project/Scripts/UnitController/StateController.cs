using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    [SerializeField] private IPlayerUnitState defaultState;

    private IPlayerUnitState currentState;


    private void Start()
    {
        ChangeState(defaultState);
    }

    public void ChangeState(IPlayerUnitState newState)
    {
        currentState?.ExitState(this);
        currentState = newState;
        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState?.UpdateState(this);
    }
}
