using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (listLeft.SelectedItems.Count == 0)//判断listLeft是否选择项目
            {
                return;
            }
            else
            {
                listRight.Items.Add(listLeft.SelectedItem);//添加左侧数据到右侧
                listLeft.Items.Remove(listLeft.SelectedItem);//删除左侧项目的信息

            }
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            foreach (object item in listLeft.Items)//遍历左侧的数据
            {
                listRight.Items.Add(item);//添加数据到右侧列表
            }
            listLeft.Items.Clear();//清空左侧列表数据
        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            foreach (object item in listRight.Items)//遍历右侧的数据
            {
                listLeft.Items.Add(item);//添加数据到左侧列表
            }
            listRight.Items.Clear();//清空右侧列表数据
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (listRight.SelectedItems.Count == 0)//判断listLeft是否选择项目
            {
                return;
            }
            else
            {
                listLeft.Items.Add(listRight.SelectedItem);//添加左侧数据到右侧
                listRight.Items.Remove(listRight.SelectedItem);//删除左侧项目的信息

            }
        }

      

    }
}
