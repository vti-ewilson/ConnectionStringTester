using Acuit.Pinpoint.Server.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionStringTester
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			DBTypeDropdown.SelectedIndex = 0;
		}

		private void TestButton_Click(object sender, EventArgs e)
		{
			if(DBTypeDropdown.SelectedIndex == 0)
			{
				try
				{
					SqlConnection con = new SqlConnection(connStrBox.Text);
					con.Open();
					con.Close();

					checkMark.Visible = true;
					RedX.Visible = false;
				}
				catch 
				{ 
					checkMark.Visible = false;
					RedX.Visible = true;
				}
			}
			else if(DBTypeDropdown.SelectedIndex == 1)
			{
				
				try
				{
					OracleConnection con = new OracleConnection();
					con.ConnectionString = connStrBox.Text;
					con.Open();
					con.Close();

					checkMark.Visible = true;
					RedX.Visible = false;
				}
				catch
				{
					checkMark.Visible = false;
					RedX.Visible = true;
				}
			}
			else if(DBTypeDropdown.SelectedIndex == 2)
			{
				try
				{
					PinpointClient con = new PinpointClient(connStrBox.Text, true);
					con.Open();
					con.Close();

					checkMark.Visible = true;
					RedX.Visible = false;
				}
				catch
				{
					checkMark.Visible = false;
					RedX.Visible = true;
				}
			}
		}

		private void DBTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			checkMark.Visible = false;
			RedX.Visible = false;

			if(DBTypeDropdown.SelectedIndex == 2)
			{
				connStrLabel.Text = "Server Name";
			}
			else
			{
				connStrLabel.Text = "Connection String";
			}
		}

		private void connStrBox_TextChanged(object sender, EventArgs e)
		{
			checkMark.Visible = false;
			RedX.Visible = false;
		}
	}
}
