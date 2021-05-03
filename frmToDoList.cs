using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class formToDoList : Form
    {
        List<ToDo> todoListTemp = new List<ToDo>();
        public formToDoList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = txbItem.Text;
            DateTime date = DateTime.Now;
            ToDo.Levels level;

            try
            {
                StreamWriter writer = new StreamWriter("ToDoList.txt");
                writer.WriteLine(txbItem.Text + "#" + date + "#" + cmbLevels.SelectedItem.ToString());

                switch (cmbLevels.SelectedItem.ToString())
                {
                    case "Low":
                        level = ToDo.Levels.Low;
                        break;
                    case "Medium":
                        level = ToDo.Levels.Medium;
                        break;
                    default:
                        level = ToDo.Levels.High;
                        break;
                }
                ToDo item = new ToDo(description, date, level);
                todoListTemp.Add(item);
                writer.Close();
            }
            catch
            {

            }
            return;
        }
    }
}