namespace ChatAppD2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_send = new System.Windows.Forms.Button();
            this.text_message = new System.Windows.Forms.TextBox();
            this.text_gname = new System.Windows.Forms.TextBox();
            this.btn_join = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_sendgroup = new System.Windows.Forms.Button();
            this.lb_message = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(187, 71);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // text_message
            // 
            this.text_message.Location = new System.Drawing.Point(70, 74);
            this.text_message.Name = "text_message";
            this.text_message.Size = new System.Drawing.Size(100, 20);
            this.text_message.TabIndex = 2;
            // 
            // text_gname
            // 
            this.text_gname.Location = new System.Drawing.Point(70, 103);
            this.text_gname.Name = "text_gname";
            this.text_gname.Size = new System.Drawing.Size(100, 20);
            this.text_gname.TabIndex = 3;
            // 
            // btn_join
            // 
            this.btn_join.Location = new System.Drawing.Point(187, 100);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(75, 23);
            this.btn_join.TabIndex = 4;
            this.btn_join.Text = "join";
            this.btn_join.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Group Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(187, 10);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 8;
            // 
            // btn_sendgroup
            // 
            this.btn_sendgroup.Location = new System.Drawing.Point(88, 140);
            this.btn_sendgroup.Name = "btn_sendgroup";
            this.btn_sendgroup.Size = new System.Drawing.Size(129, 23);
            this.btn_sendgroup.TabIndex = 9;
            this.btn_sendgroup.Text = "send to Group";
            this.btn_sendgroup.UseVisualStyleBackColor = true;
            // 
            // lb_message
            // 
            this.lb_message.FormattingEnabled = true;
            this.lb_message.Location = new System.Drawing.Point(44, 194);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(323, 134);
            this.lb_message.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.btn_sendgroup);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.text_gname);
            this.Controls.Add(this.text_message);
            this.Controls.Add(this.btn_send);
            this.Name = "Form1";
            this.Text = "text_name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox text_message;
        private System.Windows.Forms.TextBox text_gname;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_sendgroup;
        private System.Windows.Forms.ListBox lb_message;
    }
}

