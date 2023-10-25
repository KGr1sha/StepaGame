using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    private BaseUnitState currentState;

    public UnitAttackState AttackState { get; private set; }
    public UnitDefendState DefendState { get; private set; }

   


    private void Start()
    {
        CreateStates();
        SetDefaultState();
    }


    public void ChangeState(BaseUnitState newState)
    {
        currentState?.ExitState();
        currentState = newState;
        currentState.EnterState(this);
    }

    private void OnEnable()
    {
        UnitsStateController.OnAttackButtonPressed += SetAttackState;
        UnitsStateController.OnDefendButtonPressed += SetDefendState;
    }

    private void OnDisable()
    {
        UnitsStateController.OnAttackButtonPressed -= SetAttackState;
        UnitsStateController.OnDefendButtonPressed -= SetDefendState;
    }

    private void Update()
    {
        currentState?.UpdateState();
    }

    private void SetDefaultState()
    {
        ChangeState(DefendState);
    }

    private void CreateStates()
    {
        AttackState = new();
        DefendState = new();
    }

    private void SetAttackState()
    {
        ChangeState(AttackState);
    }

    private void SetDefendState()
    {
        ChangeState(DefendState);
    }
}
