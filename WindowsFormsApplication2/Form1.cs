using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using mshtml;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections;
using System.Threading;

namespace VIMA2_0
{


    public partial class Form1 : Form
    {
        private System.Windows.Forms.Label labelz1;
        private System.Windows.Forms.Label labelz2;
        private System.Windows.Forms.Label labelz3;
        private System.Windows.Forms.Label labelz4;
        private System.Windows.Forms.Label labelz5;
        private System.Windows.Forms.Label labelz6;
        private System.Windows.Forms.Label labelz7;
        private System.Windows.Forms.Label labelz8;
        private System.Windows.Forms.Label labelz9;
        private System.Windows.Forms.Label labelz10;
        private System.Windows.Forms.Label labelz11;
        private System.Windows.Forms.Label labelz12;
        private System.Windows.Forms.Label labelz13;
        private System.Windows.Forms.Label labelz14;
        private System.Windows.Forms.Label labelz15;
        private System.Windows.Forms.Label labelz16;
        private System.Windows.Forms.Label labelz17;
        private System.Windows.Forms.Label labelz18;
        private System.Windows.Forms.Label labelz19;
        private System.Windows.Forms.Label labelz20;
        private System.Windows.Forms.Label labelz21;
        private System.Windows.Forms.Label labelz22;
        private System.Windows.Forms.Label labelz23;

        private string livesrcnow;
        private string httpsrcnow;
        private string httpsrcnow_itog;
        private int secu_test = 0;
        private WebClient client = new WebClient();

        private System.Windows.Forms.Label labellnk1;
        private System.Windows.Forms.Label labellnk2;
        private System.Windows.Forms.Label labellnk3;
        private System.Windows.Forms.Label labellnk4;
        private System.Windows.Forms.Button butlnk1;
        private System.Windows.Forms.Button butlnk2;
        private System.Windows.Forms.Button butlnk3;
        private System.Windows.Forms.Button butlnk4;
        private System.Windows.Forms.Button butlnkd1;
        private System.Windows.Forms.Button butlnkd2;
        private System.Windows.Forms.Button butlnkd3;
        private System.Windows.Forms.Button butlnkd4;
        private System.Windows.Forms.ProgressBar progressBard1;


        private string dllink1;
        private string dllink2;
        private string dllink3;
        private string dllink4;
        private int speczal;
        private string urlofplaynow;
        private int dlcount=0;

