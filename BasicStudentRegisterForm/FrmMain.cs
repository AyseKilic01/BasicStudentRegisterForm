﻿using BasicStudentRegisterForm.MdiForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicStudentRegisterForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        FrmStudentList student;
        private void btnStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(student == null)
            {
                student = new FrmStudentList();
                student.MdiParent = this;
                student.Show();
            }
        }
    }
}
