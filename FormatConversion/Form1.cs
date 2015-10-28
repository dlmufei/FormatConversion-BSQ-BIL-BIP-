using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FormatConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //头文件数据
        byte[] headData;
      

        //转化后的一维图像数据
        byte[] converData;

        string dataType;//数据类型
        int samples = 0;//列数
        int lines = 0;//行数
        int bands = 0;//波段数

        //根据文件头获取数据文件路径
        string filePath;

        //
        BinaryReader binaryReader;        

        //数据转换使用
        DataConver dataConver = new DataConver();
        ReadData readData = new ReadData();

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "栅格数据头文件(*.HDR)|*.HDR";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                 textBoxFileName.Text = OFD.FileName;

                 FileStream fsHead = new FileStream(OFD.FileName, FileMode.Open);
                headData = new byte[fsHead.Length];

                fsHead.Seek(0, SeekOrigin.Begin);
                fsHead.Read(headData, 0, headData.Length);
                fsHead.Close();

                //获取数据文件路径
                filePath = textBoxFileName.Text.Split('.')[0];//同名文件路径

                //获取头文件数据
                samples = Convert.ToInt32(System.Text.Encoding.ASCII.GetString(headData, 258, 4));
                lines = Convert.ToInt32(System.Text.Encoding.ASCII.GetString(headData, 274, 4));
                bands = Convert.ToInt32(System.Text.Encoding.ASCII.GetString(headData, 290, 1));
                dataType = System.Text.Encoding.ASCII.GetString(headData, 367, 3);                

                //改变radioButton控件的可用性
                radioButtonChange(dataType);

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("磁盘中该文件不存在！");
                    return;
                }


                FileStream fsData = new FileStream(filePath, FileMode.Open);
                binaryReader = new BinaryReader(fsData);
                progressBar1.Maximum =(int)binaryReader.BaseStream.Length;

                progressBar1.Value = (int)(progressBar1.Maximum * 0.2);

                //binaryReader.BaseStream.Position = 1400;
                //MessageBox.Show(binaryReader.ReadByte().ToString());

            }
            else
            {
                return;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            //SFD.Filter = "文档(*.txt)|*.txt";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                 textBoxSaveAs.Text = SFD.FileName;                 
                
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //
            converData=new byte[binaryReader.BaseStream.Length];
            //头文件更改
            byte[] converHeadData=new byte[headData.Length];

            if(dataType=="bil")
            {
                if(radioButtonBIP.Checked==true)
                {
                    converData=dataConver.ToBIP(readData.readBIL(binaryReader,bands,lines,samples));
                   
                    converHeadData = ModifyHeadData(headData, "bip");
                }else if (radioButtonBSQ.Checked == true)
                {
                    converData = dataConver.ToBSQ(readData.readBIL(binaryReader, bands, lines, samples));
                    converHeadData=ModifyHeadData(headData,"bsq");
                }
                else
                { MessageBox.Show("请先选择转换格式！"); return; }
            }

            if(dataType=="bip")
            {
                if(radioButtonBIL.Checked==true)
                {
                    converData=dataConver.TOBIL(readData.readBIP(binaryReader,bands,lines,samples));
                    converHeadData=ModifyHeadData(headData,"bil");
                }else if(radioButtonBSQ.Checked==true)
                {
                    converData=dataConver.ToBSQ(readData.readBIP(binaryReader,bands,lines,samples));
                    converHeadData=ModifyHeadData(headData,"bsq");
                }
                else
                { MessageBox.Show("请先选择转换格式！"); return; }
            }

            if(dataType=="bsq")
            {
                if(radioButtonBIP.Checked==true)
                {
                    converData=dataConver.ToBIP(readData.readBSQ(binaryReader,bands,lines,samples));
                    converHeadData=ModifyHeadData(headData,"bip");
                }else if(radioButtonBIL.Checked==true)
                {
                    converData=dataConver.TOBIL(readData.readBSQ(binaryReader,bands,lines,samples));
                    converHeadData=ModifyHeadData(headData,"bil");
                }
                else
                { MessageBox.Show("请先选择转换格式！"); return; }
            }
            progressBar1.Value = (int)(progressBar1.Maximum * 0.8);

            //数据字节流写入文件
            WriteData(textBoxSaveAs.Text,converData);
            progressBar1.Value = (int)(progressBar1.Maximum * 0.95);
            //数据头字节流写入文件
            string headFilePath = textBoxSaveAs.Text.Trim() + ".HDR";
            progressBar1.Value = progressBar1.Maximum;
            WriteData(headFilePath, converHeadData);

            MessageBox.Show("数据转换完成！");


            

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //转换格式的自动变换
        private void radioButtonChange(string datatype)
        {
            if (datatype == "bil")
            {
                radioButtonBIL.Enabled = false;
                radioButtonBIP.Enabled = true;
                radioButtonBSQ.Enabled = true;
            }
            if (datatype == "bip")
            {
                radioButtonBIL.Enabled = true;
                radioButtonBIP.Enabled = false;
                radioButtonBSQ.Enabled = true;
            }
            if (datatype == "bsq")
            {
                radioButtonBIL.Enabled = true;
                radioButtonBIP.Enabled = true;
                radioButtonBSQ.Enabled = false;
            }
        }


        //数据写入操作
        private void WriteData(string path, byte[] data)
        {
            if (!string.IsNullOrEmpty(path))
            {
                FileStream fs = new FileStream(path, FileMode.Create);                
                fs.Write(data, 0, data.Length);
                fs.Close();
                
            }
            else
            {
                MessageBox.Show("请先输入输出路径！");
            }
        }

        //修改最重要的头文件信息(简化处理)
        private byte[] ModifyHeadData(byte[] data,string type)
        {
            
            byte[] bt= System.Text.Encoding.ASCII.GetBytes(type);

            data[367] = bt[0];
            data[368] = bt[1];
            data[369] = bt[2];

            return data;
        }


        //
        ChartData chartData = new ChartData();
        byte[] img;
        private void buttonChart_Click(object sender, EventArgs e)
        {

            chartData.MadeChart(chart1, chartData.GetChartData(converData));
        }

        

        
    }
}
