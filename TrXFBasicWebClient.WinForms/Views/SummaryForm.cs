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

namespace TrXFBasicWebClient.WinForms
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームが初期化されるときに呼ばれるので
        /// ここで一覧を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SummaryForm_Load(object sender, EventArgs e)
        {
            var webPeople = await WebApiClient.Instance.GetPeopleAsync();

            peopleList.Items.Clear();
            foreach (var person in webPeople)
            {
                peopleList.Items.Add(person);
            }
        }
    }
}