        public Form1()
        {
            labelz1 = new System.Windows.Forms.Label();
            labelz2 = new System.Windows.Forms.Label();
            labelz3 = new System.Windows.Forms.Label();
            labelz4 = new System.Windows.Forms.Label();
            labelz5 = new System.Windows.Forms.Label();
            labelz6 = new System.Windows.Forms.Label();
            labelz7 = new System.Windows.Forms.Label();
            labelz8 = new System.Windows.Forms.Label();
            labelz9 = new System.Windows.Forms.Label();
            labelz10 = new System.Windows.Forms.Label();
            labelz11 = new System.Windows.Forms.Label();
            labelz12 = new System.Windows.Forms.Label();
            labelz13 = new System.Windows.Forms.Label();
            labelz14 = new System.Windows.Forms.Label();
            labelz15 = new System.Windows.Forms.Label();
            labelz16 = new System.Windows.Forms.Label();
            labelz17 = new System.Windows.Forms.Label();
            labelz18 = new System.Windows.Forms.Label();
            labelz19 = new System.Windows.Forms.Label();
            labelz20 = new System.Windows.Forms.Label();
            labelz21 = new System.Windows.Forms.Label();
            labelz22 = new System.Windows.Forms.Label();
            labelz23 = new System.Windows.Forms.Label();

            labellnk1 = new System.Windows.Forms.Label();
            labellnk2 = new System.Windows.Forms.Label();
            labellnk3 = new System.Windows.Forms.Label();
            labellnk4 = new System.Windows.Forms.Label();
            butlnk1 = new System.Windows.Forms.Button();
            butlnk2 = new System.Windows.Forms.Button();
            butlnk3 = new System.Windows.Forms.Button();
            butlnk4 = new System.Windows.Forms.Button();
            butlnkd1 = new System.Windows.Forms.Button();
            butlnkd2 = new System.Windows.Forms.Button();
            butlnkd3 = new System.Windows.Forms.Button();
            butlnkd4 = new System.Windows.Forms.Button();
            progressBard1 = new System.Windows.Forms.ProgressBar();





            labelz1.Text = "Зал №3(B001)";
            labelz2.Text = "Зал №14(B002)";
            labelz3.Text = "Атриум(D106)";
            labelz4.Text = "Зал №7(B201)";
            labelz5.Text = "Зал №13(B202)";
            labelz6.Text = "Зал №11(B203)";
            labelz7.Text = "Зал №12(B204)";
            labelz8.Text = "Зал №8(B205)";
            labelz9.Text = "Зал №4(B301)";
            labelz10.Text = "Зал №10(B302)";
            labelz11.Text = "Зал №1(B303кам1)";
            labelz12.Text = "Зал №1(B303кам2)";
            labelz13.Text = "Зал №1(B303кам3)";
            labelz14.Text = "Зал №6(B401)";
            labelz15.Text = "Зал №9(B402)";
            labelz16.Text = "Зал №2(B403кам1)";
            labelz17.Text = "Зал №2(B403кам2)";
            labelz18.Text = "Зал №5(B404)";
            labelz19.Text = "Театр Сцена";
            labelz20.Text = "Репзал кам1";
            labelz21.Text = "Репзал кам2";
            labelz22.Text = "15 (А101 кам1)";
            labelz23.Text = "15 (А101 кам2)";
            int sizeoftext = 16;
            labelz1.Font = new Font(labelz1.Font.Name, sizeoftext, labelz1.Font.Style);
            labelz2.Font = new Font(labelz2.Font.Name, sizeoftext, labelz2.Font.Style);
            labelz3.Font = new Font(labelz3.Font.Name, sizeoftext, labelz3.Font.Style);
            labelz4.Font = new Font(labelz4.Font.Name, sizeoftext, labelz4.Font.Style);
            labelz5.Font = new Font(labelz5.Font.Name, sizeoftext, labelz5.Font.Style);
            labelz6.Font = new Font(labelz6.Font.Name, sizeoftext, labelz6.Font.Style);
            labelz7.Font = new Font(labelz7.Font.Name, sizeoftext, labelz7.Font.Style);
            labelz8.Font = new Font(labelz8.Font.Name, sizeoftext, labelz8.Font.Style);
            labelz9.Font = new Font(labelz9.Font.Name, sizeoftext, labelz9.Font.Style);
            labelz10.Font = new Font(labelz10.Font.Name, sizeoftext, labelz10.Font.Style);
            labelz11.Font = new Font(labelz11.Font.Name, sizeoftext, labelz11.Font.Style);
            labelz12.Font = new Font(labelz12.Font.Name, sizeoftext, labelz12.Font.Style);
            labelz13.Font = new Font(labelz13.Font.Name, sizeoftext, labelz13.Font.Style);
            labelz14.Font = new Font(labelz14.Font.Name, sizeoftext, labelz14.Font.Style);
            labelz15.Font = new Font(labelz15.Font.Name, sizeoftext, labelz15.Font.Style);
            labelz16.Font = new Font(labelz16.Font.Name, sizeoftext, labelz16.Font.Style);
            labelz17.Font = new Font(labelz17.Font.Name, sizeoftext, labelz17.Font.Style);
            labelz18.Font = new Font(labelz18.Font.Name, sizeoftext, labelz18.Font.Style);
            labelz19.Font = new Font(labelz19.Font.Name, sizeoftext, labelz19.Font.Style);
            labelz20.Font = new Font(labelz20.Font.Name, sizeoftext, labelz20.Font.Style);
            labelz21.Font = new Font(labelz21.Font.Name, sizeoftext, labelz21.Font.Style);
            labelz22.Font = new Font(labelz22.Font.Name, sizeoftext, labelz22.Font.Style);
            labelz23.Font = new Font(labelz23.Font.Name, sizeoftext, labelz23.Font.Style);
            int sizelabw = 300;
            int sizelabh = 30;
            labelz1.AutoSize = false;
            labelz2.AutoSize = false;
            labelz3.AutoSize = false;
            labelz4.AutoSize = false;
            labelz5.AutoSize = false;
            labelz6.AutoSize = false;
            labelz7.AutoSize = false;
            labelz8.AutoSize = false;
            labelz9.AutoSize = false;
            labelz10.AutoSize = false;
            labelz11.AutoSize = false;
            labelz12.AutoSize = false;
            labelz13.AutoSize = false;
            labelz14.AutoSize = false;
            labelz15.AutoSize = false;
            labelz16.AutoSize = false;
            labelz17.AutoSize = false;
            labelz18.AutoSize = false;
            labelz19.AutoSize = false;
            labelz20.AutoSize = false;
            labelz21.AutoSize = false;
            labelz22.AutoSize = false;
            labelz23.AutoSize = false;

            labelz1.Width = sizelabw;
            labelz1.Height = sizelabh;
            labelz2.Width = sizelabw;
            labelz2.Height = sizelabh;
            labelz3.Width = sizelabw;
            labelz3.Height = sizelabh;
            labelz4.Width = sizelabw;
            labelz4.Height = sizelabh;
            labelz5.Width = sizelabw;
            labelz5.Height = sizelabh;
            labelz6.Width = sizelabw;
            labelz6.Height = sizelabh;
            labelz7.Width = sizelabw;
            labelz7.Height = sizelabh;
            labelz8.Width = sizelabw;
            labelz8.Height = sizelabh;
            labelz9.Width = sizelabw;
            labelz9.Height = sizelabh;
            labelz10.Width = sizelabw;
            labelz10.Height = sizelabh;
            labelz11.Width = sizelabw;
            labelz11.Height = sizelabh;
            labelz12.Width = sizelabw;
            labelz12.Height = sizelabh;
            labelz13.Width = sizelabw;
            labelz13.Height = sizelabh;
            labelz14.Width = sizelabw;
            labelz14.Height = sizelabh;
            labelz15.Width = sizelabw;
            labelz15.Height = sizelabh;
            labelz16.Width = sizelabw;
            labelz16.Height = sizelabh;
            labelz17.Width = sizelabw;
            labelz17.Height = sizelabh;
            labelz18.Width = sizelabw;
            labelz18.Height = sizelabh;
            labelz19.Width = sizelabw;
            labelz19.Height = sizelabh;
            labelz20.Width = sizelabw;
            labelz20.Height = sizelabh;
            labelz21.Width = sizelabw;
            labelz21.Height = sizelabh;
            labelz22.Width = sizelabw;
            labelz22.Height = sizelabh;
            labelz23.Width = sizelabw;
            labelz23.Height = sizelabh;
            int sizeoffreespace = 10;
            int nextystart = 0;
            labelz1.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz1.Height;
            labelz2.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz2.Height;
            labelz3.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz3.Height;
            labelz4.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz4.Height;
            labelz5.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz5.Height;
            labelz6.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz6.Height;
            labelz7.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz7.Height;
            labelz8.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz8.Height;
            labelz9.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz9.Height;
            labelz10.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz10.Height;
            labelz11.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz11.Height;
            labelz12.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz12.Height;
            labelz13.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz13.Height;
            labelz14.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz14.Height;
            labelz15.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz15.Height;
            labelz16.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz16.Height;
            labelz17.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz17.Height;
            labelz18.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz18.Height;
            labelz19.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz19.Height;
            labelz20.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz20.Height;
            labelz21.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz21.Height;
            labelz22.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);
            nextystart += labelz22.Height;
            labelz23.Location = new Point(sizeoffreespace, nextystart + sizeoffreespace);

