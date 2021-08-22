using LotteryTicketsClient.Models;
using LotteryTicketsClient.Requests;
using LotteryTicketsV1.DTO;
using Mapster;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Text;

namespace LotteryTicketsClient.BLL
{
    public class TicketProcessing
    {
        private const int MIN_CHOOSED_NUMBERS_COUNT = 6;
        private const int MAX_CHOOSED_NUMBERS_COUNT = 17;

        private const int MIN_CIRCULATION_NUMBER = 1;
        private const int MAX_CIRCULATION_NUMBER = 65535;

        private CustomHttpRequest httpRequest;

        private Ticket ticket;
        public TicketProcessing(Ticket ticket)
        {
            this.ticket = ticket;
            this.httpRequest = new CustomHttpRequest();
        }

        public void checkValidForSaving()
        {
            if (ticket.circulation < MIN_CIRCULATION_NUMBER) {

                StringBuilder str = new StringBuilder();
                str.Append("Указанный номер тиража ");
                str.Append("(");
                str.Append(ticket.circulation);
                str.Append(")");
                str.Append(" должен быть в диапазоне: ");
                str.Append("(");
                str.Append(MIN_CIRCULATION_NUMBER);
                str.Append("; ");
                str.Append(MAX_CIRCULATION_NUMBER);
                str.Append(")");

                throw new Exception(str.ToString());

            }

            if (ticket.circulation > MAX_CIRCULATION_NUMBER)
            {

                StringBuilder str = new StringBuilder();
                str.Append("Указанный номер тиража ");
                str.Append("(");
                str.Append(ticket.circulation);
                str.Append(")");
                str.Append(" должен быть в диапазоне: ");
                str.Append("(");
                str.Append(MIN_CIRCULATION_NUMBER);
                str.Append("; ");
                str.Append(MAX_CIRCULATION_NUMBER);
                str.Append(")");

                throw new Exception(str.ToString());

            }

            if (ticket.choosedNumbersCount < MIN_CHOOSED_NUMBERS_COUNT)
            {
                StringBuilder str = new StringBuilder();
                str.Append("Указанное количество выбранных чисел");
                str.Append("(");
                str.Append(ticket.choosedNumbersCount);
                str.Append(")");
                str.Append(" должно быть в диапазоне: ");
                str.Append("(");
                str.Append(MIN_CHOOSED_NUMBERS_COUNT);
                str.Append("; ");
                str.Append(MAX_CHOOSED_NUMBERS_COUNT);
                str.Append(")");

                throw new Exception(str.ToString());
            }

            if (ticket.choosedNumbersCount > MAX_CHOOSED_NUMBERS_COUNT)
            {
                StringBuilder str = new StringBuilder();
                str.Append("Указанное количество выбранных чисел");
                str.Append("(");
                str.Append(ticket.choosedNumbersCount);
                str.Append(")");
                str.Append(" должно быть в диапазоне: ");
                str.Append("(");
                str.Append(MIN_CHOOSED_NUMBERS_COUNT);
                str.Append("; ");
                str.Append(MAX_CHOOSED_NUMBERS_COUNT);
                str.Append(")");

                throw new Exception(str.ToString());
            }

            if ((ticket.choosedNumbers == null) || (ticket.choosedNumbers.Count == 0))
            {
                throw new Exception("Массив с выбранными числами пуст");
            }

            if (ticket.choosedNumbers.Count < MIN_CHOOSED_NUMBERS_COUNT)
            {
                StringBuilder str = new StringBuilder();
                str.Append("Количество выбранных чисел в массиве ");
                str.Append("(");
                str.Append(ticket.choosedNumbersCount);
                str.Append(")");
                str.Append(" должно быть в диапазоне: ");
                str.Append("(");
                str.Append(MIN_CHOOSED_NUMBERS_COUNT);
                str.Append("; ");
                str.Append(MAX_CHOOSED_NUMBERS_COUNT);
                str.Append(")");

                throw new Exception(str.ToString());
            }

            if (ticket.choosedNumbers.Count > MAX_CHOOSED_NUMBERS_COUNT)
            {
                StringBuilder str = new StringBuilder();
                str.Append("Количество выбранных чисел в массиве ");
                str.Append("(");
                str.Append(ticket.choosedNumbersCount);
                str.Append(")");
                str.Append(" должно быть в диапазоне: ");
                str.Append("(");
                str.Append(MIN_CHOOSED_NUMBERS_COUNT);
                str.Append("; ");
                str.Append(MAX_CHOOSED_NUMBERS_COUNT);
                str.Append(")");

                throw new Exception(str.ToString());
            }

            if ((ticket.choosedNumbersCount != ticket.choosedNumbers.Count))
            {
                throw new Exception("Количество выбранных чисел не совпадает с количеством чисел в массиве");

            }
        }

        public void add()
        {
            this.checkValidForSaving();

            TicketAddReceiveDTO ticketDTO = this.ticket.Adapt<TicketAddReceiveDTO>();

            var json = new JavaScriptSerializer().Serialize(ticketDTO);
            
            var response = this.httpRequest.put(ConfigurationManager.AppSettings["host"].ToString() + "api/ticket/add/", json);
            Debug.WriteLine(response);
        }

        public List <Ticket> get()
        {
            List<Ticket> tickets = new List<Ticket>();

            var response = this.httpRequest.get(ConfigurationManager.AppSettings["host"].ToString() + "api/ticket/get/");

            tickets = new JavaScriptSerializer().Deserialize<List<Ticket>>(response);

            return tickets;
        }

        public void update()
        {
            this.checkValidForSaving();

            TicketReceiveDTO ticketDTO = this.ticket.Adapt<TicketReceiveDTO>();

            var json = new JavaScriptSerializer().Serialize(ticketDTO);

            var response = this.httpRequest.patch(ConfigurationManager.AppSettings["host"].ToString() + "api/ticket/edit/", json);

        }

        public void delete()
        {
            var response = this.httpRequest.delete(ConfigurationManager.AppSettings["host"].ToString() + "api/ticket/delete/" + ticket.number);
            Debug.WriteLine(response);
        }
    }
}
