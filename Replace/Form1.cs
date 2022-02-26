using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Replace
{
    public partial class Form1 : Form
    {
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
            for (int i = 40; i < 59; i++)
            {
                database.SqlQuery($"INSERT INTO TestTable (ID, FirstName, LastName, " +
                    $"Age) VALUES ({i}, 'User №{i}', 'LastName', {i+20})");
            }
            database.ShowTable("SELECT * FROM TestTable", usersView);
        }
    }
}
