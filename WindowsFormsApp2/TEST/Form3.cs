using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public int k;
        public String diachi;
        public Form3(int k)
        {
            this.k = k;
            InitializeComponent();
        }

        private void danhsachnhanvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.danhsachnhanvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);
            //this.SavePicture();
            //
            this.thongtincongviecBindingSource.EndEdit();
            this.thongtincongviecTableAdapter.Update(this.dsnv_dbDataSet);
            //
            this.thongtinnhanvienBindingSource.EndEdit();
            this.thongtinnhanvienTableAdapter.Update(this.dsnv_dbDataSet);
            //
            this.hinhanhBindingSource.EndEdit();
            this.hinhanhTableAdapter.Update(this.dsnv_dbDataSet);
            //
            
            //hinhanhBindingSource.
            

        }

        private void SavePicture()
        {
            String maso = masoTextEdit.Text;
            this.diachi = "E:/Database/Hinhanh/" + maso+".png";
            bool checkin = IsFileLocked(new FileInfo(diachi));
            if (System.IO.File.Exists(diachi)==true & checkin==false)
            {
                System.IO.File.Delete(diachi);
                pictureEdit1.Image.Save(diachi);
               
            }
            else if (System.IO.File.Exists(diachi) == true & checkin == true)
            { }
            else
            {
                pictureEdit1.Image.Save(diachi);
            }
            //Check_box();
            
            pictureTextBox.Text = diachi;
            //this.hinhanhBindingSource.EndEdit();
            //this.hinhanhTableAdapter.Update(this.dsnv_dbDataSet);
            //int p = this.hinhanhBindingSource.List.Count;
            //MessageBox.Show(p.ToString());
        }
        private void Form3_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Thongtincongviec' table. You can move, or remove it, as needed.
            this.thongtincongviecTableAdapter.Fill(this.dsnv_dbDataSet.Thongtincongviec);
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Thongtinnhanvien' table. You can move, or remove it, as needed.
            this.thongtinnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Thongtinnhanvien);
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Danhsachnhanvien' table. You can move, or remove it, as needed.
            this.danhsachnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Danhsachnhanvien);
            //bindingNavigatorPositionItem.Text = "50";
            //bindingNavigatorPositionItem.Focus();
            //danhsachnhanvienBindingSource.Position = System.Convert.ToInt32(this.k);
            danhsachnhanvienBindingSource.Position = System.Convert.ToInt32(this.k);
            //this.danhsachnhanvienBindingNavigator.Update();
            //System.Data.DataRow
            //this.danhsachnhanvienBindingNavigator.Update();
            //System.Data.DataRow
            //String g = gridView2.GetRowCellValue(gridView2.GetSelectedRows()[0], "Maso").ToString();
            //this.k = danhsachnhanvienBindingSource.Find("Maso", g);
            //j = hinhanhBindingSource
            //List<> g = hinhanhBindingSource.List[this.k];

            //DataRowView items = (DataRowView)this.hinhanhBindingSource.List[this.k];
            //Console.WriteLine(hinhanhBindingSource.List);
            //String G = p["Picture"].ToString();
            //label1.Text = p.ToString();
            //hinhanhBindingSource.cha
            //int p = this.hinhanhBingSource.List.Count;
            //if (p == 0)
            //{
            //    BindingSource hinh = new BindingSource();
            //    hinh[0] = masoTextEdit.Text;
            //    hinhanhBindingSource.Add(hinh); 
            //}
            //ADDROW();

        }
        private void ADDROW()
        {   
            
            int p = this.hinhanhBindingSource.List.Count;
            if (dsnv_dbDataSet.Hinhanh.FindByMaso(masoTextEdit.Text) == null)
            {
                //hinhanhBindingSource.Add()
                //DataTable dt;
                //dt = new DataTable();
                //dt.Columns.Add(new DataColumn("Maso", typeof(string)));
                //dt.Columns.Add(new DataColumn("Picture", typeof(string)));
                //dt.Rows.Add("admin2", "E:/Database/Hinhanh/Admin.png");
                DataRow workRow = dsnv_dbDataSet.Hinhanh.NewRow();
                workRow[0] = masoTextEdit.Text;
                dsnv_dbDataSet.Hinhanh.Rows.Add(workRow);
                //this.hinhanhBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);


                //hinhanhBindingSource.Add(dt);
                //hinhanhBindingSource.Add();
                //DataRowView test = (DataRowView)hinhanhBindingSource.List;
                //test[0] = "test";
                //hinhanhBindingSource.Add(test);
                ////DataRow A;
                //A.ItemArray[]
                //this.dsnv_dbDataSet.Danhsachnhanvien.AddDanhsachnhanvienRow()
                //INSERT INTO Thongtinnhanvien(column_name_1, column_name_2, column_name_3, ... column_name_n) VALUES(value_1, value_2, value_3, ...value_n)
                //hinhanhBindingSource.Add("Maso", this, "Title", true, DataSourceUpdateMode.OnPropertyChanged);
                //BindingSource hinh = new BindingSource();
                //hinh.Add(masoTextEdit.Text);
                //test.Row
                //hinhanhBindingSource.Add("maso","test");
                //hinhanhBindingSource[0] = "masoTextEdit.Text";
                //hinhanhBindingSource.Add.
            }
            //p = this.thongtincongviecBindingSource.List.Count;
            //dsnv_dbDataSet.Hinhanh.Select("Maso", "admin1");
            //dsnv_dbDataSet.Hinhanh.Rows.Find("admin1");
            if (dsnv_dbDataSet.Thongtincongviec.FindByMaso(masoTextEdit.Text) == null) 
            {
                DataRow workRow = dsnv_dbDataSet.Thongtincongviec.NewRow();
                workRow[0] = masoTextEdit.Text;
                dsnv_dbDataSet.Thongtincongviec.Rows.Add(workRow);
                //this.thongtincongviecBindingSource.EndEdit();
                //this.thongtincongviecTableAdapter.Update(this.dsnv_dbDataSet);
                //    BindingSource hinh = new BindingSource();
                //    hinh[0] = masoTextEdit.Text;
                //    thongtincongviecBindingSource.Add(hinh);
            }
            if (dsnv_dbDataSet.Thongtinnhanvien.FindByMaso(masoTextEdit.Text) == null)
            {   
                DataRow workRow = dsnv_dbDataSet.Thongtinnhanvien.NewRow();
                workRow[0] = masoTextEdit.Text;
                dsnv_dbDataSet.Thongtinnhanvien.Rows.Add(workRow);
                //this.thongtinnhanvienBindingSource.EndEdit();
                //this.thongtinnhanvienTableAdapter.Update(this.dsnv_dbDataSet);
                //BindingSource hinh = new BindingSource();
                //hinh[0] = masoTextEdit.Text;
                //thongtinnhanvienBindingSource.Add(hinh);
            }






        }
        private void gioitinhLabel_Click(object sender, EventArgs e)
        {

        }

        private void gioitinhTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ghichuLabel_Click(object sender, EventArgs e)
        {

        }

        private void ngaysinhDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sTTSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void picturePictureEdit_EditValueChanged(object sender, EventArgs e)
        {
            //hinhanhBindingSource.Insert(1, picturePictureEdit.Tag);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }
        private void pictureTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        //private void Checktontaib)
        //{

        //}
        private void noisinhTextEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureTextBox_TextChanged_1(object sender, EventArgs e)
        {
            Check_box();
        }
        private void Check_box()
        {
            if (pictureTextBox.Text == "")
            {
                pictureEdit1.Image = Image.FromFile("E:/Database/Hinhanh/Admin.png");

            }
            else
            {
                MessageBox.Show(pictureTextBox.Text);
                pictureEdit1.Image = Image.FromFile(pictureTextBox.Text);

            }
        }

        private void masoTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            //ADDROW();
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }
    }  
}