            labelz1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF9988");
            labelz2.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFF88");
            labelz3.BackColor = System.Drawing.ColorTranslator.FromHtml("#EEEEEE");
            labelz4.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFF88");
            labelz5.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF9988");
            labelz6.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF9988");
            labelz7.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBDDFF");
            labelz8.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBDDFF");
            labelz9.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBDDFF");
            labelz10.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFF88");
            labelz11.BackColor = System.Drawing.ColorTranslator.FromHtml("#EEEEEE");
            labelz12.BackColor = System.Drawing.ColorTranslator.FromHtml("#EEEEEE");
            labelz13.BackColor = System.Drawing.ColorTranslator.FromHtml("#EEEEEE");
            labelz14.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFF88");
            labelz15.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBDDFF");
            labelz16.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBDDFF");
            labelz17.BackColor = System.Drawing.ColorTranslator.FromHtml("#BBDDFF");
            labelz18.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF9988");
            labelz19.BackColor = System.Drawing.ColorTranslator.FromHtml("#EEEEEE");
            labelz21.BackColor = System.Drawing.ColorTranslator.FromHtml("#EEEEEE");
            labelz22.BackColor = System.Drawing.ColorTranslator.FromHtml("#EEEEEE");
            labelz23.BackColor = System.Drawing.ColorTranslator.FromHtml("#EEEEEE");

            labelz1.Click += new EventHandler(labelz1_Click);
            labelz2.Click += new EventHandler(labelz2_Click);
            labelz3.Click += new EventHandler(labelz3_Click);
            labelz4.Click += new EventHandler(labelz4_Click);
            labelz5.Click += new EventHandler(labelz5_Click);
            labelz6.Click += new EventHandler(labelz6_Click);
            labelz7.Click += new EventHandler(labelz7_Click);
            labelz8.Click += new EventHandler(labelz8_Click);
            labelz9.Click += new EventHandler(labelz9_Click);
            labelz10.Click += new EventHandler(labelz10_Click);
            labelz11.Click += new EventHandler(labelz11_Click);
            labelz12.Click += new EventHandler(labelz12_Click);
            labelz13.Click += new EventHandler(labelz13_Click);
            labelz14.Click += new EventHandler(labelz14_Click);
            labelz15.Click += new EventHandler(labelz15_Click);
            labelz16.Click += new EventHandler(labelz16_Click);
            labelz17.Click += new EventHandler(labelz17_Click);
            labelz18.Click += new EventHandler(labelz18_Click);
            labelz19.Click += new EventHandler(labelz19_Click);
            labelz20.Click += new EventHandler(labelz20_Click);
            labelz21.Click += new EventHandler(labelz21_Click);
            labelz22.Click += new EventHandler(labelz22_Click);
            labelz23.Click += new EventHandler(labelz23_Click);

            int sizeoftext2 = 11;
            int sizeoftext3 = 8;
            labellnk1.Text = "";
            labellnk2.Text = "";
            labellnk3.Text = "";
            labellnk4.Text = "";
            butlnk1.Text = "Смотреть";
            butlnk2.Text = "Смотреть";
            butlnk3.Text = "Смотреть";
            butlnk4.Text = "Смотреть";
            butlnkd1.Text = "Скачать";
            butlnkd2.Text = "Скачать";
            butlnkd3.Text = "Скачать";
            butlnkd4.Text = "Скачать";
            labellnk1.Font = new Font(labellnk1.Font.Name, sizeoftext3, labellnk1.Font.Style);
            labellnk2.Font = new Font(labellnk2.Font.Name, sizeoftext3, labellnk2.Font.Style);
            labellnk3.Font = new Font(labellnk3.Font.Name, sizeoftext3, labellnk3.Font.Style);
            labellnk4.Font = new Font(labellnk4.Font.Name, sizeoftext3, labellnk4.Font.Style);
            butlnk1.Font = new Font(butlnk1.Font.Name, sizeoftext2, butlnk1.Font.Style);
            butlnk2.Font = new Font(butlnk2.Font.Name, sizeoftext2, butlnk2.Font.Style);
            butlnk3.Font = new Font(butlnk3.Font.Name, sizeoftext2, butlnk3.Font.Style);
            butlnk4.Font = new Font(butlnk4.Font.Name, sizeoftext2, butlnk4.Font.Style);
            butlnkd1.Font = new Font(butlnkd1.Font.Name, sizeoftext2, butlnkd1.Font.Style);
            butlnkd2.Font = new Font(butlnkd2.Font.Name, sizeoftext2, butlnkd2.Font.Style);
            butlnkd3.Font = new Font(butlnkd3.Font.Name, sizeoftext2, butlnkd3.Font.Style);
            butlnkd4.Font = new Font(butlnkd4.Font.Name, sizeoftext2, butlnkd4.Font.Style);

            butlnk1.BackColor = System.Drawing.ColorTranslator.FromHtml("#99FF77");
            butlnk2.BackColor = System.Drawing.ColorTranslator.FromHtml("#99FF77");
            butlnk3.BackColor = System.Drawing.ColorTranslator.FromHtml("#99FF77");
            butlnk4.BackColor = System.Drawing.ColorTranslator.FromHtml("#99FF77");
            butlnkd1.BackColor = System.Drawing.ColorTranslator.FromHtml("#AAEEFF");
            butlnkd2.BackColor = System.Drawing.ColorTranslator.FromHtml("#AAEEFF");
            butlnkd3.BackColor = System.Drawing.ColorTranslator.FromHtml("#AAEEFF");
            butlnkd4.BackColor = System.Drawing.ColorTranslator.FromHtml("#AAEEFF");

            labellnk1.BackColor = System.Drawing.ColorTranslator.FromHtml("#AAEEFF");
            labellnk2.BackColor = System.Drawing.ColorTranslator.FromHtml("#AAEEFF");
            labellnk3.BackColor = System.Drawing.ColorTranslator.FromHtml("#AAEEFF");
            labellnk4.BackColor = System.Drawing.ColorTranslator.FromHtml("#AAEEFF");

            labellnk1.AutoSize = false;
            labellnk2.AutoSize = false;
            labellnk3.AutoSize = false;
            labellnk4.AutoSize = false;
            butlnk1.AutoSize = false;
            butlnk2.AutoSize = false;
            butlnk3.AutoSize = false;
            butlnk4.AutoSize = false;
            butlnkd1.AutoSize = false;
            butlnkd2.AutoSize = false;
            butlnkd3.AutoSize = false;
            butlnkd4.AutoSize = false;


            int sizelabw2 = 180;
            int sizelabw3 = 90;
            int sizelabh2 = 30;

