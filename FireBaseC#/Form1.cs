using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace FireBaseC_
{
    public partial class Form1 : Form
    {
        IFirebaseConfig fbConfig = new FirebaseConfig()
        {
            AuthSecret = "vbpOmP6NCQrpNiElztfXGpjvZH6S0qSBpvY7hQE5",
            BasePath = "https://akar24-3437c-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient firebaseClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                firebaseClient = new FireSharp.FirebaseClient(fbConfig);
            }
            catch (Exception)
            {

                MessageBox.Show("Veritabanına Bağlantı Sorunu \n$404");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = textBox1.Text,
                Surname = textBox2.Text
            };

            var doSet = firebaseClient.SetAsync("Users/" + textBox1.Text, user);
            MessageBox.Show("Veriler Eklendi");
            Read();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = txtNewUsername.Text,
                Surname = txtNewSurname.Text
            };
            var doSet = firebaseClient.UpdateAsync("Users/" + textBox1.Text, user);
            MessageBox.Show("Kullanıcı Başarıyla Güncellendi");
            Read();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var doSet = firebaseClient.DeleteAsync("Users/" + textBox1.Text);
            MessageBox.Show("Kullanıcı Başarıyla Silindi");
            Read();
        }
        private void Read()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("UserName", " Name");
            dataGridView1.Columns.Add("Surname", " Surname");
            FirebaseResponse firebaseResponse = firebaseClient.Get(@"Users/");

            Dictionary<string, User> Data = JsonConvert.DeserializeObject<Dictionary<string, User>>(firebaseResponse.Body + "");

            foreach (var item in Data)
            {
                dataGridView1.Rows.Add(item.Value.Name, item.Value.Surname);
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Read(); 
        }
    }
}
