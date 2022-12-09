
namespace Cherry_Injecter
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
            this.Menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.btnInject = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.btnBtools = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTPTo = new System.Windows.Forms.TextBox();
            this.btnTPTo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.inputScript = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Menu.BackColor = System.Drawing.Color.Maroon;
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.Exit);
            this.Menu.Location = new System.Drawing.Point(1, -1);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(288, 38);
            this.Menu.TabIndex = 0;
            this.Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down);
            this.Menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            this.Menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cherry Executer";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(245, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(39, 38);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnInject
            // 
            this.btnInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInject.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInject.Location = new System.Drawing.Point(1, 263);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(142, 50);
            this.btnInject.TabIndex = 19;
            this.btnInject.Text = "Attach";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExecute.Location = new System.Drawing.Point(149, 263);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(140, 50);
            this.btnExecute.TabIndex = 20;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeed.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSpeed.Location = new System.Drawing.Point(1, 319);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(142, 42);
            this.btnSpeed.TabIndex = 21;
            this.btnSpeed.Text = "Fast Walk";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // btnBtools
            // 
            this.btnBtools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBtools.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBtools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBtools.Location = new System.Drawing.Point(149, 319);
            this.btnBtools.Name = "btnBtools";
            this.btnBtools.Size = new System.Drawing.Size(140, 42);
            this.btnBtools.TabIndex = 22;
            this.btnBtools.Text = "BTools";
            this.btnBtools.UseVisualStyleBackColor = true;
            this.btnBtools.Click += new System.EventHandler(this.btnBtools_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(-3, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "TP To:";
            // 
            // inputTPTo
            // 
            this.inputTPTo.BackColor = System.Drawing.Color.Black;
            this.inputTPTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTPTo.Font = new System.Drawing.Font("Arial", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTPTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputTPTo.Location = new System.Drawing.Point(67, 375);
            this.inputTPTo.Multiline = true;
            this.inputTPTo.Name = "inputTPTo";
            this.inputTPTo.Size = new System.Drawing.Size(143, 21);
            this.inputTPTo.TabIndex = 24;
            this.inputTPTo.Text = "PlrUsername";
            // 
            // btnTPTo
            // 
            this.btnTPTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTPTo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTPTo.Location = new System.Drawing.Point(216, 367);
            this.btnTPTo.Name = "btnTPTo";
            this.btnTPTo.Size = new System.Drawing.Size(73, 36);
            this.btnTPTo.TabIndex = 25;
            this.btnTPTo.Text = "Go";
            this.btnTPTo.UseVisualStyleBackColor = true;
            this.btnTPTo.Click += new System.EventHandler(this.btnTPTo_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(216, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "More";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputScript
            // 
            this.inputScript.BackColor = System.Drawing.Color.Black;
            this.inputScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputScript.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputScript.Location = new System.Drawing.Point(1, 43);
            this.inputScript.Name = "inputScript";
            this.inputScript.Size = new System.Drawing.Size(288, 214);
            this.inputScript.TabIndex = 27;
            this.inputScript.Text = "--paste your script here\nprint(\"Hello from WRD API!\")";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 410);
            this.panel1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(246, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(291, 450);
            this.Controls.Add(this.inputScript);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTPTo);
            this.Controls.Add(this.inputTPTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBtools);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Button btnBtools;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTPTo;
        private System.Windows.Forms.Button btnTPTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox inputScript;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