            labellnk1.Width = sizelabw2;
            labellnk1.Height = sizelabh2;
            labellnk2.Width = sizelabw2;
            labellnk2.Height = sizelabh2;
            labellnk3.Width = sizelabw2;
            labellnk3.Height = sizelabh2;
            labellnk4.Width = sizelabw2;
            labellnk4.Height = sizelabh2;
            butlnk1.Width = sizelabw3;
            butlnk1.Height = sizelabh2;
            butlnk2.Width = sizelabw3;
            butlnk2.Height = sizelabh2;
            butlnk3.Width = sizelabw3;
            butlnk3.Height = sizelabh2;
            butlnk4.Width = sizelabw3;
            butlnk4.Height = sizelabh2;
            butlnkd1.Width = sizelabw3;
            butlnkd1.Height = sizelabh2;
            butlnkd2.Width = sizelabw3;
            butlnkd2.Height = sizelabh2;
            butlnkd3.Width = sizelabw3;
            butlnkd3.Height = sizelabh2;
            butlnkd4.Width = sizelabw3;
            butlnkd4.Height = sizelabh2;

            progressBard1.Width = sizelabw3 + sizelabw2 + sizeoffreespace + sizelabw3;
            progressBard1.Height = 10;

            int sizeoffreespace2 = 770;
            int nextystart2 = 18;
            labellnk1.Location = new Point(sizeoffreespace2, nextystart2 + sizeoffreespace);
            butlnk1.Location = new Point(sizeoffreespace2 + labellnk1.Width, nextystart2 + sizeoffreespace);
            butlnkd1.Location = new Point(sizeoffreespace2 + labellnk1.Width + sizeoffreespace + butlnk1.Width, nextystart2 + sizeoffreespace);
            nextystart2 += labellnk1.Height + sizeoffreespace; //след строка
            labellnk2.Location = new Point(sizeoffreespace2, nextystart2 + sizeoffreespace);
            butlnk2.Location = new Point(sizeoffreespace2 + labellnk2.Width, nextystart2 + sizeoffreespace);
            butlnkd2.Location = new Point(sizeoffreespace2 + labellnk2.Width + sizeoffreespace + butlnk2.Width, nextystart2 + sizeoffreespace);
            nextystart2 += labellnk2.Height + sizeoffreespace; //след строка
            labellnk3.Location = new Point(sizeoffreespace2, nextystart2 + sizeoffreespace);
            butlnk3.Location = new Point(sizeoffreespace2 + labellnk3.Width, nextystart2 + sizeoffreespace);
            butlnkd3.Location = new Point(sizeoffreespace2 + labellnk3.Width + sizeoffreespace + butlnk3.Width, nextystart2 + sizeoffreespace);
            nextystart2 += labellnk3.Height + sizeoffreespace; //след строка
            labellnk4.Location = new Point(sizeoffreespace2, nextystart2 + sizeoffreespace);
            butlnk4.Location = new Point(sizeoffreespace2 + labellnk4.Width, nextystart2 + sizeoffreespace);
            butlnkd4.Location = new Point(sizeoffreespace2 + labellnk4.Width + sizeoffreespace + butlnk4.Width, nextystart2 + sizeoffreespace);
            
            progressBard1.Location = new Point(sizeoffreespace2, sizeoffreespace);


            butlnk1.Click += new EventHandler(butlnk1_Click);
            butlnk2.Click += new EventHandler(butlnk2_Click);
            butlnk3.Click += new EventHandler(butlnk3_Click);
            butlnk4.Click += new EventHandler(butlnk4_Click);
            butlnkd1.Click += new EventHandler(butlnkd1_Click);
            butlnkd2.Click += new EventHandler(butlnkd2_Click);
            butlnkd3.Click += new EventHandler(butlnkd3_Click);
            butlnkd4.Click += new EventHandler(butlnkd4_Click);


            Controls.Add(labellnk1);
            Controls.Add(labellnk2);
            Controls.Add(labellnk3);
            Controls.Add(labellnk4);
            Controls.Add(butlnk1);
            Controls.Add(butlnk2);
            Controls.Add(butlnk3);
            Controls.Add(butlnk4);
            Controls.Add(butlnkd1);
            Controls.Add(butlnkd2);
            Controls.Add(butlnkd3);
            Controls.Add(butlnkd4);
            Controls.Add(progressBard1);

            Controls.Add(labelz1);
            Controls.Add(labelz2);
            Controls.Add(labelz3);
            Controls.Add(labelz4);
            Controls.Add(labelz5);
            Controls.Add(labelz6);
            Controls.Add(labelz7);
            Controls.Add(labelz8);
            Controls.Add(labelz9);
            Controls.Add(labelz10);
            Controls.Add(labelz11);
            Controls.Add(labelz12);
            Controls.Add(labelz13);
            Controls.Add(labelz14);
            Controls.Add(labelz15);
            Controls.Add(labelz16);
            Controls.Add(labelz17);
            Controls.Add(labelz18);
            Controls.Add(labelz19);
            Controls.Add(labelz20);
            Controls.Add(labelz21);
            Controls.Add(labelz22);
            Controls.Add(labelz23);
            InitializeComponent();
            this.AutoSize = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //axVLCPlugin21.AutoPlay = true;
            AXVLC.VLCPlugin2 axVLCPlugin21my2 = new AXVLC.VLCPlugin2();
            axVLCPlugin21my.BeginInit();
            axVLCPlugin21my.Show();
            axVLCPlugin21my.EndInit();
            // table generate
            trackBar2.Value = DateTime.Now.Hour;
            trackBar1.Value = DateTime.Now.Minute;
            if ((trackBar1.Value < 10) & (trackBar2.Value < 10))
            {
                labeltime.Text = "0" + trackBar2.Value + ":" + "0" + trackBar1.Value;
            } else if ((trackBar1.Value >= 10) & (trackBar2.Value < 10))
            {
                labeltime.Text = "0" + trackBar2.Value + ":" + trackBar1.Value;
            } else if ((trackBar1.Value < 10) & (trackBar2.Value >= 10))
            {
                labeltime.Text = trackBar2.Value + ":" + "0" + trackBar1.Value;
            } else if ((trackBar1.Value >= 10) & (trackBar2.Value >= 10))
            {
                labeltime.Text = trackBar2.Value + ":" + trackBar1.Value;
            }
            monthCalendar1.TodayDate = DateTime.Now.Date;
            monthCalendar1.SelectionStart = DateTime.Now.Date;
            labeldate.Text = monthCalendar1.SelectionStart.Date.ToString("yyyy:MM:dd");
            labelz1_Click(null, new EventArgs());
            client.InitializeLifetimeService();
            client.Encoding = System.Text.Encoding.UTF8;
            //INITIALIZE HTTPBROWSER
            try {
                Stream data = client.OpenRead(new Uri("http://172.21.2.8"));
                StreamReader reader = new StreamReader(data);
                reader.ReadToEnd();
                reader.Dispose();
            } catch (Exception e) {
                //ERRORCATCH
            }
            //INITIALIZE HTTPBROWSER

        }


