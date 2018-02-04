using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yuuto_VPA_Virtual_Private_Assistant_
{
    public partial class Getdataformail : MetroFramework.Forms.MetroForm
    {

        Getdataformail m;
        public Getdataformail()
        {
            InitializeComponent();
            Load += Getdataformail_Load;
        }

        private void Getdataformail_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void submitdata_Click(object sender, EventArgs e)
        {
            Main_Class.refresh_main_engine();
            this.Close();
        }

        private void resetall_Click(object sender, EventArgs e)
        {
            
        }
    }
}
