namespace WinVowel
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
            this.VowelClick = new System.Windows.Forms.Button();
            this.ConClick = new System.Windows.Forms.Button();
            this.NumClick = new System.Windows.Forms.Button();
            this.SpaceClick = new System.Windows.Forms.Button();
            this.InputUser = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ConCount = new System.Windows.Forms.TextBox();
            this.NumCount = new System.Windows.Forms.TextBox();
            this.SpaceCount = new System.Windows.Forms.TextBox();
            this.EnterTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VowelClick
            // 
            this.VowelClick.Location = new System.Drawing.Point(434, 72);
            this.VowelClick.Margin = new System.Windows.Forms.Padding(2);
            this.VowelClick.Name = "VowelClick";
            this.VowelClick.Size = new System.Drawing.Size(92, 63);
            this.VowelClick.TabIndex = 1;
            this.VowelClick.Text = "Vowels";
            this.VowelClick.UseVisualStyleBackColor = true;
            this.VowelClick.Click += new System.EventHandler(this.VowelClick_Click);
            // 
            // ConClick
            // 
            this.ConClick.Location = new System.Drawing.Point(434, 139);
            this.ConClick.Margin = new System.Windows.Forms.Padding(2);
            this.ConClick.Name = "ConClick";
            this.ConClick.Size = new System.Drawing.Size(92, 63);
            this.ConClick.TabIndex = 2;
            this.ConClick.Text = "Consonants";
            this.ConClick.UseVisualStyleBackColor = true;
            this.ConClick.Click += new System.EventHandler(this.button3_Click);
            // 
            // NumClick
            // 
            this.NumClick.Location = new System.Drawing.Point(434, 205);
            this.NumClick.Margin = new System.Windows.Forms.Padding(2);
            this.NumClick.Name = "NumClick";
            this.NumClick.Size = new System.Drawing.Size(92, 63);
            this.NumClick.TabIndex = 3;
            this.NumClick.Text = "Numbers";
            this.NumClick.UseVisualStyleBackColor = true;
            this.NumClick.Click += new System.EventHandler(this.NumClick_Click);
            // 
            // SpaceClick
            // 
            this.SpaceClick.Location = new System.Drawing.Point(434, 272);
            this.SpaceClick.Margin = new System.Windows.Forms.Padding(2);
            this.SpaceClick.Name = "SpaceClick";
            this.SpaceClick.Size = new System.Drawing.Size(92, 63);
            this.SpaceClick.TabIndex = 4;
            this.SpaceClick.Text = "Spaces";
            this.SpaceClick.UseVisualStyleBackColor = true;
            this.SpaceClick.Click += new System.EventHandler(this.SpaceClick_Click);
            // 
            // InputUser
            // 
            this.InputUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUser.Location = new System.Drawing.Point(11, 72);
            this.InputUser.Margin = new System.Windows.Forms.Padding(2);
            this.InputUser.Multiline = true;
            this.InputUser.Name = "InputUser";
            this.InputUser.Size = new System.Drawing.Size(419, 265);
            this.InputUser.TabIndex = 5;
            this.InputUser.TextChanged += new System.EventHandler(this.InputUser_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(530, 72);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 65);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ConCount
            // 
            this.ConCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConCount.Location = new System.Drawing.Point(530, 139);
            this.ConCount.Margin = new System.Windows.Forms.Padding(2);
            this.ConCount.Multiline = true;
            this.ConCount.Name = "ConCount";
            this.ConCount.Size = new System.Drawing.Size(104, 65);
            this.ConCount.TabIndex = 7;
            this.ConCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConCount.TextChanged += new System.EventHandler(this.ConCount_TextChanged);
            // 
            // NumCount
            // 
            this.NumCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCount.Location = new System.Drawing.Point(530, 205);
            this.NumCount.Margin = new System.Windows.Forms.Padding(2);
            this.NumCount.Multiline = true;
            this.NumCount.Name = "NumCount";
            this.NumCount.Size = new System.Drawing.Size(104, 65);
            this.NumCount.TabIndex = 8;
            this.NumCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumCount.TextChanged += new System.EventHandler(this.NumCount_TextChanged);
            // 
            // SpaceCount
            // 
            this.SpaceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpaceCount.Location = new System.Drawing.Point(530, 272);
            this.SpaceCount.Margin = new System.Windows.Forms.Padding(2);
            this.SpaceCount.Multiline = true;
            this.SpaceCount.Name = "SpaceCount";
            this.SpaceCount.Size = new System.Drawing.Size(104, 65);
            this.SpaceCount.TabIndex = 9;
            this.SpaceCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SpaceCount.TextChanged += new System.EventHandler(this.SpaceCount_TextChanged);
            // 
            // EnterTextLabel
            // 
            this.EnterTextLabel.AutoSize = true;
            this.EnterTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterTextLabel.Location = new System.Drawing.Point(87, 39);
            this.EnterTextLabel.Name = "EnterTextLabel";
            this.EnterTextLabel.Size = new System.Drawing.Size(251, 31);
            this.EnterTextLabel.TabIndex = 10;
            this.EnterTextLabel.Text = "Enter your text here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 348);
            this.Controls.Add(this.EnterTextLabel);
            this.Controls.Add(this.SpaceCount);
            this.Controls.Add(this.NumCount);
            this.Controls.Add(this.ConCount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.InputUser);
            this.Controls.Add(this.SpaceClick);
            this.Controls.Add(this.NumClick);
            this.Controls.Add(this.ConClick);
            this.Controls.Add(this.VowelClick);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Your Text!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button VowelClick;
        private System.Windows.Forms.Button ConClick;
        private System.Windows.Forms.Button NumClick;
        private System.Windows.Forms.Button SpaceClick;
        private System.Windows.Forms.TextBox InputUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ConCount;
        private System.Windows.Forms.TextBox NumCount;
        private System.Windows.Forms.TextBox SpaceCount;
        private System.Windows.Forms.Label EnterTextLabel;
    }
}