        private void clearplaylist()
        {
            if (axVLCPlugin21my.playlist.isPlaying == true)
            {
                axVLCPlugin21my.playlist.stop();
                axVLCPlugin21my.playlist.items.clear();
            }
        }
        private void PlayThis(string urlofplay = null)
        {
            string[] options = new string[] { @":network-caching=20" };

            if (urlofplay != urlofplaynow && urlofplaynow != textBox1.Text)
            {
                clearplaylist();
                if (urlofplay == null)
                {
                    axVLCPlugin21my.playlist.add(textBox1.Text, null, options);
                    urlofplaynow = textBox1.Text;
                }
                else
                {
                    axVLCPlugin21my.playlist.add(urlofplay, null, options);
                    urlofplaynow = urlofplay;
                }
                axVLCPlugin21my.playlist.playItem(0);
            } else
            {
                if (axVLCPlugin21my.playlist.isPlaying == true)
                { axVLCPlugin21my.playlist.stop(); }
                else
                { axVLCPlugin21my.playlist.play(); }
            }
        }
        private void updatelinks()
        {
            var datathis = DateTime.ParseExact(labeldate.Text + " " + labeltime.Text + ":00", "yyyy:MM:dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            var datathisend = datathis.AddMinutes(Convert.ToInt32(textBox2.Text));//.Subtract(new TimeSpan(0, 60, 0);
            //TimeZoneInfo.ConvertTimeBySystemTimeZoneId(datathis, "Russian Standard Time", "GMT Standard Time");
            //TimeZoneInfo.ConvertTimeToUtc(datathis,TimeZoneInfo.Utc);
            textBox1.Text = livesrcnow + "?start_time=" + datathis.ToUniversalTime().ToString("yyyyMMddTHHmmss.0Z") + "&end_time=" + datathisend.ToUniversalTime().ToString("yyyyMMddTHHmmss.0Z") + "&current_position=" + datathis.ToUniversalTime().ToString("yyyyMMddTHHmmss.0Z");
            httpsrcnow_itog = httpsrcnow + "?start_time=" + datathis.ToUniversalTime().ToString("yyyyMMddTHHmmss.0Z") + "&end_time=" + datathisend.ToUniversalTime().ToString("yyyyMMddTHHmmss.0Z") + "&current_position=" + datathis.ToUniversalTime().ToString("yyyyMMddTHHmmss.0Z");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (speczal == 1) {
                getlinks();
            }
            else {
                updatelinks();
                PlayThis();
                //axVLCPlugin21my.Toolbar = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            updatelinks();
            PlayThis(livesrcnow);
            //axVLCPlugin21my.Toolbar = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1.ActiveForm(false);
            int adtest_result = ADTest("VIMA");
            switch (adtest_result)
            {
                case 1: MessageBox.Show("Компьютер не принадлежит домену"); secu_test = 2; break;
                case 2: MessageBox.Show("В AD не найдена учетная запись текущего пользователя."); secu_test = 2; break;
                case 3: MessageBox.Show("В AD не найдена учетная запись текущего пользователя."); secu_test = 2; break;
                case 4: MessageBox.Show("Не найдена соответствующая группа пользователей в AD."); secu_test = 2; break;
                case 5: MessageBox.Show("Текущий пользователь не входит в состав группы"); secu_test = 2; break;
                case 10: secu_test = 1; break;
            }
            if (secu_test == 2)
            {
                Form2 f2 = new Form2();
                if (f2.ShowDialog(this) == DialogResult.Cancel)
                {
                    //MessageBox.Show("ok");
                    System.Environment.Exit(1);
                };
            }  //System.Environment.Exit(1); };

        }

        private int ADTest(string groupName)
        {
            try
            {
                System.DirectoryServices.ActiveDirectory.Domain.GetComputerDomain();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return 1;//e.Message;
            }
            string res;
            //DirectoryEntry adRoot = new DirectoryEntry("LDAP://" + domain, null, null, AuthenticationTypes.Secure); //подключение к AD
            using (DirectorySearcher ds = new DirectorySearcher("SAMAccountName=" + SystemInformation.UserName))
            {
                try
                {
                    ds.FindOne();
                }
                catch (Exception e)
                {
                    return 2;// e.Message; 
                }
                SearchResult sr = ds.FindOne();
                if (sr == null) return 3;//("В AD не найдена учетная запись текущего пользователя.");
                using (DirectoryEntry user = sr.GetDirectoryEntry())
                {
                    ds.Filter = "(&(Name=" + groupName + ")(objectClass=group))";
                    sr = ds.FindOne();
                    if (sr == null) return 4; //("Не найдена соответствующая группа пользователей AD.");
                    using (DirectoryEntry group = sr.GetDirectoryEntry())
                    {
                        if (!(bool)group.Invoke("IsMember", new object[] { user.Path }))
                            return 5; //("Текущий пользователь не входит в состав группы " + group);
                    }
                    res = user.Properties.Contains("displayName") ? user.Properties["displayName"].Value.ToString() : "???";
                }
            }
            return 10;//res;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void selectzal(int zal)
        {
            labelz1.Font = new Font(labelz1.Font.Name, labelz1.Font.Size, FontStyle.Regular);
            labelz2.Font = new Font(labelz2.Font.Name, labelz2.Font.Size, FontStyle.Regular);
            labelz3.Font = new Font(labelz3.Font.Name, labelz3.Font.Size, FontStyle.Regular);
            labelz4.Font = new Font(labelz4.Font.Name, labelz4.Font.Size, FontStyle.Regular);
            labelz5.Font = new Font(labelz5.Font.Name, labelz5.Font.Size, FontStyle.Regular);
            labelz6.Font = new Font(labelz6.Font.Name, labelz6.Font.Size, FontStyle.Regular);
            labelz7.Font = new Font(labelz7.Font.Name, labelz7.Font.Size, FontStyle.Regular);
            labelz8.Font = new Font(labelz8.Font.Name, labelz8.Font.Size, FontStyle.Regular);
            labelz9.Font = new Font(labelz9.Font.Name, labelz9.Font.Size, FontStyle.Regular);
            labelz10.Font = new Font(labelz10.Font.Name, labelz10.Font.Size, FontStyle.Regular);
            labelz11.Font = new Font(labelz11.Font.Name, labelz11.Font.Size, FontStyle.Regular);
            labelz12.Font = new Font(labelz12.Font.Name, labelz12.Font.Size, FontStyle.Regular);
            labelz13.Font = new Font(labelz13.Font.Name, labelz13.Font.Size, FontStyle.Regular);
            labelz14.Font = new Font(labelz14.Font.Name, labelz14.Font.Size, FontStyle.Regular);
            labelz15.Font = new Font(labelz15.Font.Name, labelz15.Font.Size, FontStyle.Regular);
            labelz16.Font = new Font(labelz16.Font.Name, labelz16.Font.Size, FontStyle.Regular);
            labelz17.Font = new Font(labelz17.Font.Name, labelz17.Font.Size, FontStyle.Regular);
            labelz18.Font = new Font(labelz18.Font.Name, labelz18.Font.Size, FontStyle.Regular);
            labelz19.Font = new Font(labelz19.Font.Name, labelz19.Font.Size, FontStyle.Regular);
            labelz20.Font = new Font(labelz20.Font.Name, labelz20.Font.Size, FontStyle.Regular);
            labelz21.Font = new Font(labelz21.Font.Name, labelz21.Font.Size, FontStyle.Regular);
            labelz22.Font = new Font(labelz22.Font.Name, labelz22.Font.Size, FontStyle.Regular);
            labelz23.Font = new Font(labelz23.Font.Name, labelz23.Font.Size, FontStyle.Regular);
            speczal = 0;

            button1.Show();
            labellnk1.Hide();
            butlnk1.Hide();
            butlnkd1.Hide();
            labellnk2.Hide();
            butlnk2.Hide();
            butlnkd2.Hide();
            labellnk3.Hide();
            butlnk3.Hide();
            butlnkd3.Hide();
            labellnk4.Hide();
            butlnk4.Hide();
            butlnkd4.Hide();
            label4.Hide();

            if (zal == 1) { labelz1.Font = new Font(labelz1.Font.Name, labelz1.Font.Size, FontStyle.Bold); };
            if (zal == 2) { labelz2.Font = new Font(labelz2.Font.Name, labelz2.Font.Size, FontStyle.Bold); };
            if (zal == 3) { labelz3.Font = new Font(labelz3.Font.Name, labelz3.Font.Size, FontStyle.Bold); };
            if (zal == 4) { labelz4.Font = new Font(labelz4.Font.Name, labelz4.Font.Size, FontStyle.Bold); };
            if (zal == 5) { labelz5.Font = new Font(labelz5.Font.Name, labelz5.Font.Size, FontStyle.Bold); };
            if (zal == 6) { labelz6.Font = new Font(labelz6.Font.Name, labelz6.Font.Size, FontStyle.Bold); };
            if (zal == 7) { labelz7.Font = new Font(labelz7.Font.Name, labelz7.Font.Size, FontStyle.Bold); };
            if (zal == 8) { labelz8.Font = new Font(labelz8.Font.Name, labelz8.Font.Size, FontStyle.Bold); };
            if (zal == 9) { labelz9.Font = new Font(labelz9.Font.Name, labelz9.Font.Size, FontStyle.Bold); };
            if (zal == 10) { labelz10.Font = new Font(labelz10.Font.Name, labelz10.Font.Size, FontStyle.Bold); };
            if (zal == 11) { labelz11.Font = new Font(labelz11.Font.Name, labelz11.Font.Size, FontStyle.Bold); };
            if (zal == 12) { labelz12.Font = new Font(labelz12.Font.Name, labelz12.Font.Size, FontStyle.Bold); };
            if (zal == 13) { labelz13.Font = new Font(labelz13.Font.Name, labelz13.Font.Size, FontStyle.Bold); };
            if (zal == 14) { labelz14.Font = new Font(labelz14.Font.Name, labelz14.Font.Size, FontStyle.Bold); };
            if (zal == 15) { labelz15.Font = new Font(labelz15.Font.Name, labelz15.Font.Size, FontStyle.Bold); };
            if (zal == 16) { labelz16.Font = new Font(labelz16.Font.Name, labelz16.Font.Size, FontStyle.Bold); };
            if (zal == 17) { labelz17.Font = new Font(labelz17.Font.Name, labelz17.Font.Size, FontStyle.Bold); };
            if (zal == 18) { labelz18.Font = new Font(labelz18.Font.Name, labelz18.Font.Size, FontStyle.Bold); };
            if (zal == 19) { labelz19.Font = new Font(labelz19.Font.Name, labelz19.Font.Size, FontStyle.Bold); button1.Hide(); };
            if (zal == 20) { labelz20.Font = new Font(labelz20.Font.Name, labelz20.Font.Size, FontStyle.Bold); speczal = 1; };
            if (zal == 21) { labelz21.Font = new Font(labelz21.Font.Name, labelz21.Font.Size, FontStyle.Bold); speczal = 1; };
            if (zal == 22) { labelz22.Font = new Font(labelz22.Font.Name, labelz22.Font.Size, FontStyle.Bold); speczal = 1; };
            if (zal == 23) { labelz23.Font = new Font(labelz23.Font.Name, labelz23.Font.Size, FontStyle.Bold); speczal = 1; };
            if (speczal == 1)
            {
                button1.Text = "Найти записи";
            }
            else
            {
                button1.Text = "Проиграть";
            }
        }
        private void getlinks()
        {
            butlnkd1.Text = "Скачать";
            butlnkd2.Text = "Скачать";
            butlnkd3.Text = "Скачать";
            butlnkd4.Text = "Скачать";
            string result = "";
            //            Console.WriteLine("Making API Call...");
            //            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            //            {
            //                client.BaseAddress = new Uri(httpsrcnow_itog);
            //                HttpResponseMessage response = client.GetAsync("").Result;
            //                response.EnsureSuccessStatusCode();
            //                result = response.Content.ReadAsStringAsync().Result;
            //                Console.WriteLine("Result: " + result);
            //            }
            //            Console.ReadLine();
            // WebClient object


            // Retrieve resource as a stream
            Stream data = client.OpenRead(new Uri(httpsrcnow_itog));

            // Retrive the text
            StreamReader reader = new StreamReader(data);
            result = reader.ReadToEnd();
            reader.Dispose();
            // Obtain the document interface

            mshtml.IHTMLDocument2 htmlDocument = (IHTMLDocument2)new mshtml.HTMLDocument();
            htmlDocument.write(result);
            // Extract all image elements
            IHTMLElementCollection lnkElements = htmlDocument.links;
            int contval = 1;
            label4.Show();
            foreach (IHTMLElement lnk in lnkElements)
            {
                if (lnk.className.Contains("videofile1"))
                {
                    label4.Hide();
                    if (contval == 1)
                    {
                        string[] tmplnk = lnk.getAttribute("href").Split(':')[1].Split('/');
                        labellnk1.Text = tmplnk[tmplnk.Length - 1];
                        dllink1 = httpsrcnow.Split(':')[0] + ":" + httpsrcnow.Split(':')[1].Split(':')[0] + lnk.getAttribute("href").Split(':')[1];
                        labellnk1.Show();
                        butlnk1.Show();
                        butlnkd1.Show();

                    }
                    if (contval == 2)
                    {
                        string[] tmplnk = lnk.getAttribute("href").Split(':')[1].Split('/');
                        labellnk2.Text = tmplnk[tmplnk.Length - 1];
                        dllink2 = httpsrcnow.Split(':')[0] + ":" + httpsrcnow.Split(':')[1].Split(':')[0] + lnk.getAttribute("href").Split(':')[1];
                        labellnk2.Show();
                        butlnk2.Show();
                        butlnkd2.Show();
                    }
                    if (contval == 3)
                    {
                        string[] tmplnk = lnk.getAttribute("href").Split(':')[1].Split('/');
                        labellnk3.Text = tmplnk[tmplnk.Length - 1];
                        dllink3 = httpsrcnow.Split(':')[0] + ":" + httpsrcnow.Split(':')[1].Split(':')[0] + lnk.getAttribute("href").Split(':')[1];
                        labellnk3.Show();
                        butlnk3.Show();
                        butlnkd3.Show();
                    }
                    if (contval == 4)
                    {
                        string[] tmplnk = lnk.getAttribute("href").Split(':')[1].Split('/');
                        labellnk4.Text = tmplnk[tmplnk.Length - 1];
                        dllink4 = httpsrcnow.Split(':')[0] + ":" + httpsrcnow.Split(':')[1].Split(':')[0] + lnk.getAttribute("href").Split(':')[1];
                        labellnk4.Show();
                        butlnk4.Show();
                        butlnkd4.Show();
                    }
                    contval++;
                }

            }
        }
        private void labelz1_Click(object sender, EventArgs e)
        {
            selectzal(1);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-6";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-6";
            updatelinks();
            clearplaylist();
        }
        private void labelz2_Click(object sender, EventArgs e)
        {
            selectzal(2);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-12";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-12";
            updatelinks();
            clearplaylist();
        }
        private void labelz3_Click(object sender, EventArgs e)
        {
            selectzal(3);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-11";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-11";
            updatelinks();
            clearplaylist();
        }
        private void labelz4_Click(object sender, EventArgs e)
        {
            selectzal(4);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-15";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-15";
            updatelinks();
            clearplaylist();
        }
        private void labelz5_Click(object sender, EventArgs e)
        {
            selectzal(5);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-3";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-3";
            updatelinks();
            clearplaylist();
        }
        private void labelz6_Click(object sender, EventArgs e)
        {
            selectzal(6);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-10";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-10";
            updatelinks();
            clearplaylist();
        }
        private void labelz7_Click(object sender, EventArgs e)
        {
            selectzal(7);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-2";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-2";
            updatelinks();
            clearplaylist();
        }
        private void labelz8_Click(object sender, EventArgs e)
        {
            selectzal(8);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-5";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-5";
            updatelinks();
            clearplaylist();
        }
        private void labelz9_Click(object sender, EventArgs e)
        {
            selectzal(9);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-16";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-16";
            updatelinks();
            clearplaylist();
        }
        private void labelz10_Click(object sender, EventArgs e)
        {
            selectzal(10);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-4";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-4";
            updatelinks();
            clearplaylist();
        }
        private void labelz11_Click(object sender, EventArgs e)
        {
            selectzal(11);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-0";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-0";
            updatelinks();
            clearplaylist();
        }
        private void labelz12_Click(object sender, EventArgs e)
        {
            selectzal(12);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-17";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-17";
            updatelinks();
            clearplaylist();
        }
        private void labelz13_Click(object sender, EventArgs e)
        {
            selectzal(13);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-1";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-1";
            updatelinks();
            clearplaylist();
        }
        private void labelz14_Click(object sender, EventArgs e)
        {
            selectzal(14);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-14";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-14";
            updatelinks();
            clearplaylist();
        }
        private void labelz15_Click(object sender, EventArgs e)
        {
            selectzal(15);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-7";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-7";
            updatelinks();
            clearplaylist();
        }
        private void labelz16_Click(object sender, EventArgs e)
        {
            selectzal(16);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-9";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-9";
            updatelinks();
            clearplaylist();
        }
        private void labelz17_Click(object sender, EventArgs e)
        {
            selectzal(17);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-13";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-13";
            updatelinks();
            clearplaylist();
        }
        private void labelz18_Click(object sender, EventArgs e)
        {
            selectzal(18);
            livesrcnow = "rtsp://172.21.2.8:554/tshift-ch-8";
            httpsrcnow = "http://172.21.2.8:8080/tshift-ch-8";
            updatelinks();
            clearplaylist();
        }
        private void labelz19_Click(object sender, EventArgs e)
        {
            selectzal(19);
            livesrcnow = "rtsp://172.21.2.8:12347/theater";
            httpsrcnow = "";
            updatelinks();
            clearplaylist();
        }
        private void labelz20_Click(object sender, EventArgs e)
        {
            selectzal(20);
            livesrcnow = "rtsp://172.21.2.8:12347/rep1";
            httpsrcnow = "http://172.21.2.8:8980/rep1";
            updatelinks();
            clearplaylist();
        }
        private void labelz21_Click(object sender, EventArgs e)
        {
            selectzal(21);
            livesrcnow = "rtsp://172.21.2.8:12347/rep2";
            httpsrcnow = "http://172.21.2.8:8980/rep2";
            updatelinks();
            clearplaylist();
        }
        private void labelz22_Click(object sender, EventArgs e)
        {
            selectzal(22);
            livesrcnow = "rtsp://172.21.2.8:12347/a101cam1";
            httpsrcnow = "http://172.21.2.8:8980/15-1";
            updatelinks();
            clearplaylist();
        }
        private void labelz23_Click(object sender, EventArgs e)
        {
            selectzal(23);
            livesrcnow = "rtsp://172.21.2.8:12347/a101cam2";
            httpsrcnow = "http://172.21.2.8:8980/15-2";
            updatelinks();
            clearplaylist();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            string tmp = labeltime.Text;
            if (trackBar2.Value < 10)
            {
                labeltime.Text = "0" + trackBar2.Value + ":" + tmp.Split(':')[1];
            }
            else
            {
                labeltime.Text = trackBar2.Value + ":" + tmp.Split(':')[1];
            }
            updatelinks();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            string tmp = labeltime.Text;
            if (trackBar1.Value < 10)
            {
                labeltime.Text = tmp.Split(':')[0] + ":" + "0" + trackBar1.Value;
            }
            else
            {
                labeltime.Text = tmp.Split(':')[0] + ":" + trackBar1.Value;
            }
            updatelinks();
        }



        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            labeldate.Text = monthCalendar1.SelectionStart.Date.ToString("yyyy:MM:dd");
            updatelinks();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox2.Text)))
            {
                if (Convert.ToInt32(textBox2.Text) <= 0 || Convert.ToInt32(textBox2.Text) > 180)
                {
                    textBox2.Text = Convert.ToString(60);
                }
            };
            updatelinks();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            updatelinks();
        }
        private void butlnk1_Click(object sender, EventArgs e)
        {
            PlayThis(dllink1);
        }
        private void butlnk2_Click(object sender, EventArgs e)
        {
            PlayThis(dllink2);
        }
        private void butlnk3_Click(object sender, EventArgs e)
        {
            PlayThis(dllink3);
        }
        private void butlnk4_Click(object sender, EventArgs e)
        {
            PlayThis(dllink4);
        }
        private void butlnkd1_Click(object sender, EventArgs e)
        {
            //client.DownloadFile(dllink1, dllink1.Split('/')[dllink1.Split('/').Length - 1] + ".mpeg");
            downloadlnk(dllink1,1);
        }
        private void butlnkd2_Click(object sender, EventArgs e)
        {
            //client.DownloadFile(dllink1, dllink1.Split('/')[dllink1.Split('/').Length - 1] + ".mpeg");
            downloadlnk(dllink2, 2);
        }
        private void butlnkd3_Click(object sender, EventArgs e)
        {
            //client.DownloadFile(dllink1, dllink1.Split('/')[dllink1.Split('/').Length - 1] + ".mpeg");
            downloadlnk(dllink3, 3);
        }
        private void butlnkd4_Click(object sender, EventArgs e)
        {
            //client.DownloadFile(dllink1, dllink1.Split('/')[dllink1.Split('/').Length - 1] + ".mpeg");
            downloadlnk(dllink4, 4);
        }
        private void downloadlnk(string dllink, int butlnk=1)
        {
            //dlcount++;
            using (WebClient client2 = new WebClient())
            {
                //button1.Enabled = true;
                if (butlnk == 1) { butlnkd1.Enabled = false; butlnkd1.Text = "Качаем"; }
                if (butlnk == 2) { butlnkd2.Enabled = false; butlnkd2.Text = "Качаем"; }
                if (butlnk == 3) { butlnkd3.Enabled = false; butlnkd3.Text = "Качаем"; }
                if (butlnk == 4) { butlnkd4.Enabled = false; butlnkd4.Text = "Качаем"; }

                //var notifier = new AutoResetEvent(false);
                client2.InitializeLifetimeService();
                client2.Encoding = System.Text.Encoding.UTF8;                      
                client2.DownloadProgressChanged += delegate(object sender, DownloadProgressChangedEventArgs e)
                {

                    progressBard1.Value = e.ProgressPercentage;
                    if (e.ProgressPercentage >= 100)
                    {
                        if (butlnk == 1) { butlnkd1.Enabled = true; butlnkd1.Text = "Скачано"; }
                        if (butlnk == 2) { butlnkd2.Enabled = true; butlnkd2.Text = "Скачано"; }
                        if (butlnk == 3) { butlnkd3.Enabled = true; butlnkd3.Text = "Скачано"; }
                        if (butlnk == 4) { butlnkd4.Enabled = true; butlnkd4.Text = "Скачано"; }
                        button1.Enabled = true;
                        //dlcount--;
                        //notifier.Set();
                        //MessageBox.Show(Convert.ToString(e.ProgressPercentage) + " = " + notifier.ToString()); ;
                    }
                    else
                    {
                        button1.Enabled = false;
                    }
                };
                client2.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri(dllink),
                    // Param2 = Path to save
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\downloads\\" + dllink.Split('/')[dllink.Split('/').Length - 1]
                );
                //notifier.WaitOne();
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
