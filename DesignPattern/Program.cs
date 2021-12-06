using System;
using DesignPattern.Chain;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Approval manager = new ManageApproval() { Name = "job" };
            Approval boss = new MasterApproval() { Name = "tom" };

            manager.NextApproval = boss;

            manager.Approve(new ApproveRequest() { Amount = 100 });
        }
    }
}
