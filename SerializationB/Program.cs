using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TestBinarySerialization
{
    //建立可序列化類別
    [Serializable]
    public class ClsSerializable
    {
        private int _Number;
        private string _Demo;
        public ClsSerializable()
        {
            this._Number = 254;
            this._Demo = "this is a book";
        }

        public int Number
        {
            get { return this._Number; }
        }
        public string Demo
        {
            get { return this._Demo; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============驗證還原序列化物件===============");
            Program oProgram = new Program();
            oProgram.SerializeBinary();
            ClsSerializable o = oProgram.DeSerialize();
            Console.WriteLine("============驗證還原序列化物件===============");
            Console.WriteLine("ClsSerializable.Number : " + o.Number);
            Console.WriteLine("ClsSerializable.Demo : " + o.Demo);
            Console.ReadKey();
        }

        //序列化函式
        private void SerializeBinary()
        {
            //建立物件
            ClsSerializable oClsSerializable = new ClsSerializable();
            //建立資料流物件
            FileStream oFileStream = new FileStream(@"D:\sbinary.txt", FileMode.Create);
            //建立二進位格式化物件
            BinaryFormatter myBinaryFormatter = new BinaryFormatter();
            Console.WriteLine("二進位格式序列化......");
            //將物件進行二進位格式序列化，並且將之儲存成檔案
            myBinaryFormatter.Serialize(oFileStream, oClsSerializable);
            oFileStream.Flush();
            oFileStream.Close();
            oFileStream.Dispose();
            Console.WriteLine("完成進位格式序列化......");
        }

        //反序列函式
        private ClsSerializable DeSerialize()
        {
            ClsSerializable o = null;
            FileStream oFileStream = new FileStream(@"D:\sbinary.txt", FileMode.Open);
            BinaryFormatter myBinaryFormatter = new BinaryFormatter();
            Console.WriteLine("開始還原序列化物件......");
            //將檔案還原成原來的物件
            o = (ClsSerializable)myBinaryFormatter.Deserialize(oFileStream);
            return o;
        }
    }
}
