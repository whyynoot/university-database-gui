
namespace Doctors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupsGrid = new System.Windows.Forms.DataGridView();
            this.curatorsGrid = new System.Windows.Forms.DataGridView();
            this.studentsGrid = new System.Windows.Forms.DataGridView();
            this.loadDoctors = new System.Windows.Forms.Button();
            this.Groups = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loadCur = new System.Windows.Forms.Button();
            this.LoadStudents = new System.Windows.Forms.Button();
            this.groupid = new System.Windows.Forms.TextBox();
            this.groupname = new System.Windows.Forms.TextBox();
            this.CurId = new System.Windows.Forms.TextBox();
            this.CurName = new System.Windows.Forms.TextBox();
            this.student = new System.Windows.Forms.TextBox();
            this.studname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createGroupBtn = new System.Windows.Forms.Button();
            this.changeDoctor = new System.Windows.Forms.Button();
            this.deleteDoctor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.createSpes = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.createCer = new System.Windows.Forms.Button();
            this.changeCer = new System.Windows.Forms.Button();
            this.deleteCer = new System.Windows.Forms.Button();
            this.changeSpec = new System.Windows.Forms.Button();
            this.deleteSpec = new System.Windows.Forms.Button();
            this.countDoctorsTb = new System.Windows.Forms.TextBox();
            this.countDoctors = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.studenetsCount = new System.Windows.Forms.Label();
            this.findSpecTb = new System.Windows.Forms.TextBox();
            this.findSpec = new System.Windows.Forms.Button();
            this.findSpecLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cerDateTb = new System.Windows.Forms.TextBox();
            this.cerDate = new System.Windows.Forms.Button();
            this.cerDateLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CurEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.profgroupIds = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupsids = new System.Windows.Forms.Label();
            this.profAddButton = new System.Windows.Forms.Button();
            this.professor_name = new System.Windows.Forms.Label();
            this.ProfessorID = new System.Windows.Forms.Label();
            this.profName = new System.Windows.Forms.TextBox();
            this.profID = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.proffesorsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curatorsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proffesorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupsGrid
            // 
            this.groupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsGrid.Location = new System.Drawing.Point(14, 49);
            this.groupsGrid.Name = "groupsGrid";
            this.groupsGrid.RowTemplate.Height = 25;
            this.groupsGrid.Size = new System.Drawing.Size(374, 207);
            this.groupsGrid.TabIndex = 0;
            // 
            // curatorsGrid
            // 
            this.curatorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.curatorsGrid.Location = new System.Drawing.Point(394, 49);
            this.curatorsGrid.Name = "curatorsGrid";
            this.curatorsGrid.RowTemplate.Height = 25;
            this.curatorsGrid.Size = new System.Drawing.Size(374, 207);
            this.curatorsGrid.TabIndex = 1;
            // 
            // studentsGrid
            // 
            this.studentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGrid.Location = new System.Drawing.Point(774, 49);
            this.studentsGrid.Name = "studentsGrid";
            this.studentsGrid.RowTemplate.Height = 25;
            this.studentsGrid.Size = new System.Drawing.Size(374, 207);
            this.studentsGrid.TabIndex = 2;
            // 
            // loadDoctors
            // 
            this.loadDoctors.Location = new System.Drawing.Point(14, 262);
            this.loadDoctors.Name = "loadDoctors";
            this.loadDoctors.Size = new System.Drawing.Size(374, 23);
            this.loadDoctors.TabIndex = 3;
            this.loadDoctors.Text = "Загрузить";
            this.loadDoctors.UseVisualStyleBackColor = true;
            this.loadDoctors.Click += new System.EventHandler(this.loadGroups_Click);
            // 
            // Groups
            // 
            this.Groups.AutoSize = true;
            this.Groups.Location = new System.Drawing.Point(158, 31);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(45, 15);
            this.Groups.TabIndex = 4;
            this.Groups.Text = "Groups";
            this.Groups.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Curators";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(935, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Students";
            // 
            // loadCur
            // 
            this.loadCur.Location = new System.Drawing.Point(394, 262);
            this.loadCur.Name = "loadCur";
            this.loadCur.Size = new System.Drawing.Size(374, 23);
            this.loadCur.TabIndex = 7;
            this.loadCur.Text = "Загрузить";
            this.loadCur.UseVisualStyleBackColor = true;
            this.loadCur.Click += new System.EventHandler(this.loadCer);
            // 
            // LoadStudents
            // 
            this.LoadStudents.Location = new System.Drawing.Point(774, 262);
            this.LoadStudents.Name = "LoadStudents";
            this.LoadStudents.Size = new System.Drawing.Size(374, 23);
            this.LoadStudents.TabIndex = 8;
            this.LoadStudents.Text = "Загрузить";
            this.LoadStudents.UseVisualStyleBackColor = true;
            this.LoadStudents.Click += new System.EventHandler(this.studentsLoad_Click);
            // 
            // groupid
            // 
            this.groupid.Location = new System.Drawing.Point(42, 331);
            this.groupid.Name = "groupid";
            this.groupid.Size = new System.Drawing.Size(94, 23);
            this.groupid.TabIndex = 9;
            // 
            // groupname
            // 
            this.groupname.Location = new System.Drawing.Point(244, 331);
            this.groupname.Name = "groupname";
            this.groupname.Size = new System.Drawing.Size(94, 23);
            this.groupname.TabIndex = 10;
            // 
            // CurId
            // 
            this.CurId.Location = new System.Drawing.Point(440, 331);
            this.CurId.Name = "CurId";
            this.CurId.Size = new System.Drawing.Size(42, 23);
            this.CurId.TabIndex = 12;
            // 
            // CurName
            // 
            this.CurName.Location = new System.Drawing.Point(488, 331);
            this.CurName.Name = "CurName";
            this.CurName.Size = new System.Drawing.Size(81, 23);
            this.CurName.TabIndex = 13;
            // 
            // student
            // 
            this.student.Location = new System.Drawing.Point(812, 331);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(43, 23);
            this.student.TabIndex = 14;
            // 
            // studname
            // 
            this.studname.Location = new System.Drawing.Point(856, 331);
            this.studname.Name = "studname";
            this.studname.Size = new System.Drawing.Size(106, 23);
            this.studname.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Имя";
            // 
            // createGroupBtn
            // 
            this.createGroupBtn.Location = new System.Drawing.Point(41, 372);
            this.createGroupBtn.Name = "createGroupBtn";
            this.createGroupBtn.Size = new System.Drawing.Size(297, 23);
            this.createGroupBtn.TabIndex = 21;
            this.createGroupBtn.Text = "Добавить";
            this.createGroupBtn.UseVisualStyleBackColor = true;
            this.createGroupBtn.Click += new System.EventHandler(this.createGroupBtn_Click);
            // 
            // changeDoctor
            // 
            this.changeDoctor.Location = new System.Drawing.Point(41, 401);
            this.changeDoctor.Name = "changeDoctor";
            this.changeDoctor.Size = new System.Drawing.Size(297, 23);
            this.changeDoctor.TabIndex = 22;
            this.changeDoctor.Text = "Изменить";
            this.changeDoctor.UseVisualStyleBackColor = true;
            this.changeDoctor.Click += new System.EventHandler(this.changeGroup_Click);
            // 
            // deleteDoctor
            // 
            this.deleteDoctor.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteDoctor.Location = new System.Drawing.Point(42, 430);
            this.deleteDoctor.Name = "deleteDoctor";
            this.deleteDoctor.Size = new System.Drawing.Size(297, 23);
            this.deleteDoctor.TabIndex = 23;
            this.deleteDoctor.Text = "Удалить";
            this.deleteDoctor.UseVisualStyleBackColor = true;
            this.deleteDoctor.Click += new System.EventHandler(this.deleteGroup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(816, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "ID";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(856, 313);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(39, 15);
            this.Name.TabIndex = 25;
            this.Name.Text = "Name";
            // 
            // createSpes
            // 
            this.createSpes.Location = new System.Drawing.Point(812, 372);
            this.createSpes.Name = "createSpes";
            this.createSpes.Size = new System.Drawing.Size(294, 23);
            this.createSpes.TabIndex = 26;
            this.createSpes.Text = "Добавить";
            this.createSpes.UseVisualStyleBackColor = true;
            this.createSpes.Click += new System.EventHandler(this.createStudent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(968, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "GroupId";
            // 
            // createCer
            // 
            this.createCer.Location = new System.Drawing.Point(437, 372);
            this.createCer.Name = "createCer";
            this.createCer.Size = new System.Drawing.Size(297, 23);
            this.createCer.TabIndex = 30;
            this.createCer.Text = "Добавить";
            this.createCer.UseVisualStyleBackColor = true;
            this.createCer.Click += new System.EventHandler(this.createCur_Click);
            // 
            // changeCer
            // 
            this.changeCer.Location = new System.Drawing.Point(437, 401);
            this.changeCer.Name = "changeCer";
            this.changeCer.Size = new System.Drawing.Size(297, 23);
            this.changeCer.TabIndex = 31;
            this.changeCer.Text = "Изменить";
            this.changeCer.UseVisualStyleBackColor = true;
            this.changeCer.Click += new System.EventHandler(this.changeCer_Click);
            // 
            // deleteCer
            // 
            this.deleteCer.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteCer.Location = new System.Drawing.Point(437, 430);
            this.deleteCer.Name = "deleteCer";
            this.deleteCer.Size = new System.Drawing.Size(297, 23);
            this.deleteCer.TabIndex = 32;
            this.deleteCer.Text = "Удалить";
            this.deleteCer.UseVisualStyleBackColor = true;
            this.deleteCer.Click += new System.EventHandler(this.deleteCer_Click);
            // 
            // changeSpec
            // 
            this.changeSpec.Location = new System.Drawing.Point(812, 401);
            this.changeSpec.Name = "changeSpec";
            this.changeSpec.Size = new System.Drawing.Size(297, 23);
            this.changeSpec.TabIndex = 33;
            this.changeSpec.Text = "Изменить";
            this.changeSpec.UseVisualStyleBackColor = true;
            this.changeSpec.Click += new System.EventHandler(this.changeStudent_Click);
            // 
            // deleteSpec
            // 
            this.deleteSpec.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteSpec.Location = new System.Drawing.Point(812, 430);
            this.deleteSpec.Name = "deleteSpec";
            this.deleteSpec.Size = new System.Drawing.Size(297, 23);
            this.deleteSpec.TabIndex = 34;
            this.deleteSpec.Text = "Удалить";
            this.deleteSpec.UseVisualStyleBackColor = true;
            this.deleteSpec.Click += new System.EventHandler(this.deleteStudents_Click);
            // 
            // countDoctorsTb
            // 
            this.countDoctorsTb.Location = new System.Drawing.Point(26, 517);
            this.countDoctorsTb.Name = "countDoctorsTb";
            this.countDoctorsTb.Size = new System.Drawing.Size(80, 23);
            this.countDoctorsTb.TabIndex = 35;
            // 
            // countDoctors
            // 
            this.countDoctors.Location = new System.Drawing.Point(112, 517);
            this.countDoctors.Name = "countDoctors";
            this.countDoctors.Size = new System.Drawing.Size(196, 23);
            this.countDoctors.TabIndex = 36;
            this.countDoctors.Text = "Найти количество студентов";
            this.countDoctors.UseVisualStyleBackColor = true;
            this.countDoctors.Click += new System.EventHandler(this.countStudents_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "ID Группы";
            // 
            // studenetsCount
            // 
            this.studenetsCount.AutoSize = true;
            this.studenetsCount.Location = new System.Drawing.Point(314, 520);
            this.studenetsCount.Name = "studenetsCount";
            this.studenetsCount.Size = new System.Drawing.Size(12, 15);
            this.studenetsCount.TabIndex = 38;
            this.studenetsCount.Text = "-";
            // 
            // findSpecTb
            // 
            this.findSpecTb.Location = new System.Drawing.Point(388, 517);
            this.findSpecTb.Name = "findSpecTb";
            this.findSpecTb.Size = new System.Drawing.Size(72, 23);
            this.findSpecTb.TabIndex = 39;
            // 
            // findSpec
            // 
            this.findSpec.Location = new System.Drawing.Point(466, 517);
            this.findSpec.Name = "findSpec";
            this.findSpec.Size = new System.Drawing.Size(207, 23);
            this.findSpec.TabIndex = 40;
            this.findSpec.Text = "Найти имя куратора";
            this.findSpec.UseVisualStyleBackColor = true;
            this.findSpec.Click += new System.EventHandler(this.findSpec_Click);
            // 
            // findSpecLabel
            // 
            this.findSpecLabel.AutoSize = true;
            this.findSpecLabel.Location = new System.Drawing.Point(684, 521);
            this.findSpecLabel.Name = "findSpecLabel";
            this.findSpecLabel.Size = new System.Drawing.Size(12, 15);
            this.findSpecLabel.TabIndex = 41;
            this.findSpecLabel.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(389, 499);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "ID Студента";
            // 
            // cerDateTb
            // 
            this.cerDateTb.Location = new System.Drawing.Point(760, 517);
            this.cerDateTb.Name = "cerDateTb";
            this.cerDateTb.Size = new System.Drawing.Size(74, 23);
            this.cerDateTb.TabIndex = 43;
            // 
            // cerDate
            // 
            this.cerDate.Location = new System.Drawing.Point(840, 516);
            this.cerDate.Name = "cerDate";
            this.cerDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cerDate.Size = new System.Drawing.Size(218, 23);
            this.cerDate.TabIndex = 44;
            this.cerDate.Text = "Найти средний возраст";
            this.cerDate.UseVisualStyleBackColor = true;
            this.cerDate.Click += new System.EventHandler(this.cerDate_Click);
            // 
            // cerDateLabel
            // 
            this.cerDateLabel.AutoSize = true;
            this.cerDateLabel.Location = new System.Drawing.Point(1064, 520);
            this.cerDateLabel.Name = "cerDateLabel";
            this.cerDateLabel.Size = new System.Drawing.Size(12, 15);
            this.cerDateLabel.TabIndex = 45;
            this.cerDateLabel.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(770, 500);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 15);
            this.label15.TabIndex = 46;
            this.label15.Text = "ID Группы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Email";
            // 
            // CurEmail
            // 
            this.CurEmail.Location = new System.Drawing.Point(631, 331);
            this.CurEmail.Name = "CurEmail";
            this.CurEmail.Size = new System.Drawing.Size(103, 23);
            this.CurEmail.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "GroupId";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(968, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 23);
            this.textBox1.TabIndex = 49;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1026, 331);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 23);
            this.textBox2.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1026, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 52;
            this.label8.Text = "Age";
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox3.Location = new System.Drawing.Point(575, 331);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 23);
            this.textBox3.TabIndex = 53;
            // 
            // profgroupIds
            // 
            this.profgroupIds.Location = new System.Drawing.Point(1362, 331);
            this.profgroupIds.Name = "profgroupIds";
            this.profgroupIds.Size = new System.Drawing.Size(141, 23);
            this.profgroupIds.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1164, 500);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 15);
            this.label16.TabIndex = 68;
            this.label16.Text = "ID Группы";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1458, 520);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 15);
            this.label17.TabIndex = 67;
            this.label17.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1234, 516);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Найти средний возраст";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1154, 517);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(74, 23);
            this.textBox6.TabIndex = 65;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(1206, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 23);
            this.button2.TabIndex = 64;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1206, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(297, 23);
            this.button3.TabIndex = 63;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupsids
            // 
            this.groupsids.AutoSize = true;
            this.groupsids.Location = new System.Drawing.Point(1362, 313);
            this.groupsids.Name = "groupsids";
            this.groupsids.Size = new System.Drawing.Size(55, 15);
            this.groupsids.TabIndex = 62;
            this.groupsids.Text = "GroupsId";
            // 
            // profAddButton
            // 
            this.profAddButton.Location = new System.Drawing.Point(1206, 372);
            this.profAddButton.Name = "profAddButton";
            this.profAddButton.Size = new System.Drawing.Size(294, 23);
            this.profAddButton.TabIndex = 61;
            this.profAddButton.Text = "Добавить";
            this.profAddButton.UseVisualStyleBackColor = true;
            this.profAddButton.Click += new System.EventHandler(this.profAddButton_Click);
            // 
            // professor_name
            // 
            this.professor_name.AutoSize = true;
            this.professor_name.Location = new System.Drawing.Point(1250, 313);
            this.professor_name.Name = "professor_name";
            this.professor_name.Size = new System.Drawing.Size(39, 15);
            this.professor_name.TabIndex = 60;
            this.professor_name.Text = "Name";
            // 
            // ProfessorID
            // 
            this.ProfessorID.AutoSize = true;
            this.ProfessorID.Location = new System.Drawing.Point(1210, 313);
            this.ProfessorID.Name = "ProfessorID";
            this.ProfessorID.Size = new System.Drawing.Size(18, 15);
            this.ProfessorID.TabIndex = 59;
            this.ProfessorID.Text = "ID";
            // 
            // profName
            // 
            this.profName.Location = new System.Drawing.Point(1250, 331);
            this.profName.Name = "profName";
            this.profName.Size = new System.Drawing.Size(106, 23);
            this.profName.TabIndex = 58;
            // 
            // profID
            // 
            this.profID.Location = new System.Drawing.Point(1206, 331);
            this.profID.Name = "profID";
            this.profID.Size = new System.Drawing.Size(43, 23);
            this.profID.TabIndex = 57;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1168, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(374, 23);
            this.button5.TabIndex = 56;
            this.button5.Text = "Загрузить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1329, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 15);
            this.label21.TabIndex = 55;
            this.label21.Text = "Professors";
            this.label21.UseMnemonic = false;
            // 
            // proffesorsGrid
            // 
            this.proffesorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proffesorsGrid.Location = new System.Drawing.Point(1168, 49);
            this.proffesorsGrid.Name = "proffesorsGrid";
            this.proffesorsGrid.RowTemplate.Height = 25;
            this.proffesorsGrid.Size = new System.Drawing.Size(374, 207);
            this.proffesorsGrid.TabIndex = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 620);
            this.Controls.Add(this.profgroupIds);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupsids);
            this.Controls.Add(this.profAddButton);
            this.Controls.Add(this.professor_name);
            this.Controls.Add(this.ProfessorID);
            this.Controls.Add(this.profName);
            this.Controls.Add(this.profID);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.proffesorsGrid);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurEmail);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cerDateLabel);
            this.Controls.Add(this.cerDate);
            this.Controls.Add(this.cerDateTb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.findSpecLabel);
            this.Controls.Add(this.findSpec);
            this.Controls.Add(this.findSpecTb);
            this.Controls.Add(this.studenetsCount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.countDoctors);
            this.Controls.Add(this.countDoctorsTb);
            this.Controls.Add(this.deleteSpec);
            this.Controls.Add(this.changeSpec);
            this.Controls.Add(this.deleteCer);
            this.Controls.Add(this.changeCer);
            this.Controls.Add(this.createCer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.createSpes);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteDoctor);
            this.Controls.Add(this.changeDoctor);
            this.Controls.Add(this.createGroupBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studname);
            this.Controls.Add(this.student);
            this.Controls.Add(this.CurName);
            this.Controls.Add(this.CurId);
            this.Controls.Add(this.groupname);
            this.Controls.Add(this.groupid);
            this.Controls.Add(this.LoadStudents);
            this.Controls.Add(this.loadCur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Groups);
            this.Controls.Add(this.loadDoctors);
            this.Controls.Add(this.studentsGrid);
            this.Controls.Add(this.curatorsGrid);
            this.Controls.Add(this.groupsGrid);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curatorsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proffesorsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView groupsGrid;
        private System.Windows.Forms.DataGridView curatorsGrid;
        private System.Windows.Forms.DataGridView studentsGrid;
        private System.Windows.Forms.Button loadDoctors;
        private System.Windows.Forms.Label Groups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loadCur;
        private System.Windows.Forms.Button LoadStudents;
        private System.Windows.Forms.TextBox groupid;
        private System.Windows.Forms.TextBox groupname;
        private System.Windows.Forms.TextBox CurId;
        private System.Windows.Forms.TextBox CurName;
        private System.Windows.Forms.TextBox student;
        private System.Windows.Forms.TextBox studname;
        private System.Windows.Forms.TextBox GroupId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createGroupBtn;
        private System.Windows.Forms.Button changeDoctor;
        private System.Windows.Forms.Button deleteDoctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Button createSpes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button createCer;
        private System.Windows.Forms.Button changeCer;
        private System.Windows.Forms.Button deleteCer;
        private System.Windows.Forms.Button changeSpec;
        private System.Windows.Forms.Button deleteSpec;
        private System.Windows.Forms.TextBox countDoctorsTb;
        private System.Windows.Forms.Button countDoctors;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label studenetsCount;
        private System.Windows.Forms.TextBox findSpecTb;
        private System.Windows.Forms.Button findSpec;
        private System.Windows.Forms.Label findSpecLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cerDateTb;
        private System.Windows.Forms.Button cerDate;
        private System.Windows.Forms.Label cerDateLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox profgroupIds;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label groupsids;
        private System.Windows.Forms.Button profAddButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label ProfessorID;
        private System.Windows.Forms.TextBox profName;
        private System.Windows.Forms.TextBox profID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView proffesorsGrid;
        private System.Windows.Forms.Label professor_name;
    }
}

