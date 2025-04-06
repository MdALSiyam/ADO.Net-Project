using ArtGalleryManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGalleryManagementSystem
{
    public partial class ReportViewer_Form : Form
    {
        private List<ArtViewModelcs> localList;

        public ReportViewer_Form(List<ArtViewModelcs> list)
        {
            InitializeComponent();
            localList = list;
        }

        public ReportViewer_Form()
        {
            InitializeComponent();
        }

        private void ReportViewer_Form_Load(object sender, EventArgs e)
        {
            ArtInfo_Report rpt = new ArtInfo_Report();
            rpt.SetDataSource(localList);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
