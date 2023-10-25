public interface IPlayerUnitState
{
    void EnterState(StateController unit);
    void ExitState(StateController unit);
    void UpdateState(StateController unit);
}
