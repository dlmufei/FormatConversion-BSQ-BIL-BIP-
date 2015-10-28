using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FormatConversion
{
    class ReadData
    {

        //根据行列以及波段数来读取文件数据
        //BSQ合适读取
        public byte[, ,] readBSQ(BinaryReader br, int bands, int lines, int simples)
        {
            br.BaseStream.Position = 0;
            //多维数组存储图像
            byte[, ,] data = new byte[bands, lines, simples];
            //
            for(int i=0;i<bands;i++)
            {
                for(int j=0;j<lines;j++)
                {
                    for (int k = 0; k < simples; k++)
                    {
                        data[i,j,k] = br.ReadByte();
                    }
                }
            }

            return data;

        }

        //BIL格式读取
        public byte[, ,] readBIL(BinaryReader br, int bands, int lines, int simples)
        {
            br.BaseStream.Position = 0;
            //多维数组存储图像
            byte[, ,] data = new byte[bands, lines, simples];
            //
            for (int j = 0; j < lines; j++)
            {
                for (int i = 0; i < bands; i++)
                {
                    for (int k = 0; k < simples; k++)
                    {
                        data[i, j, k] = br.ReadByte();
                    }
                }
            }            
            return data;
        }

        //BIP格式读取
        public byte[, ,] readBIP(BinaryReader br, int bands, int lines, int simples)
        {
            br.BaseStream.Position = 0;
            //多维数组存储图像
            byte[, ,] data = new byte[bands, lines, simples];
            //
            for (int j = 0; j < lines; j++)
            {
                for (int k = 0; k < simples; k++)
                {
                    for (int i = 0; i < bands; i++)
                    {
                        data[i, j, k] = br.ReadByte();
                    }
                }
            }
            return data;
        }



    }
}
