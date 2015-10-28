using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormatConversion
{
    class DataConver
    {
        //转化为BSQ格式
        public byte[] ToBSQ(byte[, ,] data)
        {
            byte[] converData=new byte[data.Length];;
            int count = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    for (int k = 0; k < data.GetLength(2); k++)
                    {
                        converData[count] = data[i, j, k];
                        count++;
                    }
                }
            }

                return converData;
 
        }

        //转化为BIL格式
        public byte[] TOBIL(byte[, ,] data)
        {
            byte[] converData = new byte[data.Length];
            int count = 0;
            for (int j = 0; j < data.GetLength(1); j++)
            {
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int k = 0; k < data.GetLength(2); k++)
                    {
                        converData[count] = data[i, j, k];
                        count++;
                    }
                }
            }

            return converData;
        }

        //转化为BIP格式
        public byte[] ToBIP(byte[, ,] data)
        {
            byte[] converData = new byte[data.Length]; ;
            int count = 0;
            for (int j = 0; j < data.GetLength(1); j++)
            {
                for (int k = 0; k < data.GetLength(2); k++)
                {
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        converData[count] = data[i, j, k];
                        count++;
                    }
                }
            }

            return converData;
        }
    }
}
