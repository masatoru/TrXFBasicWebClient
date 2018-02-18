using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrXFBasicWebClient.WinForms.Views;
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
            await UpdatePersonList();
        }

        /// <summary>
        /// リストの内容を表示する
        /// </summary>
        async Task UpdatePersonList()
        {
            var webPeople = await WebApiClient.Instance.GetPeopleAsync();

            peopleList.Items.Clear();
            foreach (var person in webPeople)
            {
                peopleList.Items.Add(person);
            }
        }

        /// <summary>
        /// 新規追加ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (new DetailForm(null).ShowDialog() == DialogResult.OK)
            {

            }
        }

        /// <summary>
        /// リストを選択したら編集画面を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void peopleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (peopleList.SelectedItem != null)
            {
                var selectPerson = (Person)peopleList.SelectedItem;
                if (new DetailForm(selectPerson).ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        /// <summary>
        /// データをすべて削除する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void clearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("データをすべて削除します\nよろしいですか？", "確認", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var webPeople = await WebApiClient.Instance.GetPeopleAsync();
                foreach (var person in webPeople)
                {

                }
            }
        }
    }
}
