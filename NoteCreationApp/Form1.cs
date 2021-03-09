using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCreationApp
{
    public partial class Form1 : Form{
        DataTable savedDataTable;
        public Form1(){
            InitializeComponent();
        } 


        private void Form1_Load(object sender, EventArgs e){
            savedDataTable = new DataTable();
            savedDataTable.Columns.Add("Title", typeof(String));
            savedDataTable.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = savedDataTable;
             
        }
        
        private void newMessageButton_Click(object sender, EventArgs e){
            textTitleInput.Clear();
            textMessageInput.Clear();

        }

        private void saveMessageButton_Click(object sender, EventArgs e){
            savedDataTable.Rows.Add(textTitleInput.Text, textMessageInput.Text);
            textTitleInput.Clear();
            textMessageInput.Clear();
        }

        private void readMessageButton_Click(object sender, EventArgs e){
            int tableIndex = dataGridView1.CurrentCell.RowIndex;

            if(tableIndex > -1){
                textTitleInput.Text = savedDataTable.Rows[tableIndex].ItemArray[0].ToString();
                textMessageInput.Text = savedDataTable.Rows[tableIndex].ItemArray[1].ToString();

            }

        }

        private void deleteMessageButton_Click(object sender, EventArgs e){
            int tableIndex = dataGridView1.CurrentCell.RowIndex;
            savedDataTable.Rows[tableIndex].Delete();
        }
    }
}
