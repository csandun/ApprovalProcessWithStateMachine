using ApprovalProcessWithStateMachine.StateMachine;

namespace ApprovalProcessWithStateMachine.Factories;

public class CodeReviewMachineFactory: ICodeReviewMachineFactory
{
    public CodeReviewMachineFactory()
    {
        
    }
    
    
    public CodeReviewStateMachine Create()
    {
        throw new NotImplementedException();
    }
}