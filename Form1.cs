using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_managemnt
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialskinmanager;
        public Form1()
        {
            InitializeComponent();
            materialskinmanager = MaterialSkin.MaterialSkinManager.Instance;
            materialskinmanager.EnforceBackcolorOnAllComponents = true;
            materialskinmanager.AddFormToManage(this);
            materialskinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialskinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            Updatepanel2.Hide();
            Tag1panel.Hide();
            tagpanel2.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            //AddStudent std = new AddStudent();
            //std.Show();
            //this.Visible = false;

            panel1.Show();
            panel1.BringToFront();
            

          


        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            tagpanel2.Show();
            tagpanel2.BringToFront();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void studentUserControl11_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton7_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            //updateStudents update = new updateStudents();
            //update.Show();
            //this.Visible = false;

            Updatepanel2.Show();
            Updatepanel2.BringToFront();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            DeleteStudents dlt = new DeleteStudents();
            dlt.Show();
            this.Visible = false;

          
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Add_Tag tag = new Add_Tag();
            tag.Show();
            this.Visible = false;
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Updatepanel2.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void materialButton4_Click_1(object sender, EventArgs e)
        {
            Tag1panel.Show();
            Tag1panel.BringToFront();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Tag1panel.Hide();
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            tagpanel2.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tagpanel2_Paint(object sender, PaintEventArgs e)
        {

        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void addworkingpanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void addworkingButton_Click(object sender, EventArgs e)
		{
            addworkingpanel.Show();
            addworkingpanel.BringToFront();
		}

		private void addworkingpictureBox_Click(object sender, EventArgs e)
		{
            addworkingpanel.Hide();
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void manageworkingButton_Click(object sender, EventArgs e)
		{
            manageworkingpanel.Show();
            manageworkingpanel.BringToFront();
		}

		private void manageworkingpictureBox_Click(object sender, EventArgs e)
		{
            manageworkingpanel.Hide();
		}

		private void materialLabel36_Click(object sender, EventArgs e)
		{

		}

		private void materialLabel34_Click(object sender, EventArgs e)
		{

		}

		private void materialButton19_Click(object sender, EventArgs e)
		{

		}

		private void materialLabel42_Click(object sender, EventArgs e)
		{

		}

		private void materialTextBox13_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void materialComboBox12_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void materialLabel45_Click(object sender, EventArgs e)
		{

		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            updatelocationpanel.Hide();
            notavailsessiontabPage.Show();
        }

		private void timetabPage_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox14_Click(object sender, EventArgs e)
		{
           
		}

		private void allocationpanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void materialLabel48_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void homepictureBoxnotavail_Click(object sender, EventArgs e)
		{
            
        }

		private void materialLabel45_Click_1(object sender, EventArgs e)
		{

		}

		private void notavailsessiontabPage_Click(object sender, EventArgs e)
		{

		}

		private void tabPage10_Click(object sender, EventArgs e)
		{

		}
	}
}
