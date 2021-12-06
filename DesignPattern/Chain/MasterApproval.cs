using System;

namespace DesignPattern.Chain
{
    public class MasterApproval : Approval
    {
        public override void Approve(ApproveRequest request)
        {
            Console.WriteLine("老板审核" + request.Amount);
            
            if (NextApproval != null)
                NextApproval.Approve(request);
        }
    }
}