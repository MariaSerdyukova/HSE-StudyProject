﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using pouch_controller.Core;

namespace pouch_controller
{
    public partial class MainWindow : Form
    {
        private Controller controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Day.Checked = false;
            Week.Checked = false;
            Month.Checked = false;
            Year.Checked = false;
            AllTime.Checked = true;
            DeletePanel.Visible = false;
            UpdateData();
        }

        private void AddNewSpending_Click(object sender, EventArgs e)
        {
            AddNewPanel.Visible = true;
        }

        private void AddingCurrentDate_CheckedChanged(object sender, EventArgs e)
        {
            AddingDateTime.Enabled = !AddingCurrentDate.Checked;
        }

        private void AddingCancel_Click(object sender, EventArgs e)
        {
            AddNewPanel.Visible = false;
            AddingCount.Text = "0";
            AddingTegs.Text = "";
            AddingDescribtion.Text = "";
            AddingCurrentDate.Checked = false;
        }
        private void UpdateData()
        {
            spendingTree.Nodes.Clear();
            var n = 0;
            foreach (var i in controller.Records)
            {
                if (CompareData(i.Date, DateTime.Now))
                {
                    if (TegsText.Text == "Tags:" || CompareTags(i.Tags, TegsText.Text
                        .Replace(" ", string.Empty)
                        .Replace("\r\n", string.Empty)
                        .Replace("\n", string.Empty)
                        .Split('#')))
                    {
                        spendingTree.Nodes.Add(String.Format("{0}: Spending - {1}", i.Date.ToShortDateString(), i.Count));
                        spendingTree.Nodes[n].Nodes.Add(String.Format("ID: {0}", i.ID));
                        spendingTree.Nodes[n].Nodes.Add(String.Format("Count: {0}", i.Count));
                        spendingTree.Nodes[n].Nodes.Add(String.Format("Bought: {0}", i.Describtion));
                        spendingTree.Nodes[n].Nodes.Add("Tags");
                        if (i.Tags != null && i.Tags.Count > 0)
                            foreach (var k in i.Tags)
                            {
                                if (k != "")
                                    spendingTree.Nodes[n].Nodes[3].Nodes.Add(String.Format("#{0}", k));
                            }
                        n++;
                    }
                }
            }
        }

        private bool CompareTags(List<string> a, string[] must_have_tags)
        {
            foreach(var i in must_have_tags)
            {
               if (!a.Contains(i) && !string.IsNullOrEmpty(i))
                    return false;
            }
            return true;
        }

        private bool CompareData(DateTime a, DateTime b)
        {
            if (Day.Checked)
            {
                return a.Day == b.Day && a.Month==b.Month && a.Year == b.Year;
            }
            else if (Week.Checked)
            {
                return (a.Year == b.Year && a.Month == b.Month && Math.Abs(a.Day - b.Day) < 7);
            }
            else if (Month.Checked)
            {
                return (a.Year == b.Year && a.Month == b.Month);
            }
            else if (Year.Checked)
            {
                return a.Year == b.Year;
            }
            else return true;
        }

        private void AddingAdd_Click(object sender, EventArgs e)
        {
            uint count = 0;
            try
            {
                count = Convert.ToUInt32(AddingCount.Text);
            }
            catch
            {
                return;
            }
            DateTime dt;
            if (AddingCurrentDate.Checked)
            {
                dt = DateTime.Now;
            }
            else
            {
                dt = AddingDateTime.Value;
            }
            AddNewPanel.Visible = false;
            controller.AddRecord(dt, count, AddingDescribtion.Text, AddingTegs.Text);
            AddingCount.Text = "0";
            AddingTegs.Text = "";
            AddingDescribtion.Text = "";
            AddingCurrentDate.Checked = false;
            UpdateData();
        }

        private void AllTime_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Year_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Month_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Week_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Day_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void TegsText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeletePanel.Visible = false;
            DeleteId.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeletePanel.Visible = true;
            DeleteId.Text = "";
        }

        private void DeleteButtonOk_Click(object sender, EventArgs e)
        {
            uint Id = 0;
            try
            {
                Id = Convert.ToUInt32(DeleteId.Text);
            }
            catch
            {
                return;
            }
            DeletePanel.Visible = false;
            DeleteId.Text = "";
            controller.DeleteRecord(Id);
            UpdateData();
        }
    }
}
