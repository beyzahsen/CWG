using System.Net.Sockets;
using System.Text;

namespace FinalHomework
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstAreaSelect = new System.Windows.Forms.CheckedListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtAttack = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAreaSelect
            // 
            this.lstAreaSelect.FormattingEnabled = true;
            this.lstAreaSelect.Items.AddRange(new object[] {
            "1-Mordovia",
            "2-Chuvashia",
            "3-Man El",
            "4- Udmurtia",
            "5- Permic Republic",
            "6- Volga German Republic",
            "7- Tataristan",
            "8- Bashkortostan",
            "9- Republic of Chelyabinsk",
            "10- Adygeya",
            "11- North Caucasian Fed.",
            "12- Kalmykia",
            "13- Khakassia",
            "14- Tannu- Tuva"});
            this.lstAreaSelect.Location = new System.Drawing.Point(700, 44);
            this.lstAreaSelect.Name = "lstAreaSelect";
            this.lstAreaSelect.Size = new System.Drawing.Size(207, 312);
            this.lstAreaSelect.TabIndex = 0;
            this.lstAreaSelect.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(24, 517);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 29);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(1012, 395);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(94, 29);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack!";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(124, 517);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(94, 29);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtAttack
            // 
            this.txtAttack.Location = new System.Drawing.Point(994, 362);
            this.txtAttack.Name = "txtAttack";
            this.txtAttack.Size = new System.Drawing.Size(126, 27);
            this.txtAttack.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Attack to(number):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(749, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Your Areas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(956, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enemie\'s Areas";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "1-Mordovia",
            "2-Chuvashia",
            "3-Man El",
            "4- Udmurtia",
            "5- Permic Republic",
            "6- Volga German Republic",
            "7- Tataristan",
            "8- Bashkortostan",
            "9- Republic of Chelyabinsk",
            "10- Adygeya",
            "11- North Caucasian Fed.",
            "12- Kalmykia",
            "13- Khakassia",
            "14- Tannu- Tuva"});
            this.listBox1.Location = new System.Drawing.Point(925, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 304);
            this.listBox1.TabIndex = 13;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(700, 360);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(94, 29);
            this.btnSelect.TabIndex = 14;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalHomeworkServer.Properties.Resources.Screenshot_2022_01_11_170051;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 344);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(24, 384);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(296, 127);
            this.txtInfo.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1123, 565);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAttack);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lstAreaSelect);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private CheckedListBox lstAreaSelect;
        private Button btnConnect;
        private Button btnAttack;
        private Button btnDisconnect;
        private TextBox txtAttack;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button btnSelect;
        private TextBox txtInfo;
        private byte[] data = new byte[1024];
        private int size = 1024;
        private Socket server;

    }
}