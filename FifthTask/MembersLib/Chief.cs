using System;
using System.Collections.Generic;
using System.Text;

namespace MembersLib
{
    public class Chief : Engineer
    {
        public List<Member> WorkersList { get; set; } // список сотрудников
        public int WorkersLeaved { get; set; } = 0; // кол-во уволенных сотрудников
        public bool GiveIncome(Member Worker)
        {
            if (Money - (Worker.TotalIncome() - Worker.Money) < 0)// если у начальника позволяет бюджет выдать зарплату
            {
                Money = Money - (Worker.Money = Worker.TotalIncome() - Worker.Money);// снять со счета начальника сумму зорплаты, и выдать на счет сотрудника зарплату
                return true;
            }
            else
            {
                return false;
            }
        }
        public void LeaveWorker(Member Worker)
        {
            for (int i = 0; i < WorkersList.Count; i++)// перебрать список сотрудников
            {
                if (WorkersList[i] == Worker)//если сотрудник найден в списке
                {
                    WorkersList.RemoveAt(i);//удалить его из списка
                    WorkersLeaved++;//добавить +1 к кол-ву уволенных сотрудников
                    return;
                }
            }
        }
    }
}
