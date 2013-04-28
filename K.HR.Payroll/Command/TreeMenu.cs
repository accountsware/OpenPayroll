using System.Windows.Forms;
using K.Common.UI.Patterns;
using K.HR.Payroll.Command.Payroll;

namespace K.HR.Payroll.Command
{
    class TreeMenu
    {
        internal static void PopulateMenu(TreeView treeview, MainForm mainform)
        {
            treeview.Nodes.Add(TreeMenuPayrollMaster(mainform));
        }

        static TreeNode TreeMenuPayrollMaster(MainForm mainform)
        {
            var salesNodes = new TreeNode("Data Master", new[]
            {				
			    
                new TreeNodeCommand("Employees", new EmployeeCommand()
                                                     {
                                                         CurrentMainForm = mainform
                                                     }),
				new TreeNodeCommand("Employee Position", new PositionCommand()
                                                     {
                                                         CurrentMainForm = mainform
                                                     }),
				new TreeNodeCommand("Payroll Group", new PayrollGroupCommand()
                                                     {
                                                         CurrentMainForm = mainform
                                                     })
            });
            return salesNodes;
        }
    }
}
