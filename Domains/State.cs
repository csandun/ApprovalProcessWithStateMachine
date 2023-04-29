using ApprovalProcessWithStateMachine.Enums;

namespace ApprovalProcessWithStateMachine.Domains;

public class State
{
    private readonly Dictionary<CodeReviewTransitions, State> _transitions;

    public State(CodeReviewStates stateName)
    {
        StateName = stateName;
        _transitions = new Dictionary<CodeReviewTransitions, State>();
    }

    public CodeReviewStates StateName { get; }

    public void AddTransition(CodeReviewTransitions transition, State targetState)
    {
        _transitions[transition] = targetState;
    }

    public State GetNextState(CodeReviewTransitions transition)
    {
        _transitions.TryGetValue(transition, out var targetState);
        return targetState;
    }
}