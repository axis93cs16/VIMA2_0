using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIMA2_0
{
    
    public partial class Form2 : Form
    {
        public System.Windows.Forms.DialogResult DialRes;
        public System.Windows.Forms.Label labelu1;
        public System.Windows.Forms.Label labelu2;
        public System.Windows.Forms.TextBox textu1;
        public System.Windows.Forms.TextBox textu2;
        public System.Windows.Forms.Button butu1;
        
        public Form2()
        {
            InitializeComponent();
            DialRes = new System.Windows.Forms.DialogResult();
            Form2_init();
        }
        public void Form2_init()
        {
            Width = 270;
            Height = 190;
            int sizeoffreespace = 10;
            int nextystart = 10;
            int sizelabw = 120;
            int sizelabh = 30;
            
            labelu1 = new System.Windows.Forms.Label();
            labelu2 = new System.Windows.Forms.Label();
            textu1 = new System.Windows.Forms.TextBox();
            textu2 = new System.Windows.Forms.TextBox();
            butu1 = new System.Windows.Forms.Button();
            labelu1.AutoSize = false;
            labelu2.AutoSize = false;
            textu1.AutoSize = false;
            textu2.AutoSize = false;
            butu1.AutoSize = false;
            labelu1.Width = sizelabw;
            labelu1.Height = sizelabh;
            labelu2.Width = sizelabw;
            labelu2.Height = sizelabh;
            textu1.Width = sizelabw;
            textu1.Height = sizelabh;
            textu2.Width = sizelabw;
            textu2.Height = sizelabh;
            butu1.Width = sizelabw;
            butu1.Height = sizelabh;
            int sizeoftext = 16;
            labelu1.Font = new Font(labelu1.Font.Name, sizeoftext, labelu1.Font.Style);
            labelu2.Font = new Font(labelu2.Font.Name, sizeoftext, labelu2.Font.Style);
            textu1.Font = new Font(textu1.Font.Name, sizeoftext, textu1.Font.Style);
            textu2.Font = new Font(textu2.Font.Name, sizeoftext, textu2.Font.Style);
            butu1.Font = new Font(butu1.Font.Name, sizeoftext, butu1.Font.Style);
            labelu1.Text = "Логин";
            labelu2.Text = "Пароль";
            butu1.Text = "Вход";
            labelu1.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            textu1.Location = new Point(sizeoffreespace + labelu1.Width, nextystart + sizeoffreespace);
            nextystart += 10 + labelu1.Height;//2-строка
            labelu2.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            textu2.Location = new Point(sizeoffreespace + labelu2.Width, nextystart + sizeoffreespace);
            butu1.Location = new Point(sizeoffreespace + labelu2.Width, nextystart + sizeoffreespace * 2 + textu2.Height);
            butu1.Click += new EventHandler(butu1_Click);
            this.textu2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            Controls.Add(labelu1);
            Controls.Add(labelu2);
            Controls.Add(textu1);
            Controls.Add(textu2);
            Controls.Add(butu1);
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                butu1_Click(null, new EventArgs());
            }
        }
        private void butu1_Click(object sender, EventArgs e)
        {
            var user1 = VIMA2_0.Properties.Settings.Default.username1;
            string user1ok = user1.Split(':')[0];
            string pass1ok = user1.Split(':')[1];
            if (textu1.Text.Equals(user1ok) & textu2.Text.Equals(pass1ok))
            { 
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
