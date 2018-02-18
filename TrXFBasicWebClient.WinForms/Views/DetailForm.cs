using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XFBasicWebClient.Models;

namespace TrXFBasicWebClient.WinForms.Views
{
    public partial class DetailForm : Form
    {
        private Person Current { get; set; }

        public DetailForm(Person person)
        {
            InitializeComponent();
            Current = person;
            edtId.Enabled = false;
        }

        /// <summary>
        /// フォームの初期化時に値をセットする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailForm_Load(object sender, EventArgs e)
        {
            if (Current != null)
            {
                edtId.Text = Current.Id.ToString();
                edtName.Text = Current.Name;
                dateTimeBirthday.Value = Current.Birthday.DateTime;
            }
            else
            {
                edtId.Text = "0";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
