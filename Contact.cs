using ContactsBook_Project.contactClasses;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace ContactsBook_Project;

public partial class Contact : Form
{
    public Contact()
    {
        InitializeComponent();
    }
    contactClass c = new contactClass();
    private void btnAdd_Click(object sender, EventArgs e)
    {
        // Get the value from the input fields
        c.FirstName = txtboxFirstName.Text;
        c.LastName = txtboxLastName.Text;
        c.ContactNo = txtboxContactNumber.Text;
        c.Address = txtboxAddress.Text;
        c.Gender = cmbGender.Text;

        // Inserting Data into Database using the method we created
        bool success = c.Insert(c);
        if (success)
        {
            //Successfully Inserted
            MessageBox.Show("New Contact Successfully Inserted");

            // Call the Clear methond
            Clear();
        }
        else
        {
            MessageBox.Show("Failed to add New Cotact. Try Again.");
        }

        // Load Data on Data Gridview
        DataTable dt = c.Select();
        dgvContactList.DataSource = dt;
    }

    private void Contact_Load(object sender, EventArgs e)
    {
        // Load Data on Data Gridview
        DataTable dt = c.Select();
        dgvContactList.DataSource = dt;
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    // Method to Clear Fields
    public void Clear()
    {
        txtboxFirstName.Text = "";
        txtboxLastName.Text = "";
        txtboxContactNumber.Text = "";
        txtboxAddress.Text = "";
        cmbGender.Text = "";
        txtboxContactID.Text = "";
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        // Get the Data from textboxes
        c.ContactID = int.Parse(txtboxContactID.Text);
        c.FirstName = txtboxFirstName.Text;
        c.LastName = txtboxLastName.Text;
        c.ContactNo = txtboxContactNumber.Text;
        c.Address = txtboxAddress.Text;
        c.Gender = cmbGender.Text;

        // Upadte Data in Database
        bool success = c.Update(c);
        if (success)
        {
            // Upload Successfully
            MessageBox.Show("Contact has been successfully updated");

            // Load Data on Data Gridview
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

            // Call Clear method
            Clear();
        }
        else
        {
            MessageBox.Show("Failed to Update Contact. Try Again");
        }
    }

    private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        // Get the Data from Data Grid View and load it to the textboxes respectively
        // identify the row on which mouse is clicker
        int rowIndex = e.RowIndex;
        txtboxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
        txtboxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
        txtboxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
        txtboxContactNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
        txtboxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
        cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        // Call Clear method
        Clear();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtboxContactID.Text))
        {
            c.ContactID = Convert.ToInt32(txtboxContactID.Text);
        }
        else
        {
            c.ContactID = 0;
            MessageBox.Show("ContactID should be not empty. Choose contact to delete from grid");
            return;
        }
        bool success = c.Delete(c);

        if (success)
        {
            // Successfully Deleted
            MessageBox.Show("Contact successfully deleted");

            // Refresh Data gridview
            // Load Data on Data Gridview
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

            // Call Clear method
            Clear();
        }
        else
        {
            MessageBox.Show("Failed to Delete Contact. Try Again");
        }
    }

    static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
    private void txtboxSearch_TextChanged(object sender, EventArgs e)
    {
        // Get the value from text box

        string keyword = txtboxSearch.Text;
        SqlConnection conn = new SqlConnection(myconnstring);
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%'" +
            "OR LastName LIKE '%" + keyword + "%' " +
            "OR ContactNo LIKE '%" + keyword + "%'" +
            "OR Address LIKE '%" + keyword + "%'", conn);

        DataTable dt = new DataTable();
        adapter.Fill(dt);
        dgvContactList.DataSource = dt;
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
}
