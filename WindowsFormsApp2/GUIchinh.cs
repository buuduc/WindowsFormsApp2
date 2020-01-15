using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class GUIchinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int k;
        public GUIchinh()
        {
            InitializeComponent();
        }

        private void danhsachnhanvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.danhsachnhanvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);

        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.thongtincongviecBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.thongtinnhanvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Thongtinnhanvien' table. You can move, or remove it, as needed.
            this.thongtinnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Thongtinnhanvien);
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Thongtincongviec' table. You can move, or remove it, as needed.
            this.thongtincongviecTableAdapter.Fill(this.dsnv_dbDataSet.Thongtincongviec);
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Danhsachnhanvien' table. You can move, or remove it, as needed.
            this.danhsachnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Danhsachnhanvien);

        }

        private void toolStripButton14_Click_1(object sender, EventArgs e)
        {

            this.Validate();
            this.thongtinnhanvienBindingSource.EndEdit();
            this.thongtinnhanvienTableAdapter.Update(this.dsnv_dbDataSet.Thongtinnhanvien);
        }



        private void miniToolStrip_RefreshItems(object sender, EventArgs e)
        {
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int s = tabControl1.SelectedIndex;

            //int[] k = gridView1.GetSelectedRows();
            switch (s)

            {
                case 0:
                    {
                        //this.k = gridView1.GetSelectedRows();
                        this.k = danhsachnhanvienBindingSource.Position;
                        //MessageBox.Show(this.k.ToString());
                        break;
                    }
                case 1:
                    {
                        //String j = bindingNavigator1.PositionItem.Text;
                        //int[] k = System.Convert.ToInt32(j);
                        //k = thongtinnhanvienBindingSource.Position
                        String g = gridView2.GetRowCellValue(gridView2.GetSelectedRows()[0], "Maso").ToString();
                        this.k = danhsachnhanvienBindingSource.Find("Maso", g);
                        //MessageBox.Show(k.ToString());
                        break;
                    }
                case 2:
                    {
                        //this.k = thongtincongviecBindingSource.Position;
                        //MessageBox.Show(this.k.ToString());
                        String g = gridView3.GetRowCellValue(gridView2.GetSelectedRows()[0], "Maso").ToString();
                        this.k = danhsachnhanvienBindingSource.Find("Maso", g);
                        break;
                    }

            }



            //Thongtinchitiet b = new Thongtinchitiet(this.k);
            //b.truyenData = new Thongtinchitiet.Truyenchocha(UpdateData);

            Thongtinchitiet b;
            b = new Thongtinchitiet(this.k);
            b.truyenData = new Thongtinchitiet.Truyenchocha(UpdateData);
            b.ShowDialog();
            b.Close();
            //Form3 a = new Form3(this.k);



        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void danhsachnhanvienGridControl_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int s = tabControl1.SelectedIndex;
            switch (s)

            {
                case 0:
                    {
                        //this.k = gridView1.GetSelectedRows();
                        this.k = danhsachnhanvienBindingSource.Position;
                        //MessageBox.Show(this.k.ToString());
                        break;
                    }
                case 1:
                    {
                        //String j = bindingNavigator1.PositionItem.Text;
                        //int[] k = System.Convert.ToInt32(j);
                        //k = thongtinnhanvienBindingSource.Position
                        String g = gridView2.GetRowCellValue(gridView2.GetSelectedRows()[0], "Maso").ToString();
                        this.k = danhsachnhanvienBindingSource.Find("Maso", g);
                        //MessageBox.Show(k.ToString());
                        break;
                    }
                case 2:
                    {
                        //this.k = thongtincongviecBindingSource.Position;
                        //MessageBox.Show(this.k.ToString());
                        String g = gridView3.GetRowCellValue(gridView2.GetSelectedRows()[0], "Maso").ToString();
                        this.k = danhsachnhanvienBindingSource.Find("Maso", g);
                        break;
                    }

            }
            Thongtinchitiet_dele a = new Thongtinchitiet_dele(this.k);
            a.truyenData = new Thongtinchitiet_dele.Truyenchocha(UpdateData);
            //Form3 a = new Form3(this.k);
            a.ShowDialog();
            a.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateData();

        }
        public void UpdateData()
        {
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Thongtinnhanvien' table. You can move, or remove it, as needed.
            this.thongtinnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Thongtinnhanvien);
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Thongtincongviec' table. You can move, or remove it, as needed.
            this.thongtincongviecTableAdapter.Fill(this.dsnv_dbDataSet.Thongtincongviec);
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Danhsachnhanvien' table. You can move, or remove it, as needed.
            this.danhsachnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Danhsachnhanvien);
            danhsachnhanvienBindingSource.Position = this.k;
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            int s = tabControl1.SelectedIndex;
            switch (s)

            {
                case 0:
                    {
                        //this.k = gridView1.GetSelectedRows();
                        this.k = danhsachnhanvienBindingSource.Position;
                        //MessageBox.Show(this.k.ToString());
                        break;
                    }
                case 1:
                    {
                        //String j = bindingNavigator1.PositionItem.Text;
                        //int[] k = System.Convert.ToInt32(j);
                        //k = thongtinnhanvienBindingSource.Position
                        String g = gridView2.GetRowCellValue(gridView2.GetSelectedRows()[0], "Maso").ToString();
                        this.k = danhsachnhanvienBindingSource.Find("Maso", g);
                        //MessageBox.Show(k.ToString());
                        break;
                    }
                case 2:
                    {
                        //this.k = thongtincongviecBindingSource.Position;
                        //MessageBox.Show(this.k.ToString());
                        String g = gridView3.GetRowCellValue(gridView2.GetSelectedRows()[0], "Maso").ToString();
                        this.k = danhsachnhanvienBindingSource.Find("Maso", g);
                        break;
                    }

            }
            Thongtinchitiet_add a = new Thongtinchitiet_add(this.k);
            a.truyenData = new Thongtinchitiet_add.Truyenchocha(UpdateData);
            CausesValidation = false;
            //Form3 a = new Form3(this.k);
            a.ShowDialog();
            a.Close();
        }

        private void ThemBang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemBang TB = new ThemBang();
            TB.ShowDialog();
            if (TB.CheckDialog)
            {
                TabPage tabmoi = new TabPage(TB.Ten_Bang);
                tabmoi.Controls.Add(new BangTuyChinh());
                tabControl1.TabPages.Add(tabmoi);
                tabControl1.SelectedTab = tabmoi;
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DoiTenBang TB = new DoiTenBang();
            TabPage Hienhanh = tabControl1.SelectedTab;
            TB.TenThayDoi = Hienhanh.Text;
            TB.ShowDialog();
            if (TB.check)
            {
                
                Hienhanh.Text = TB.TenThayDoi;
            }
        }
    }
}
