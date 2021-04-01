using System;

namespace MembersLib
{
    public interface Member
    {
        DateTime GotJobTime { get; set; }
        int Income { get; set; }
        int Money { get; set; }
        int DaysInCompany();
        int TotalIncome();
    }
}
