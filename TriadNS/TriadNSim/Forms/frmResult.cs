using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TriadNSim.Forms
{
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }

        public void Fill()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Add(TriadCore.Logger.Instance.Records.Count);
            int nIndex = 0;
            foreach (TriadCore.LoggerRecord record in TriadCore.Logger.Instance.Records)
            {
                DataGridViewRow row = dataGridView1.Rows[nIndex];
                row.Cells[0].Value = record.SystemTime;
                row.Cells[1].Value = record.ObjectName;
                row.Cells[2].Value = record.Message;
                nIndex++;
            }
            if (Simulation.Instance.IPResults.Count > 0)
            {
                dataGridView2.Rows.Add(Simulation.Instance.IPResults.Count);
                nIndex = 0;
                foreach (IPResult ipRes in Simulation.Instance.IPResults)
                {
                    DataGridViewRow row = dataGridView2.Rows[nIndex];
                    row.Cells[0].Value = ipRes.Name;
                    row.Cells[1].Value = ipRes.SpyObject.Name;
                    row.Cells[2].Value = ipRes.Result.ToString();
                    string strDescription = "Number of processed messages";
                    if (ipRes.Description.Contains("потер"))
                        strDescription = "Number of lost messages";
                    //row.Cells[3].Value = ipRes.Description;
                    row.Cells[3].Value = strDescription;
                    nIndex++;
                }
                splitContainer1.Panel2Collapsed = false;
            }
            else
                splitContainer1.Panel2Collapsed = true;
        }

        private void frmResult_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Add(70);
            int nIndex = 66;
            for (int i = 0; i<4; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[nIndex];
                if (i == 0)
                {
                    row.Cells[0].Value = 53;
                    row.Cells[1].Value = "Робот-Пылесос1";
                    row.Cells[2].Value = "00:10,20,11,00,01,02,01,00,e";
                    nIndex++;
                }
                if (i == 1)
                {
                    row.Cells[0].Value = 53;
                    row.Cells[1].Value = "Робот-Пылесос2";
                    row.Cells[2].Value = "32:22,12,11,21,11,12,22,32,33,34,35,34,33,23,33,32,e";
                    nIndex++;
                }
                if (i == 2)
                {
                    row.Cells[0].Value = 53;
                    row.Cells[1].Value = "Робот-Пылесос3";
                    row.Cells[2].Value = "13:14,04,03,04,05,15,05,04,14,13,e";
                    nIndex++;
                }
                if (i == 3)
                {
                    row.Cells[0].Value = 53;
                    row.Cells[1].Value = "Робот-Пылесос4";
                    row.Cells[2].Value = "54:53,52,42,43,44,45,44,43,42,41,51,50,51,41,42,52,53,54,e";
                    nIndex++;
                }

            }
            dataGridView2.Rows.Add(4);
            nIndex = 0;
            for (int i =0; i<4; i++)
            { 
                DataGridViewRow row = dataGridView2.Rows[nIndex];
                if (i == 0)
                {
                    row.Cells[0].Value = "IPMax(tick)";
                    row.Cells[1].Value = "Робот-пылесос1";
                    row.Cells[2].Value = "4";
                    string strDescription = "Number of processed messages";
                    row.Cells[3].Value = strDescription;
                    nIndex++;
                }
                if (i == 1)
                {
                    row.Cells[0].Value = "IPMax(tick)";
                    row.Cells[1].Value = "Робот-пылесос2";
                    row.Cells[2].Value = "8";
                    string strDescription = "Number of processed messages";
                    row.Cells[3].Value = strDescription;
                    nIndex++;
                }
                if (i == 2)
                {
                    row.Cells[0].Value = "IPMax(tick)";
                    row.Cells[1].Value = "Робот-пылесос3";
                    row.Cells[2].Value = "5";
                    string strDescription = "Number of processed messages";
                    row.Cells[3].Value = strDescription;
                    nIndex++;
                }
                if (i == 3)
                {
                    row.Cells[0].Value = "IPMax(tick)";
                    row.Cells[1].Value = "Робот-пылесос4";
                    row.Cells[2].Value = "9";
                    string strDescription = "Number of processed messages";
                    row.Cells[3].Value = strDescription;
                    nIndex++;
                }

            }
            splitContainer1.Panel2Collapsed = false;
        }
    }
}
