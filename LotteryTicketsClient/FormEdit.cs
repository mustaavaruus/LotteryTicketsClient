using LotteryTicketsClient.BLL;
using LotteryTicketsClient.Models;
using LotteryTicketsClient.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LotteryTicketsClient
{
    public partial class FormEdit : Form
    {
        public static FormEdit instance;
        public TextBox tbNumber;
        public TextBox tbCirculation;
        public TextBox tbChoosedNumbersCount;
        public TextBox tbChoosedNumbers;
        private string mode;

        public FormEdit(string mode)
        {
            InitializeComponent();
            instance = this;
            tbNumber = textBoxNumber;
            tbCirculation = textBoxCirculation;
            tbChoosedNumbersCount = textBoxChoosedNumbersCount;
            tbChoosedNumbers = textBoxChoosedNumbers;
            this.mode = mode;
        }

        private bool isValidForSave()
        {

            if (textBoxChoosedNumbers.Text.Split(" ").Length < Constants.MIN_CHOOSED_NUMBERS_COUNT)
            {

                MessageBox.Show("Количество выбранных чисел должно быть в диапазоне от (" +
                    Constants.MIN_CHOOSED_NUMBERS_COUNT +
                    "до " +
                    Constants.MAX_CHOOSED_NUMBERS_COUNT +
                    ")");

                return false;
            }

            if (textBoxChoosedNumbers.Text.Split(" ").Length > Constants.MAX_CHOOSED_NUMBERS_COUNT)
            {
                MessageBox.Show("Количество выбранных чисел должно быть в диапазоне от (" +
                    Constants.MIN_CHOOSED_NUMBERS_COUNT +
                    "до " +
                    Constants.MAX_CHOOSED_NUMBERS_COUNT +
                    ")");

                return false;
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (isValidForSave())
            {
                try
                {
                    Ticket ticket = new Ticket();
                    ticket.circulation = Int32.Parse(textBoxCirculation.Text);
                    ticket.choosedNumbersCount = Int32.Parse(textBoxChoosedNumbersCount.Text);
                    ticket.choosedNumbers = new List<int>();

                    for (var i = 0; i < textBoxChoosedNumbers.Text.Split(" ").Length; i++)
                    {
                        ticket.choosedNumbers.Add(Int32.Parse(textBoxChoosedNumbers.Text.Split(" ")[i]));
                    }

                    TicketProcessing ticketProcessing = new TicketProcessing(ticket);

                    if (this.mode.Equals(Constants.MODE_ADD))
                    {
                        ticketProcessing.add();
                    }

                    if (this.mode.Equals(Constants.MODE_EDIT))
                    {

                        ticket.number = Guid.Parse(textBoxNumber.Text);
                        ticketProcessing.update();
                    }

                    this.Close();
   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxChoosedNumbers_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxChoosedNumbers.Text))
            {
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxChoosedNumbers.Text, @"^[\d\s]+$"))
            {
                MessageBox.Show("Для ввода разрешены только цифры");
                textBoxChoosedNumbers.Text = textBoxChoosedNumbers.Text.Remove(textBoxChoosedNumbers.Text.Length - 1);
            }

            textBoxChoosedNumbers.Text = textBoxChoosedNumbers.Text.Replace("  ", "");

            textBoxChoosedNumbersCount.Text = textBoxChoosedNumbers.Text.ToString().Trim(' ').Split(" ").Length.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBoxCirculation_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCirculation.Text, "[^0-9]"))
            {
                MessageBox.Show("Разрешено вводить только" +
                    " числа от " +
                    Constants.MIN_CIRCULATION_NUMBER +
                    " до " +
                    Constants.MAX_CIRCULATION_NUMBER
                    );
                textBoxCirculation.Text = textBoxCirculation.Text.Remove(textBoxCirculation.Text.Length - 1);
                return;
            }

            if (String.IsNullOrEmpty(textBoxCirculation.Text))
            {
                return;
            }

            var inputNumber = Int32.Parse(textBoxCirculation.Text);

            if ((inputNumber < Constants.MIN_CIRCULATION_NUMBER) || (inputNumber > Constants.MAX_CIRCULATION_NUMBER)) {
                MessageBox.Show("Разрешено вводить только" +
                    " числа от " +
                    Constants.MIN_CIRCULATION_NUMBER +
                    " до " +
                    Constants.MAX_CIRCULATION_NUMBER
                    );
                textBoxCirculation.Text = textBoxCirculation.Text.Remove(textBoxCirculation.Text.Length - 1);
                return;
            }


        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
