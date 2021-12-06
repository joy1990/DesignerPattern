using System;

namespace DesignPattern.Chain
{
    /// <summary>
    /// 经理审核
    /// </summary>
    public class ManageApproval : Approval
    {
        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="request"></param>
        public override void Approve(ApproveRequest request)
        {
            Console.WriteLine("经理审核：" + request.Amount);

            if (NextApproval != null)
                NextApproval.Approve(request);
        }
    }
}