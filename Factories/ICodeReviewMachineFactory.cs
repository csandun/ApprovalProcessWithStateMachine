using ApprovalProcessWithStateMachine.StateMachine;

namespace ApprovalProcessWithStateMachine.Factories;

public interface ICodeReviewMachineFactory
{
    CodeReviewStateMachine Create();
}