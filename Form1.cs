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


      
            
            Updatepanel2.Location = new Point(
              this.ClientSize.Width / 2 - Updatepanel2.Size.Width / 2, this.ClientSize.Height / 2 - Updatepanel2.Size.Height / 2);
            this.Updatepanel2.Anchor = AnchorStyles.None;

            Tag1panel.Location = new Point(
            this.ClientSize.Width / 2 - Tag1panel.Size.Width / 2, this.ClientSize.Height / 2 - Tag1panel.Size.Height / 2);
            this.Tag1panel.Anchor = AnchorStyles.None;


            paneManageLec.Location = new Point(
          this.ClientSize.Width / 2 - paneManageLec.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.paneManageLec.Anchor = AnchorStyles.None;

            SubjectPanalAddSubject.Location = new Point(
          this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.SubjectPanalAddSubject.Anchor = AnchorStyles.None;

            SubjectManageSubpanal.Location = new Point(
          this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.SubjectManageSubpanal.Anchor = AnchorStyles.None;

            manageworkpanel.Location = new Point(
          this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.manageworkpanel.Anchor = AnchorStyles.None;

            addworkpanel.Location = new Point(
          this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.addworkpanel.Anchor = AnchorStyles.None;

            SessionRoomPanel3.Location = new Point(
          this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.SessionRoomPanel3.Anchor = AnchorStyles.None;

            panelManageSessionsRooms.Location = new Point(
          this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.panelManageSessionsRooms.Anchor = AnchorStyles.None;

            AddLocationPanel1.Location = new Point(
          this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.AddLocationPanel1.Anchor = AnchorStyles.None;

            DisplayLocationPanel.Location = new Point(
          this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.DisplayLocationPanel.Anchor = AnchorStyles.None;

            addSssionpanel.Location = new Point(
    this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.addSssionpanel.Anchor = AnchorStyles.None;

            panelManageSession.Location = new Point(
   this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.panelManageSession.Anchor = AnchorStyles.None;

            Lecpanel2.Location = new Point(
 this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.Lecpanel2.Anchor = AnchorStyles.None;

        


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            panel1.Hide();
            Updatepanel2.Hide();
            Tag1panel.Hide();
            tagpanel2.Hide();
            Lecpanel2.Hide();
            paneManageLec.Hide();
            SubjectPanalAddSubject.Hide();
            SubjectManageSubpanal.Hide();
            manageworkpanel.Hide();
            addworkpanel.Hide();
            SessionRoomPanel3.Hide();
            panelManageSessionsRooms.Hide();
            AddLocationPanel1.Hide();
            DisplayLocationPanel.Hide();
            addSssionpanel.Hide();
            panelManageSession.Hide();

            panel1.Location = new Point(
     this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            this.panel1.Anchor = AnchorStyles.None;

            tagpanel2.Location = new Point(
        this.ClientSize.Width / 2 - tagpanel2.Size.Width / 2, this.ClientSize.Height / 2 - tagpanel2.Size.Height / 2);
            this.tagpanel2.Anchor = AnchorStyles.None;






            fillchart();

        }

        private void fillchart()
        {
            chart1.Series["salary"].Points.AddXY("ajay", "1000");
            chart1.Series["salary"].Points.AddXY("ajay", "2000");
            chart1.Titles.Add("salrychart");
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
            AddStudent std = new AddStudent();
            std.Show();
            std.BringToFront();
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

        private void materialComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton21_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel19_Click(object sender, EventArgs e)
        {

        }

        private void Updatepanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Updatepanel2.Hide();
        }

        private void pictureBox10_Click_2(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void materialTabSelector4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            Tag1panel.Hide();
        }

        private void pictureBox11_Click_2(object sender, EventArgs e)
        {
            tagpanel2.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {

        }

		private void tabPage18_Click(object sender, EventArgs e)
		{

		}

		private void MWmaterialCheckbox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void materialCheckbox5_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void manageaddworkbut_Click(object sender, EventArgs e)
		{

		}

        private void materialLabel47_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel45_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click_1(object sender, EventArgs e)
        {

        }

        private void materialTextBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTabSelector7_Click(object sender, EventArgs e)
        {

        }

        private void ManageLec_Click(object sender, EventArgs e)
        {
            paneManageLec.Show();
        }

        private void AddLecs_Click(object sender, EventArgs e)
        {
            Lecpanel2.Show();
        }

        private void LecpictureBox_Click(object sender, EventArgs e)
        {
            Lecpanel2.Hide();
        }

        private void managelecpic_Click(object sender, EventArgs e)
        {
            paneManageLec.Hide();
        }

        private void AddSubbtn_Click(object sender, EventArgs e)
        {
            SubjectPanalAddSubject.Show();
        }

        private void Managesubbtn_Click(object sender, EventArgs e)
        {

            SubjectManageSubpanal.Show();
        }

        private void pictureBoxManagesub_Click(object sender, EventArgs e)
        {
            SubjectManageSubpanal.Hide();
        }

        private void pictureBoxSujectadd_Click(object sender, EventArgs e)
        {
            SubjectPanalAddSubject.Hide();
        }

        private void manageworkTabSelector_Click(object sender, EventArgs e)
        {

        }

        private void homeaddworkbut_Click(object sender, EventArgs e)
        {
            addworkpanel.Show();
        }

        private void manageaddworkbut_Click_1(object sender, EventArgs e)
        {
            manageworkpanel.Show();
        }

        private void manageworkpicBox_Click(object sender, EventArgs e)
        {
            manageworkpanel.Hide();
           
        }

        private void addworkpicBox_Click(object sender, EventArgs e)
        {
            addworkpanel.Hide();
        }

        private void addroombtn_Click(object sender, EventArgs e)
        {
            SessionRoomPanel3.Show();
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void manageSessionBtn_Click(object sender, EventArgs e)
        {
            panelManageSessionsRooms.Show();
        }

        private void pictureBoxRooms_Click(object sender, EventArgs e)
        {
            SessionRoomPanel3.Hide();
            
        }

        private void pictureBoxMSRooms_Click(object sender, EventArgs e)
        {
            panelManageSessionsRooms.Hide();
        }

        private void pictureBoxSujectadd_Click_1(object sender, EventArgs e)
        {
            SubjectPanalAddSubject.Hide();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

		private void numericUpDown7_ValueChanged(object sender, EventArgs e)
		{

		}

		private void UNSmaterialLabel49_Click(object sender, EventArgs e)
		{

		}

		private void UNSrefreshbut_Click(object sender, EventArgs e)
		{

		}

        private void pictureBoxDisplayLoc_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxDisplayLoc_Click_1(object sender, EventArgs e)
        {
            DisplayLocationPanel.Hide();
        }

        private void LocationIcon2Btn_Click(object sender, EventArgs e)
        {
            DisplayLocationPanel.Show();
        }

        private void LocationIcon1Btn_Click(object sender, EventArgs e)
        {
            AddLocationPanel1.Show();
        }

        private void pictureBoxAddLoc_Click(object sender, EventArgs e)
        {
            AddLocationPanel1.Hide();
        }

        private void Clearlec_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel82_Click(object sender, EventArgs e)
        {
            //addSssionpanel.Hide();
        }

        private void materialLabel83_Click(object sender, EventArgs e)
        {

        }

        private void AddSessionbtn_Click(object sender, EventArgs e)
        {
            //addSssionpanel.Show();
        }

        private void managesebtn_Click(object sender, EventArgs e)
        {
            panelManageSession.Show();
        }

        private void pictureBoxAddSession_Click(object sender, EventArgs e)
        {
            addSssionpanel.Hide();
        }

        private void pictureBoxManageSession_Click(object sender, EventArgs e)
        {
            panelManageSession.Hide();
        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {
            //commit
        }

        private void tabPage18_Click_1(object sender, EventArgs e)
        {
            //preparedStmt.setString(1, name);
            //email
            //preparedStmt.setString(2, email);
            //nic
            //preparedStmt.setString(2, nic);
            //preparedStmt.setString(2, phnnumber);
            //preparedStmt.setString(4, address);
            //preparedStmt.setInt(5, Integer.parseInt(ID));
            // execute the statement
        }
    }
}
