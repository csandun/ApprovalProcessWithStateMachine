using ApprovalProcessWithStateMachine.Enums;

namespace ApprovalProcessWithStateMachine.Domains;

public class Transition
{
    public Transition(CodeReviewTransitions transitionName, State targetState)
    {
        TransitionName = transitionName;
        TargetState = targetState;
    }

    public CodeReviewTransitions TransitionName { get; }
    public State TargetState { get; }
}