namespace DesignPattern.Chain
{
    /// <summary>
    /// 基础审核
    /// </summary>
    public abstract class Approval
    {
        /// <summary>
        /// 审核人
        /// </summary>
        /// <value></value>
        public string Name { get; set; }

        /// <summary>
        /// 下一个审核人
        /// </summary>
        /// <value></value>
        public Approval NextApproval { get; set; }

        /// <summary>
        /// 审核信息
        /// </summary>
        /// <param name="request"></param>
        public abstract void Approve(ApproveRequest request);
    }
}