using Employee_Manager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Manager.Forms
{
    public partial class ViewDetails : Form
    {
        public ViewDetails(UsersData result)
        {
            InitializeComponent(result);
        }
    }
}
