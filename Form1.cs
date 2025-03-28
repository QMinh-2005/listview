using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai17_Listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(lvSanPham.SelectedItems.Count>0)
            //{
            //    ListViewItem lv1= lvSanPham.SelectedItems[0] ;
            //    string ma= lv1.SubItems[0].Text ;
            //    string ten= lv1.SubItems[1].Text ;
            //    string gia= lv1.SubItems[2].Text ;
            //    MessageBox.Show(ma + "/" + ten + "/" + gia);
            //}
        }

        private void lvSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(e.Column!=-1)
            {
                MessageBox.Show(lvSanPham.Columns[e.Column].Text);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while(lvSanPham.SelectedItems.Count > 0)
            {
                lvSanPham.Items.Remove(lvSanPham.SelectedItems[0]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            while(lvSanPham.SelectedItems.Count > 0)
            {
                lvSanPham.Items.RemoveAt(lvSanPham.SelectedItems[0].Index);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem(txtMa.Text);
            lv1.SubItems.Add(txtTen.Text);
            lv1.SubItems.Add(txtGia.Text);
            lvSanPham.Items.Add(lv1);
        }
    }
}
