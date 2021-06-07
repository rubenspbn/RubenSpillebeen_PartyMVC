using PartyMVCLib.Models;

namespace PartyMVCLib.Interfaces
{
    public interface IVisitorRepository
    {
        void AddVisitor(Visitor visitor);
        int OldestMember();
        int TotalFamilyMembers();
        int TotalMembers();
        int YoungestMember();
    }
}