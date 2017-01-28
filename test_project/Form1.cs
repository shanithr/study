using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using JAVA;

namespace test_project
{
   
   
    public partial class Form1 : Form
    {
        private int sno;

        public Form1()
        {
            InitializeComponent();
            double sno = 0;
            listView1.GridLines = true;
      
        }

        
        private void addButton_Click(object sender, EventArgs e)
        {
            double cost = 0;
            try
            {
           
                cost = (Convert.ToDouble(qTextBox.Text) * Convert.ToDouble(pTextBox.Text));
                ListViewItem listdetails = new ListViewItem((++sno).ToString());
                listdetails.SubItems.Add(nTextBox.Text);
                listdetails.SubItems.Add(qTextBox.Text);
                listdetails.SubItems.Add(pTextBox.Text);
                listdetails.SubItems.Add(Convert.ToString(cost));
                listView1.Items.Add(listdetails);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cleartextbox();
            totalbutton.Enabled = true;
          
        }
        void cleartextbox()
        {
           
            nTextBox.Text = string.Empty;
            qTextBox.Text = string.Empty;
            pTextBox.Text = string.Empty;
        }
        double totalcost()
        {
            if (listView1.Items.Count == 0)
                return 0;

            else
            {
                double total=0;
                foreach(ListViewItem item in listView1.Items)
                {
                    total += Convert.ToDouble(item.SubItems[4].Text);
                }
                return total;
            }

        }
        private void totalbutton_Click(object sender, EventArgs e)
        {
            
            double total = totalcost();
            totalBox.Text = total.ToString();
            totalbutton.Enabled = false;
            clearButton.Enabled = true;
            
           

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            
            clearButton.Enabled = false;
            totalbutton.Enabled = true;
        }


        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter= "bill file(*.bill) |*.bill";
            if(opf.ShowDialog()==DialogResult.OK)
            {
                foreach (string line in File.ReadAllLines(opf.FileName))
                {
                    string[] elem = line.Split( );
                    ListViewItem listdetails = new ListViewItem(elem[0]);
                    listdetails.SubItems.Add(elem[1]);
                    listdetails.SubItems.Add(elem[2]);
                    listdetails.SubItems.Add(elem[3]);
                    listdetails.SubItems.Add(elem[4]);
                    listView1.Items.Add(listdetails);
                }
            }
            opf.Dispose();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "bill file(*.bill) |*.bill";
            sf.Title = "Save file";
            sf.FileName = "test.bill";
            sf.ShowDialog();
            if (sf.FileName != " ")
            {
                StreamWriter file = new StreamWriter(sf.FileName);
                foreach (ListViewItem item in listView1.Items)
                {
                    StringBuilder line = new StringBuilder();
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        if (i > 0)
                            line.Append(" ");
                        line.Append(item.SubItems[i].Text);
                    }
                    file.WriteLine(line);


                }
                file.Close();
            }
        }
    }
}
