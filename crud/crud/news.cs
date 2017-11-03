using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crud.Models;

namespace crud
{
    public partial class news : Form
    {
        private crudEntities2 db = new crudEntities2();
        private news selected_news;
        


        public news()
        {
            InitializeComponent();
            loadData();
            dgvNews.Columns[0].Visible = false;
        }

        private void loadData()
        {
            dgvNews.DataSource = db.news.Select(n => new { n.id, n.title, n.data, n.categoryId, n.content }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            
            string category = txtCategory.Text;
            string content = txtContent.Text;

            if (title==string.Empty||category==string.Empty||content==string.Empty)
            {
                MessageBox.Show("Boshluq olmaz !!!");
                return;
            }

            
            
            

        }
    }
}
