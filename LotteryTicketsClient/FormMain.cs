using LotteryTicketsClient.BLL;
using LotteryTicketsClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryTicketsClient
{
    public partial class FormMain : Form
    {
        public static FormMain instance;
        public DataGridView dGVTable;

        private List<Ticket> tickets = new List<Ticket>();

        public void fillTickets()
        {
            try
            {
                tickets.Clear();
                Ticket ticket = new Ticket();  

                TicketProcessing ticketProcessing = new TicketProcessing(ticket);

                tickets = ticketProcessing.get();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public FormMain()
        {
            InitializeComponent();
            instance = this;
            refreshTable();
        }

        

        private void clearTable()
        {
            dataGridViewTable.Rows.Clear();
            dataGridViewTable.Refresh();
        }

        private void populateTable()
        {
            //dataGridViewTable.DataSource = tickets;

            for (var i = 0; i < tickets.Count; i++)
            {
                dataGridViewTable.Rows.Add();

                dataGridViewTable.Rows[i].Cells[0].Value = tickets[i].number;
                dataGridViewTable.Rows[i].Cells[1].Value = tickets[i].circulation;
                dataGridViewTable.Rows[i].Cells[2].Value = tickets[i].choosedNumbersCount;

                if (tickets[i].choosedNumbers != null)
                {
                    dataGridViewTable.Rows[i].Cells[3].Value = string.Join(" ", tickets[i].choosedNumbers);
                }
            }
        }

        private void refreshTable()
        {
            fillTickets();
            clearTable();
            populateTable();
        }

        private string getCellValueByIndexes(int i, int j)
        {
            try
            {
                var value = dataGridViewTable.Rows[i].Cells[j].Value;

                if (value != null)
                {
                    return dataGridViewTable.Rows[i].Cells[j].Value.ToString();
                }
                
            }
            catch (Exception e)
            {
                Debug.WriteLine("ERROR: " + i + " " + j + " " + e.Message);
                return "";
            }
            return "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit("ADD");
            formEdit.Show();
            FormEdit.instance.tbNumber.Enabled = false;

            var rowIndex = dataGridViewTable.CurrentCell.RowIndex;

            FormEdit.instance.tbNumber.Text = "";
            FormEdit.instance.tbCirculation.Text = "";
            FormEdit.instance.tbChoosedNumbersCount.Text = "";
            FormEdit.instance.tbChoosedNumbers.Text = "";

            formEdit.FormClosed += delegate
            {
                refreshTable();
            };


        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit("UPDATE");
            formEdit.Show();
            FormEdit.instance.tbNumber.Enabled = true;

            var rowIndex = dataGridViewTable.CurrentCell.RowIndex;

            FormEdit.instance.tbNumber.Text = getCellValueByIndexes(rowIndex, 0);
            FormEdit.instance.tbCirculation.Text = getCellValueByIndexes(rowIndex, 1);
            FormEdit.instance.tbChoosedNumbersCount.Text = getCellValueByIndexes(rowIndex, 2);
            FormEdit.instance.tbChoosedNumbers.Text = getCellValueByIndexes(rowIndex, 3);

            formEdit.FormClosed += delegate
            {
                refreshTable();
            };
        }


        private void dataGridViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Удалить", MessageBoxButtons.YesNo) ==
                     System.Windows.Forms.DialogResult.Yes)
            {
                Ticket ticket = new Ticket();

                if (dataGridViewTable.CurrentCell == null)
                {
                    return;
                }

                var rowIndex = dataGridViewTable.CurrentCell.RowIndex;

                var guidStr = getCellValueByIndexes(rowIndex, 0);
                if (String.IsNullOrEmpty(guidStr))
                {
                    return;
                }
                ticket.number = Guid.Parse(getCellValueByIndexes(rowIndex, 0));

                TicketProcessing ticketProcessing = new TicketProcessing(ticket);


                ticketProcessing.delete();

                refreshTable();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
           for (var i = 0; i < dataGridViewTable.Rows.Count - 1; i++)
            {
                dataGridViewTable.Rows[i].Visible = true;


                //закоментил, т.к. в guid'e встречаются сразу много цифр - демонстрация фильтра не видна
                /*if (dataGridViewTable.Rows[i].Cells[0].Value.ToString().Contains(textBoxSearch.Text))
                {
                   continue;
                }*/

                var val = dataGridViewTable.Rows[i].Cells[1].Value;
                if ((val != null) && (val.ToString().Contains(textBoxSearch.Text)))
                {
                    continue;
                }

                val = dataGridViewTable.Rows[i].Cells[2].Value;
                if ((val != null) && (val.ToString().Contains(textBoxSearch.Text)))
                {
                    continue;
                }

                val = dataGridViewTable.Rows[i].Cells[3].Value;
                if ((val != null) && (val.ToString().Contains(textBoxSearch.Text)))
                {
                    continue;
                }

                dataGridViewTable.Rows[i].Visible = false;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }
    }
}
