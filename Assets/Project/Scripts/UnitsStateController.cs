using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsStateController : MonoBehaviour
{
    public static event Action OnAttackButtonPressed;
    public static event Action OnDefendButtonPressed;

    public void SetAttackState()
    {
        OnAttackButtonPressed?.Invoke();
    }

    public void SetDefendState()
    {
        OnDefendButtonPressed?.Invoke();
    }
}
