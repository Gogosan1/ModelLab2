using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conveyorSystem
{
    public partial class Form1 : Form
    {
        private Model model;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                model = new Model(Convert.ToInt32(modelingTime.Text), Convert.ToInt32(queueSize.Text), Convert.ToInt32(countOfHeandlers.Text));
                model.ModelingDone += UploadForm;
                model.Modeling();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                modelingTime.Clear();
            }
        }

        private void UploadForm()
        {
            dataGridView1.Rows.Clear();
            serviceProbability.Text += $" {model.ServiceProbability}";
            falureProbability.Text += $" {model.FalureProbability}";
            
            var heandlers = model.Handlers;
          for (int i = 0; i < heandlers.Count; i++) 
            {
                dataGridView1.Rows.Add(i + 1, heandlers[i].AverageProcessingTime, 
                    heandlers[i].AverageDownTime, 
                    heandlers[i].AverageWaitingTime);
            }
        }
    }
}
