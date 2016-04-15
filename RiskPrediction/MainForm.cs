using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using AForge.Neuro;
using AForge.Neuro.Learning;

namespace RiskPrediction
{
    public partial class MainForm : Form
    {
        double[][] Input{get; set; }
        double[][] Output { get; set; }
        double[][] CacuInput { get; set; }
        double[][] CacuOutput { get; set; }
        private ActivationNetwork ActivationNetwork { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            const string defalutInputFile = "input.csv";
            const string defalutOutputFile = "output.csv";
            if (File.Exists(defalutInputFile))
            {
                ImportInput(defalutInputFile, defalutInputFile);
            }
            if (File.Exists(defalutOutputFile))
            {
                ImportOutput(defalutOutputFile, defalutOutputFile);
            }
        }


        private double[][] Import(string fileName)
        {
            using (var reader = File.OpenText(fileName))
            {
                var result = new List<double[]>();
                string line;
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    var datas = line.Split(';');
                    if (datas.Length == 1)
                        datas = line.Split(',');
                    result.Add(datas.Select(double.Parse).ToArray());
                }
                return result.ToArray();
            }
        }

        private void Export(double[][] array, string fileName)
        {
            var content = "";
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array[i].Length; j++)
                {
                    content += Math.Round(array[i][j],2) + ",";
                }
                content += "\r\n";
            }

            var stream = File.OpenWrite(fileName);
            using (var writer = new StreamWriter(stream)) //using 的作用是操作完之后内存的
            //就释放该块的内容
            {
                writer.Write(content);
            }
        }


        private double Premnmx(double num, double min, double max)
        {
            if (num > max)
                num = max;
            if (num < min)
                num = min;

            return (num - min) / (max - min);
        }

        private double[][] Premnmx(double[][] array)
        {
            var arrayMax = new double[array.Length];
            var arrayMin = new double[array.Length];

            for (var i = 0; i < array.Length; i++)
            {
                var min = double.MaxValue;
                var max = double.MinValue;
                for (var j = 0; j < array[0].Length; j++)
                {
                    if (min > array[i][j])
                    {
                        min = array[i][j];
                    }
                    if (max < array[i][j])
                    {
                        max = array[i][j];
                    }
                }
                arrayMax[i] = max;
                arrayMin[i] = min;
            }
            for (var i = 0; i < array.Length; i++)
            {
                var min = arrayMin[i];
                var max = arrayMax[i];
                for (var j = 0; j < array[0].Length; j++)
                {
                    array[i][j] = Premnmx(array[i][j], min, max);
                }
            }
            return array;
        }

        private double[][] Divide10(double[][] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array[0].Length; j++)
                {
                    array[i][j] = array[i][j]/10;
                }
            }
            return array;
        }

        private double[][] Mult10(double[][] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array[0].Length; j++)
                {
                    array[i][j] = array[i][j] * 10;
                }
            }
            return array;
        }


        private void inputFileImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportInput(openFileDialog.FileName,openFileDialog.SafeFileName);
            }
        }

        private void ImportInput(string fileName,string safeFileName)
        {
            inputfileNameLbl.Text = safeFileName;
            var input = Import(fileName);
            Input = input;
            inputLengthLbl.Text = input[0].Length.ToString();
            inputCountLbl.Text = input.Length.ToString();
        }

        private void outputFileImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportOutput(openFileDialog.FileName, openFileDialog.SafeFileName);
            }
        }

        private void ImportOutput(string fileName, string safeFileName)
        {
            outputfileNameLbl.Text = safeFileName;
            var output = Import(fileName);
            Output = output;
            outputLengthLbl.Text = output[0].Length.ToString();
            outputCountLbl.Text = output.Length.ToString();
        }

        private void cacuInputImportBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cacufileNameLbl.Text = openFileDialog.SafeFileName;
                CacuInput = Import(openFileDialog.FileName);
                cacuInputLengthLbl.Text = CacuInput[0].Length.ToString();
                cacuInputCountLbl.Text = CacuInput.Length.ToString();
            }
        }

        private void learnBtn_Click(object sender, EventArgs e)
        {
            ActivationNetwork = new ActivationNetwork(new SigmoidFunction(2), Input[0].Length, int.Parse(NeuroCountTb.Text), Output[0].Length);
            var teacher = new BackPropagationLearning(ActivationNetwork);

            // 定义绝对误差 
            var error = double.MaxValue;

            teacher.LearningRate = 0.1;

            var input = Premnmx(Input);
            var output = Divide10(Output);

            // 迭代次数 
            var iterations = 0;
            while (error >= double.Parse(maxErrorTb.Text) && iterations < int.Parse(iterationCountTb.Text))
            {
                error = teacher.RunEpoch(input, output);
                iterations++;
            }
            MessageBox.Show(string.Format("学习完毕，共计迭代{0}次，总计误差为{1},平均误差为{2},", iterations, error, error/Input.Length));
        }

       


        private void cacuBtn_Click(object sender, EventArgs e)
        {
            CacuOutput = new double[CacuInput.Length][];
            var cacuIntput = Premnmx(CacuInput);
            for (var i = 0; i < CacuInput.Length; i++)
            {
                CacuOutput[i] = ActivationNetwork.Compute(cacuIntput[i]);
            }

            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Export(Mult10(CacuOutput), saveFileDialog.FileName);
            }
        }

        private void exportNetBtn_Click(object sender, EventArgs e)
        {
            ActivationNetwork.Save("network");
            MessageBox.Show("导出成功");
        }

        private void importNetBtn_Click(object sender, EventArgs e)
        {
            ActivationNetwork = Network.Load("network") as ActivationNetwork;
            MessageBox.Show("导入成功");
        }


    }
}
