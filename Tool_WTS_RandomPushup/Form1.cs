using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_WTS_RandomPushup
{
    public partial class Form1 : Form
    {
        Data data;
        Dictionary<string, int> dataPushup = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();

            LoadData();
        }
        void LoadData()
        {
            data = new Data();
            tbxStartCount.Text = data.startCount.ToString();
            tbxNextMin.Text = data.bonusMinCount.ToString();
            tbxNextMax.Text = data.bonusMaxCount.ToString();
            rtbxInput.Text = data.members;
        }
        void SaveData()
        {
            int.TryParse(tbxStartCount.Text, out data.startCount);
            int.TryParse(tbxNextMin.Text, out data.bonusMinCount);
            int.TryParse(tbxNextMax.Text, out data.bonusMaxCount);
            data.members = rtbxInput.Text;


            dataPushup.Clear();


            string[] temps = data.members.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < temps.Length; i++)
            {
                string temp = temps[i].Trim();
                if (!dataPushup.ContainsKey(temp))
                    dataPushup.Add(temp, data.startCount);
            }
        }
        private void ShowResult()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in dataPushup)
            {
                builder.Append(item.Key);
                builder.Append("  -  ");
                builder.Append(item.Value);
                builder.Append("\n");
            }
            rtbxOutput.Text = builder.ToString();
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            SaveData();

            int totalMember = dataPushup.Count;

            List<string> keys = dataPushup.Keys.ToList();
            keys.Shuffle();

            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            int temp = data.startCount;
            for (int i = 0; i < keys.Count; i++)
            {
                if (i != 0)
                {
                    temp += random.Next(data.bonusMinCount, data.bonusMaxCount);
                    dataPushup[keys[i]] = temp;
                }

                builder.Append(keys[i]);
                builder.Append("  -  ");
                builder.Append(dataPushup[keys[i]]);
                builder.Append("\n");
            }
            rtbxOutput.Text = builder.ToString();
        }
    }
}
