using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSys.Managers
{
    public class MemberManager : GenericManager <Member>
    {
        public List<Member> membersList = new();
        private int memberId = 1;

        public MemberManager() 
        {
            membersList = new List<Member>();
            CreateTestMembers();
        }

        // Fill membersList with random members
        private void CreateTestMembers()    
        {
            for (int i = 0; i < 15; i++)
            {
                CreateMember();
            }
        }

        private void CreateMember()
        {
            Member member = new Member(memberId, $"Member{memberId}");
            Add(member, membersList);
            memberId++;
        }
    }
}
