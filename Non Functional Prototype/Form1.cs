using System;
using System.Windows.Forms;

namespace Working_Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //closes the form//
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //opens menu for ordering ability (customer tab)
        private void viewMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Menu vm = new View_Menu();
            vm.ShowDialog();
        }

        //opens shopping cart to view what items were selected (customer tab)
        private void viewShoppingCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Cart vc = new View_Cart();
            vc.ShowDialog();
        }

        //opens window for a customer to create an account (customer tab)
        private void createNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Customer_Account nca = new New_Customer_Account();
            nca.ShowDialog();
        }

        //opens window for manager/employee to see inventory report: Add/edit/delete inventory, and reconcile with physical count (manager/employee tab)
        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory_Report ir = new Inventory_Report();
            ir.ShowDialog();
        }

        //open window for a manager/employee to view a sales report: Most/least purchased item, and sales trends (manager/employee tab)
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Report sr = new Sales_Report();
            sr.ShowDialog();
        }

        //opens window for a manager to view customer account information: Ability to modify frequent customer status, view Purchase history, total amount spent, etc. (manager/employee tab)
        private void customerProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Profiles cp = new Customer_Profiles();
            cp.ShowDialog();
        }

        //opens a window for a manager to view employee profiles: Personal info, Type, Salary, Hire date, Active/terminated status (manager/employee tab)
        private void employeeReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Report er = new Employee_Report();
            er.ShowDialog();
        }

        //under the staff tab, opens a window for a manager to edit/remove an employee (manager/employee tab)
        private void editRemoveEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_or_Remove_Employees eore = new Edit_or_Remove_Employees();
            eore.ShowDialog();
        }

        //opens window for a manager/employee to create (add) a new employee account (manager/employee tab)
        private void createNewAccount2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Employee_Account cea = new Create_Employee_Account();
            cea.ShowDialog();
        }        
    }
}
