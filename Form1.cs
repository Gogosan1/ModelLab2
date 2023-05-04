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
            ServiceProbability = new List<double>();
         FalureProbability = new List<double>();
            AverageProcessingTime = new List<List<double>>();
            AverageDownTime = new List<List<double>>();
            AverageWaitingTime = new List<List<double>>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int N = 50, _N = 51;
                double kvantil = 1.96;
                double tochnost = Convert.ToDouble(textBox1.Text);
                while (_N > N)
                {
                    N = _N;
                    for (int i = 0; i < N; i++)
                    {
                        model = new Model(Convert.ToInt32(modelingTime.Text), Convert.ToInt32(queueSize.Text), Convert.ToInt32(countOfHeandlers.Text),rnd);
                        // model.ModelingDone += UploadForm;

                        model.Modeling();
                        AverageProcessingTime.Add(new List<double>());
                        AverageDownTime.Add(new List<double>());
                        AverageWaitingTime.Add(new List<double>());
                        FindStatistics(i);
                    }

                    double servProb = 0;
                    for (int i = 0; i < ServiceProbability.Count; i++)
                    {
                        servProb += ServiceProbability[i];
                    }
                    _N = (int)(((servProb / N)*(1 - servProb/N) * Math.Pow(kvantil,2))/Math.Pow(tochnost,2));
                    if (_N > N)
                    {
                        ClearForm();
                    }
                }
                    UploadForm(N);
                    ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                modelingTime.Clear();
            }
        }

        private void ClearForm()
        {
            ServiceProbability.Clear();
            FalureProbability.Clear();
            AverageProcessingTime.Clear();
            AverageDownTime.Clear();
            AverageWaitingTime.Clear();
    }

        private void UploadForm(int n)
        {
            double servProb = 0, falureProb = 0;

            List<double> AverageProcessingT = new List<double>();
            List<double> AverageDownT = new List<double>();
            List<double> AverageWaitingT = new List<double>();
            for (int i = 0; i < AverageDownTime[0].Count; i++)
            {
                AverageProcessingT.Add(0);
                AverageDownT.Add(0);
                AverageWaitingT.Add(0);
            }
            dataGridView1.Rows.Clear();
            for (int i = 0; i < ServiceProbability.Count; i++)
            {
                servProb += ServiceProbability[i]; 
                falureProb += FalureProbability[i]; 
                for (int j = 0; j < AverageDownTime[i].Count; j++)
                {
                    AverageProcessingT[j] += AverageProcessingTime[i][j];
                    AverageDownT[j] += AverageDownTime[i][j];
                    AverageWaitingT[j] += AverageWaitingTime[i][j];
                }
            }


            serviceProbability.Text = $"Вероятность обслуживания {Math.Round(servProb/n,2)}";
            falureProbability.Text = $"Вероятность отказа {1 - Math.Round(servProb/n,2)}";
            
            var heandlers = model.Handlers;
          for (int i = 0; i < heandlers.Count; i++) 
            {
                dataGridView1.Rows.Add(i + 1, Math.Round(AverageProcessingT[i]/n, 2),
                    Math.Round(AverageDownT[i] / n, 2),
                    Math.Round(AverageWaitingT[i] / n,2));
            }


        }

        private void FindStatistics(int n)
        {
            ServiceProbability.Add(model.ServiceProbability);
            FalureProbability.Add(model.FalureProbability);

            var heandlers = model.Handlers;
            for (int i = 0; i < heandlers.Count; i++)
            {
                AverageProcessingTime[n].Add(heandlers[i].AverageProcessingTime);
                AverageDownTime[n].Add(heandlers[i].AverageDownTime);
                AverageWaitingTime[n].Add(heandlers[i].AverageWaitingTime);
            }


        }
        private List<double> ServiceProbability;
        private List<double> FalureProbability;
        private List<List<double>> AverageProcessingTime;
        private List<List<double>> AverageDownTime;
        private List<List<double>> AverageWaitingTime;

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
