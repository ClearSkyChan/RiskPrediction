using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Neuro;
using AForge.Neuro.Learning;

namespace RiskPrediction
{
    public partial class MainForm : Form
    {
        private int InputLength { get; set; }
        private int SampleCount { get; set; }
        private int OutputLength { get; set; }
        public int OutputIndex { get; set; }
        public int InputIndex { get; set; }
        double[][] Input{get; set; }
        double[][] Output { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void dataImport_Click(object sender, EventArgs e)
        {
            Import();
            PremnmxInput();

            var netWork = new ActivationNetwork(new SigmoidFunction(2), InputLength,6,OutputLength);
            var teacher = new BackPropagationLearning(netWork);
            
            // 定义绝对误差 
            double error = 1.0;

            teacher.LearningRate = 0.1;

            // 迭代次数 
            int iterations = 0;

            while (error >= 0.001 && iterations < 100000)
            {   
                error = teacher.RunEpoch(Input, Output) ;
                iterations++;
            }

            var result = new double[SampleCount][];

            for (var i = 0; i < SampleCount; i++)
            {
                result[i] = netWork.Compute(Input[i]);
                for (var j = 0; j < result.Length; j++)
                {
                    //var bytes = System.Text.Encoding.Default.GetBytes(result[j] + ",");
                    //writer.Write(bytes,0,bytes.Length);
                }
                //writer.Write(System.Text.Encoding.Default.GetBytes("\r\n"), 0, 2);
            }


        }

        private void Import()
        {
            InputIndex = 0;
            OutputIndex = 65;

            InputLength = 65;
            OutputLength = 4;

            SampleCount = 7;
            Input = new double[SampleCount][];
            Output = new double[SampleCount][];
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameLbl.Text = openFileDialog.FileName;
                using (var reader = File.OpenText(openFileDialog.FileName))
                {
                    string line;
                    int lineCount = 0;

                    reader.ReadLine(); //表头跳过

                    while ((line = reader.ReadLine()) != null)
                    {
                        var datas = line.Split(';');
                        if (datas.Length == 1)
                            datas = line.Split(',');

                        Input[lineCount] = new double[InputLength];
                        for (var i = InputIndex; i < InputIndex+InputLength; i++)
                        {
                            Input[lineCount][i - InputIndex] = double.Parse(datas[i]);
                        }
                        Output[lineCount] = new double[OutputLength];
                        for (var i = OutputIndex; i < OutputIndex + OutputLength; i++)
                        {
                            Output[lineCount][i - OutputIndex] = double.Parse(datas[i]);
                        }
                        lineCount++;
                        ;
                    }
                }
            }
        }






        private static double Premnmx(double num, double min, double max)
        {
            if (num > max)
                num = max;
            if (num < min)
                num = min;

            return (num - min) / (max - min);
        }

        private void PremnmxInput()
        {

            var inputMax = new double[SampleCount];
            var inputMin = new double[SampleCount];
            for (var i = 0; i < SampleCount; i++)
            {
                var min = double.MaxValue;
                var max = double.MinValue;
                for (var j = 0; j < InputLength; j++)
                {
                    if (min > Input[i][j])
                    {
                        min = Input[i][j];
                    }
                    if (max < Input[i][j])
                    {
                        max = Input[i][j];
                    }
                }
                inputMax[i] = max;
                inputMin[i] = min;
            }

            for (var i = 0; i < SampleCount; i++)
            {
                var min = inputMin[i];
                var max = inputMax[i];
                for (var j = 0; j < InputLength; j++)
                {
                    Input[i][j] = Premnmx(Input[i][j], min, max);                 
                }
                for (var j = 0; j < OutputLength; j++)
                {
                    Output[i][j] = Output[i][j]/10;
                }
            }
        }


        private void Train(double[][] input, double[][] output)
        {
            var netWork = new ActivationNetwork(new SigmoidFunction(), InputLength, 8, 4);
            var teacher = new PerceptronLearning(netWork);

            // 定义绝对误差 
            double error = 1.0;

            // 迭代次数 
            int iterations = 0;

            while (error > 0.001 && iterations< 5000)
            {
                error = teacher.RunEpoch(input, output);                
                iterations++;
            }
        }
    }
}
