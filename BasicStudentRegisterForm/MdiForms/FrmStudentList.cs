using SMBusiness.Concrete;
using SMDataAccess.Abstract;
using SMDataAccess.EntityFrame;
using SMEntity.Concrete.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicStudentRegisterForm.MdiForms
{
    public partial class FrmStudentList : Form
    {
        #region const

        StudentManager student = new StudentManager(new EfStudentDAL());
        #endregion
        public FrmStudentList()
        {
            InitializeComponent();
        }

        

        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            grdStudentControl.DataSource = student.GetAllBL();
        }
    }
}
