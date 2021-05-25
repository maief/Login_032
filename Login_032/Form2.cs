using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_032
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HANIF\SQLEXPRESS;Initial Catalog=MyPractice;Integrated Security=True;");

        public Form2()
        {
            InitializeComponent();
        }
        BelajarDataContext db = new BelajarDataContext();


        void LoadData()
        {
            var st = from tb in db.TB_M_PRODUCTs select tb;
            dataGridView1.DataSource = st; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (ID as int)),0) + 1 from TB_M_PRODUCT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TxtBoxID.Text = dt.Rows[0][0].ToString();
            LoadData();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtBoxID.Text);
            string item = TxtBoxItemName.Text;
            string design = TxtBoxDesign.Text;
            string color = CBoxColor.Text;
            DateTime expiredDate = DateTime.Parse(DTPTanggal.Text);

            var data = new TB_M_PRODUCT
            {
                ID = id,
                itemName = item,
                color = color,
                design = design,
                expiredDate = expiredDate
            };

            db.TB_M_PRODUCTs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Save Succesfully");
            TxtBoxDesign.Clear();
            TxtBoxItemName.Clear();
            CBoxColor.Items.Clear();
            LoadData();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            var st = from s in db.TB_M_PRODUCTs where s.itemName == TxtBoxItemNameCari.Text || s.design == TxtBoxDesignCari.Text select s;
            dataGridView1.DataSource = st;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string item = TxtBoxItemName.Text;
            string design = TxtBoxDesign.Text;
            string color = CBoxColor.Text;
            DateTime expiredDate = DateTime.Parse(DTPTanggal.Text);

            var st = (from s in db.TB_M_PRODUCTs where s.ID == int.Parse(TxtBoxID.Text) select s).First();

            st.itemName = item;
            st.color = color;
            st.design = design;
            st.expiredDate = expiredDate;
            db.SubmitChanges();

            

            MessageBox.Show("Update Succesfuly");
            TxtBoxDesign.Clear();
            TxtBoxItemName.Clear();
            CBoxColor.SelectedIndex = -1;
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            var delete = from s in db.TB_M_PRODUCTs where s.itemName == TxtBoxItemNameCari.Text select s;
            foreach (var t in delete)
            {
                db.TB_M_PRODUCTs.DeleteOnSubmit(t);
            }
            db.SubmitChanges();
            MessageBox.Show("Delete Succesfully");
            TxtBoxDesignCari.Clear();
            TxtBoxItemNameCari.Clear();
            LoadData();
        }
    }
}
