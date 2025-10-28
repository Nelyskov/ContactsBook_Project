namespace ContactsBook_Project;

partial class Contact
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
        pictureBox1 = new PictureBox();
        lblContactID = new Label();
        txtboxContactID = new TextBox();
        txtboxFirstName = new TextBox();
        lblFirstName = new Label();
        txtboxLastName = new TextBox();
        lblLastName = new Label();
        txtboxContactNumber = new TextBox();
        lblContactNumber = new Label();
        txtboxAddress = new TextBox();
        lblAddress = new Label();
        cmbGender = new ComboBox();
        lblGender = new Label();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgvContactList = new DataGridView();
        label1 = new Label();
        txtboxSearch = new TextBox();
        pictureBox2 = new PictureBox();
        label2 = new Label();
        label3 = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources._8673842;
        pictureBox1.Location = new Point(85, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(427, 139);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // lblContactID
        // 
        lblContactID.AutoSize = true;
        lblContactID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        lblContactID.Location = new Point(50, 200);
        lblContactID.Name = "lblContactID";
        lblContactID.Size = new Size(104, 25);
        lblContactID.TabIndex = 1;
        lblContactID.Text = "Contact ID";
        // 
        // txtboxContactID
        // 
        txtboxContactID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        txtboxContactID.Location = new Point(200, 200);
        txtboxContactID.Name = "txtboxContactID";
        txtboxContactID.ReadOnly = true;
        txtboxContactID.Size = new Size(301, 30);
        txtboxContactID.TabIndex = 2;
        // 
        // txtboxFirstName
        // 
        txtboxFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        txtboxFirstName.Location = new Point(200, 250);
        txtboxFirstName.Name = "txtboxFirstName";
        txtboxFirstName.Size = new Size(301, 30);
        txtboxFirstName.TabIndex = 4;
        // 
        // lblFirstName
        // 
        lblFirstName.AutoSize = true;
        lblFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        lblFirstName.Location = new Point(50, 250);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Size = new Size(106, 25);
        lblFirstName.TabIndex = 3;
        lblFirstName.Text = "First Name";
        // 
        // txtboxLastName
        // 
        txtboxLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        txtboxLastName.Location = new Point(200, 300);
        txtboxLastName.Name = "txtboxLastName";
        txtboxLastName.Size = new Size(301, 30);
        txtboxLastName.TabIndex = 6;
        // 
        // lblLastName
        // 
        lblLastName.AutoSize = true;
        lblLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        lblLastName.Location = new Point(50, 300);
        lblLastName.Name = "lblLastName";
        lblLastName.Size = new Size(106, 25);
        lblLastName.TabIndex = 5;
        lblLastName.Text = "Last Name";
        // 
        // txtboxContactNumber
        // 
        txtboxContactNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        txtboxContactNumber.Location = new Point(200, 350);
        txtboxContactNumber.Name = "txtboxContactNumber";
        txtboxContactNumber.Size = new Size(301, 30);
        txtboxContactNumber.TabIndex = 8;
        // 
        // lblContactNumber
        // 
        lblContactNumber.AutoSize = true;
        lblContactNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        lblContactNumber.Location = new Point(50, 350);
        lblContactNumber.Name = "lblContactNumber";
        lblContactNumber.Size = new Size(115, 25);
        lblContactNumber.TabIndex = 7;
        lblContactNumber.Text = "Contact No.";
        // 
        // txtboxAddress
        // 
        txtboxAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        txtboxAddress.Location = new Point(200, 400);
        txtboxAddress.Multiline = true;
        txtboxAddress.Name = "txtboxAddress";
        txtboxAddress.Size = new Size(301, 150);
        txtboxAddress.TabIndex = 10;
        // 
        // lblAddress
        // 
        lblAddress.AutoSize = true;
        lblAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        lblAddress.Location = new Point(50, 400);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new Size(85, 25);
        lblAddress.TabIndex = 9;
        lblAddress.Text = "Address";
        // 
        // cmbGender
        // 
        cmbGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        cmbGender.FormattingEnabled = true;
        cmbGender.Items.AddRange(new object[] { "Male", "Female", "Nonbinary" });
        cmbGender.Location = new Point(200, 564);
        cmbGender.Name = "cmbGender";
        cmbGender.Size = new Size(301, 33);
        cmbGender.TabIndex = 11;
        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        lblGender.Location = new Point(50, 564);
        lblGender.Name = "lblGender";
        lblGender.Size = new Size(77, 25);
        lblGender.TabIndex = 12;
        lblGender.Text = "Gender";
        // 
        // btnAdd
        // 
        btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        btnAdd.Location = new Point(359, 651);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(153, 50);
        btnAdd.TabIndex = 13;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        btnUpdate.Location = new Point(518, 651);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(153, 50);
        btnUpdate.TabIndex = 14;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        btnDelete.Location = new Point(677, 651);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(153, 50);
        btnDelete.TabIndex = 15;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        btnClear.Location = new Point(836, 651);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(153, 50);
        btnClear.TabIndex = 16;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // dgvContactList
        // 
        dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvContactList.Location = new Point(545, 250);
        dgvContactList.Name = "dgvContactList";
        dgvContactList.RowHeadersWidth = 51;
        dgvContactList.Size = new Size(757, 347);
        dgvContactList.TabIndex = 17;
        dgvContactList.RowHeaderMouseClick += dgvContactList_RowHeaderMouseClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label1.Location = new Point(545, 206);
        label1.Name = "label1";
        label1.Size = new Size(75, 25);
        label1.TabIndex = 18;
        label1.Text = "Search";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtboxSearch
        // 
        txtboxSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        txtboxSearch.Location = new Point(637, 203);
        txtboxSearch.Name = "txtboxSearch";
        txtboxSearch.Size = new Size(616, 30);
        txtboxSearch.TabIndex = 19;
        txtboxSearch.TextChanged += txtboxSearch_TextChanged;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.icons8_close_window_48;
        pictureBox2.Location = new Point(1288, 12);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(48, 48);
        pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
        pictureBox2.TabIndex = 20;
        pictureBox2.TabStop = false;
        pictureBox2.Click += pictureBox2_Click;
        // 
        // label2
        // 
        label2.Location = new Point(0, 0);
        label2.Name = "label2";
        label2.Size = new Size(100, 23);
        label2.TabIndex = 0;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Showcard Gothic", 35F);
        label3.ForeColor = Color.DeepSkyBlue;
        label3.Location = new Point(359, 43);
        label3.Name = "label3";
        label3.Size = new Size(575, 74);
        label3.TabIndex = 21;
        label3.Text = "E-PhoneBook App";
        label3.Click += label3_Click;
        // 
        // Contact
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1348, 743);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(pictureBox2);
        Controls.Add(txtboxSearch);
        Controls.Add(label1);
        Controls.Add(dgvContactList);
        Controls.Add(btnClear);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnAdd);
        Controls.Add(lblGender);
        Controls.Add(cmbGender);
        Controls.Add(txtboxAddress);
        Controls.Add(lblAddress);
        Controls.Add(txtboxContactNumber);
        Controls.Add(lblContactNumber);
        Controls.Add(txtboxLastName);
        Controls.Add(lblLastName);
        Controls.Add(txtboxFirstName);
        Controls.Add(lblFirstName);
        Controls.Add(txtboxContactID);
        Controls.Add(lblContactID);
        Controls.Add(pictureBox1);
        DoubleBuffered = true;
        Name = "Contact";
        Text = "ContactB";
        Load += Contact_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label lblContactID;
    private TextBox txtboxContactID;
    private TextBox txtboxFirstName;
    private Label lblFirstName;
    private TextBox txtboxLastName;
    private Label lblLastName;
    private TextBox txtboxContactNumber;
    private Label lblContactNumber;
    private TextBox txtboxAddress;
    private Label lblAddress;
    private ComboBox cmbGender;
    private Label lblGender;
    private Button btnAdd;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnClear;
    private DataGridView dataGridView1;
    private Label label1;
    private TextBox txtboxSearch;
    private PictureBox pictureBox2;
    private DataGridView dgvContactList;
    private Label label2;
    private Label label3;
}
