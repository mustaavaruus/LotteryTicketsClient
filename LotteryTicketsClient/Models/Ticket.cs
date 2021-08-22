using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LotteryTicketsClient.Models
{
    public class Ticket
    {
        public int id { get; set; }

        [DisplayName("Номер")]
        public Guid number { get; set; }
        [DisplayName("Тираж")]
        public int circulation { get; set; }
        [DisplayName("Количество выбранных")]
        public int choosedNumbersCount { get; set; }

        [DisplayName("Выбранные")]
        public List<int> choosedNumbers { get; set; }

        public Ticket()
        {

        }
    }
}
