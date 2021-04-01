using System;
using System.Collections.Generic;
using System.Text;

namespace MembersLib
{
    public abstract class Engineer : Member
    {
        public DateTime GotJobTime { get; set; } // дата устройства на работу
        public int Income { get; set; } // зарплата сотрудника в мес
        public virtual int Money { get { return money; } set { money = value; } } // кол-во денег на счету сотрудника
        private int money = 0;
        public int DaysInCompany()
        {
            return (DateTime.Now - GotJobTime).Days;// посчитать кол-во отработанных дней сотрудником
        }
        public int TotalIncome()
        {
            return DaysInCompany() / (365 / 12) * Income;// посчитать кол-во зароботанных денег в общем сотруником
        }
        public void GoToJob() { }
    }
}
