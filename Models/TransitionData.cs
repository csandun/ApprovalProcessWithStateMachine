using ApprovalProcessWithStateMachine.Enums;

namespace ApprovalProcessWithStateMachine.Models;

public class TransitionData
{
    public string CodePRNumber { get; set; }
    public CodeReviewTransitions Transition { get; set; }
    public CodeReviewStates CurrentState { get; set; }
    public string? Comment { get; set; }
    public int UserId { get; set; }
}