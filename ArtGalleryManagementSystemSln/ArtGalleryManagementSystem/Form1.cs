using ArtGalleryManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGalleryManagementSystem
{
    public partial class ArtGalleryForm : Form
    {
        int intArtId = 0;
        bool isDefaultImage = true;
        string conStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string strPreviousImage = "";
        OpenFileDialog ofd = new OpenFileDialog();

        public ArtGalleryForm()
        {
            InitializeComponent();
        }

        private void ArtGalleryForm_Load(object sender, EventArgs e)
        {
            LoadGenre();
            LoadArtListGrid();
            ClearAll();
        }

        private void LoadGenre()
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ArtGenre", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow topRow = dt.NewRow();
                topRow[0] = 0;
                topRow[1] = "------- Select -------";
                dt.Rows.InsertAt(topRow, 0);
                cmbGenre.DataSource = dt;
                cmbGenre.ValueMember = "GenreId";
                cmbGenre.DisplayMember = "GenreTitle";
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Images(.jpg,.png)| *.png;*.jpg;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImgArt.Image = new Bitmap(ofd.FileName);
                isDefaultImage = false;
                strPreviousImage = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ImgArt.Image = Image.FromFile(Application.StartupPath + "\\images\\noimage.png");
            isDefaultImage = true;
            strPreviousImage = "";
        }

        string SaveImage(string fileName)
        {
            string imageName = Path.GetFileNameWithoutExtension(fileName);
            string extension = Path.GetExtension(fileName);
            imageName = imageName.Length <= 15 ? imageName : imageName.Substring(0, 15);
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + extension;
            ImgArt.Image.Save(Application.StartupPath + "\\images\\" + imageName);
            return imageName;
        }

        private void ClearAll()
        {
            txtArtCode.Text = txtArtTitle.Text = txtArtistFName.Text = txtArtistLName.Text = txtPrice.Text = "";
            cmbGenre.SelectedIndex = 0;
            dtpCreationDate.Value = DateTime.Now;
            if (dgvDetails.DataSource == null)
            {
                dgvDetails.Rows.Clear();
            }
            else
            {
                dgvDetails.DataSource = (dgvDetails.DataSource as DataTable).Clone();
            }
            intArtId = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            ImgArt.Image = Image.FromFile(Application.StartupPath + "\\images\\noimage.png");
            isDefaultImage = true;
            ckbStaus.Checked = false;
            rbtnMale.Checked = true;
        }

        bool ValidateForm()
        {
            bool isValid = true;
            if (txtArtCode.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Art Code is Required !");
            }
            if (txtArtTitle.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Art Title is Required !");
            }
            if (cmbGenre.SelectedIndex == 0)
            {
                isValid = false;
                MessageBox.Show("Select Art Genre !");
            }
            if (txtArtistFName.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Artist First Name is Required !");
            }
            if (txtArtistLName.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Artist Last Name is Required !");
            }
            if (txtPrice.Text.Trim() == "")
            {
                isValid = false;
                MessageBox.Show("Art Price is Required !");
            }
            return isValid;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                int artId = 0;
                using (SqlConnection sqlCon = new SqlConnection(conStr))
                {
                    sqlCon.Open();
                    using (SqlTransaction tran = sqlCon.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand sqlCmd = new SqlCommand("ArtMasterAddOrEdit", sqlCon, tran);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@ArtId", intArtId);
                            sqlCmd.Parameters.AddWithValue("@ArtCode", txtArtCode.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@ArtTitle", txtArtTitle.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Price", txtPrice.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@ArtistFName", txtArtistFName.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@ArtistLName", txtArtistLName.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@IsAvailable", ckbStaus.Checked ? "true" : "false");
                            sqlCmd.Parameters.AddWithValue("@GenreId", Convert.ToInt32(cmbGenre.SelectedValue));
                            sqlCmd.Parameters.AddWithValue("@CreationDate", dtpCreationDate.Value);
                            sqlCmd.Parameters.AddWithValue("@Gender", rbtnMale.Checked ? "Male" : "Female");
                            if (isDefaultImage)
                            {
                                sqlCmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                            }
                            else if (intArtId > 0 && strPreviousImage != "")
                            {
                                sqlCmd.Parameters.AddWithValue("@ImagePath", strPreviousImage);
                            }
                            else
                            {
                                sqlCmd.Parameters.AddWithValue("@ImagePath", SaveImage(ofd.FileName));
                            }
                            artId = Convert.ToInt32(sqlCmd.ExecuteScalar());
                            tran.Commit();
                        }
                        catch { tran.Rollback(); }
                    }
                }
                using (SqlConnection sqlCon = new SqlConnection(conStr))
                {
                    sqlCon.Open();
                    using (SqlTransaction tran = sqlCon.BeginTransaction())
                    {
                        try
                        {
                            foreach (DataGridViewRow dgvRow in dgvDetails.Rows)
                            {
                                if (dgvRow.IsNewRow) break;
                                else
                                {
                                    SqlCommand sqlCmd = new SqlCommand("ArtDetailsAddOrEdit", sqlCon, tran);
                                    sqlCmd.CommandType = CommandType.StoredProcedure;
                                    sqlCmd.Parameters.AddWithValue("@DetailsId", Convert.ToInt32(dgvRow.Cells["DetailsId"].Value == DBNull.Value ? "0" : dgvRow.Cells["DetailsId"].Value));
                                    sqlCmd.Parameters.AddWithValue("@ArtId", artId);
                                    sqlCmd.Parameters.AddWithValue("@ExhibitionTitle", dgvRow.Cells["ExhibitionTitle"].Value == DBNull.Value ? "" : dgvRow.Cells["ExhibitionTitle"].Value);
                                    sqlCmd.Parameters.AddWithValue("@ExhibitionDuration", Convert.ToInt32(dgvRow.Cells["ExhibitionDuration"].Value == DBNull.Value ? "0" : dgvRow.Cells["ExhibitionDuration"].Value));
                                    sqlCmd.ExecuteNonQuery();
                                    tran.Commit();
                                }
                            }
                        }
                        catch { tran.Rollback(); }
                    }
                }
                LoadArtListGrid();
                ClearAll();
                MessageBox.Show("Submitted Successfully");
            }
        }

        private void LoadArtListGrid()
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("ViewAllArt", sqlCon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
                foreach (DataRow dr in dt.Rows)
                {
                    try
                    {
                        dr["Image"] = File.ReadAllBytes(Application.StartupPath + "\\images\\" + dr["ImagePath"].ToString());
                    }
                    catch (Exception)
                    {
                        dr["Image"] = File.ReadAllBytes(Application.StartupPath + "\\images\\noimage.png");
                    }

                }
                dgvArtList.RowTemplate.Height = 60;
                dgvArtList.DataSource = dt;
                ((DataGridViewImageColumn)dgvArtList.Columns[dgvArtList.ColumnCount - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                da.Dispose();
            }
        }

        private void dgvArtList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvArtList.CurrentRow.Index != -1)
            {
                DataGridViewRow dgvRow = dgvArtList.CurrentRow;
                intArtId = Convert.ToInt32(dgvRow.Cells[0].Value);
                using (SqlConnection sqlCon = new SqlConnection(conStr))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ViewArtById", sqlCon);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ArtId", intArtId);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataRow dr = ds.Tables[0].Rows[0];
                    txtArtCode.Text = dr["ArtCode"].ToString();
                    txtArtTitle.Text = dr["ArtTitle"].ToString();
                    txtArtistFName.Text = dr["ArtistFName"].ToString();
                    txtArtistLName.Text = dr["ArtistLName"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                    cmbGenre.SelectedValue = dr["GenreId"].ToString();
                    dtpCreationDate.Value = Convert.ToDateTime(dr["CreationDate"].ToString());

                    if (dr["Gender"].ToString() == "Male")
                        rbtnMale.Checked = true;
                    else rbtnMale.Checked = false;

                    if (dr["Gender"].ToString() == "Female")
                        rbtnFemale.Checked = true;
                    else rbtnFemale.Checked = false;

                    if (dr["IsAvailable"].ToString() == "true")
                        ckbStaus.Checked = true;
                    else ckbStaus.Checked = false;
                    try
                    {
                        ImgArt.Image = new Bitmap(Application.StartupPath + "\\images\\" + dr["ImagePath"].ToString());
                        strPreviousImage = dr["ImagePath"].ToString();
                        isDefaultImage = false;
                    }
                    catch (Exception)
                    {
                        ImgArt.Image = new Bitmap(Application.StartupPath + "\\images\\noimage.png");
                        isDefaultImage = true;
                    }
                    dgvDetails.AutoGenerateColumns = false;
                    dgvDetails.DataSource = ds.Tables[1];
                    btnDelete.Enabled = true;
                    btnSave.Text = "Update";
                    tbcArtGallery.SelectedIndex = 0;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete the record ?", "ArtMaster", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string image = "";
                using (SqlConnection sqlCon = new SqlConnection(conStr))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("ViewArtById", sqlCon);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@ArtId", intArtId);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataRow dr = ds.Tables[0].Rows[0];
                    using (SqlTransaction tran = sqlCon.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("ArtMasterDelete", sqlCon, tran);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ArtId", intArtId);
                            da.Dispose();
                            cmd.ExecuteNonQuery();
                            tran.Commit();
                        }
                        catch (Exception)
                        {
                            tran.Rollback();
                        }
                    }
                    LoadArtListGrid();
                    ClearAll();
                    MessageBox.Show("Art Deleted Successfully");
                }
            }
        }

        private void dgvDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvRow = dgvDetails.CurrentRow;
            if (dgvRow.Cells["DetailsId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to delete record ?", "ArtDetails", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(conStr))
                    {
                        sqlCon.Open();
                        SqlCommand cmd = new SqlCommand("ArtDetailsDelete", sqlCon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DetailsId", Convert.ToInt32(dgvRow.Cells["DetailsId"].Value));
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlCommand cmd = sqlCon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT M.ArtId, M.ArtCode, M.ArtTitle, G.GenreId, G.GenreTitle, M.ArtistFName, M.ArtistLName, M.Gender, M.CreationDate, M.Price, M.IsAvailable, M.ImagePath, (SELECT SUM(ExhibitionDuration) FROM ArtDetails AS D WHERE D.ArtId=M.ArtId ) AS TotalDuration FROM ArtMaster M JOIN ArtGenre G ON M.GenreId=G.GenreId";
                sqlCon.Open();
                DataTable dt = new DataTable();
                var rdr = cmd.ExecuteReader();
                dt.Load(rdr, LoadOption.Upsert);
                List<ArtViewModelcs> list = new List<ArtViewModelcs>();
                ArtViewModelcs obj;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    obj = new ArtViewModelcs();
                    obj.ArtId = Convert.ToInt32(dt.Rows[i]["ArtId"].ToString());
                    obj.ArtCode = dt.Rows[i]["ArtCode"].ToString();
                    obj.ArtTitle = dt.Rows[i]["ArtTitle"].ToString();
                    obj.GenreId = Convert.ToInt32(dt.Rows[i]["GenreId"].ToString());
                    obj.GenreTitle = dt.Rows[i]["GenreTitle"].ToString();
                    obj.ArtistFName = dt.Rows[i]["ArtistFName"].ToString();
                    obj.ArtistLName = dt.Rows[i]["ArtistLName"].ToString();
                    obj.Gender = dt.Rows[i]["Gender"].ToString();
                    obj.CreationDate = Convert.ToDateTime(dt.Rows[i]["CreationDate"].ToString());
                    obj.Price = Convert.ToInt32(dt.Rows[i]["Price"].ToString());
                    obj.IsAvailable = Convert.ToBoolean(dt.Rows[i]["IsAvailable"].ToString());   
                    obj.ImagePath = Application.StartupPath + "\\images\\" + dt.Rows[i]["ImagePath"].ToString();
                    list.Add(obj);
                    obj.ExhibitionDuration = Convert.ToInt32(dt.Rows[i]["TotalDuration"].ToString());
                }
                using (ReportViewer_Form frm = new ReportViewer_Form(list))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}
