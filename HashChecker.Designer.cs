namespace Hash_Checker
{
    partial class Hash_Match
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
            this.txtloc = new System.Windows.Forms.TextBox();
            this.label_File = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label_MD5 = new System.Windows.Forms.Label();
            this.label_SHA256 = new System.Windows.Forms.Label();
            this.textSHA256 = new System.Windows.Forms.TextBox();
            this.textMD5 = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.hash = new System.Windows.Forms.Button();
            this.textSHA1 = new System.Windows.Forms.TextBox();
            this.label_SHA1 = new System.Windows.Forms.Label();
            this.label_hash = new System.Windows.Forms.Label();
            this.texthash = new System.Windows.Forms.TextBox();
            this.match = new System.Windows.Forms.Label();
            this.copy1 = new System.Windows.Forms.Button();
            this.copy2 = new System.Windows.Forms.Button();
            this.copy3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtloc
            // 
            this.txtloc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtloc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtloc.Location = new System.Drawing.Point(83, 12);
            this.txtloc.Name = "txtloc";
            this.txtloc.Size = new System.Drawing.Size(509, 20);
            this.txtloc.TabIndex = 0;
            // 
            // label_File
            // 
            this.label_File.AutoSize = true;
            this.label_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_File.Location = new System.Drawing.Point(12, 13);
            this.label_File.Name = "label_File";
            this.label_File.Size = new System.Drawing.Size(30, 17);
            this.label_File.TabIndex = 1;
            this.label_File.Text = "File";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(598, 10);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "• • •";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label_MD5
            // 
            this.label_MD5.AutoSize = true;
            this.label_MD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_MD5.Location = new System.Drawing.Point(12, 81);
            this.label_MD5.Name = "label_MD5";
            this.label_MD5.Size = new System.Drawing.Size(37, 17);
            this.label_MD5.TabIndex = 3;
            this.label_MD5.Text = "MD5";
            // 
            // label_SHA256
            // 
            this.label_SHA256.AutoSize = true;
            this.label_SHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_SHA256.Location = new System.Drawing.Point(12, 133);
            this.label_SHA256.Name = "label_SHA256";
            this.label_SHA256.Size = new System.Drawing.Size(60, 17);
            this.label_SHA256.TabIndex = 4;
            this.label_SHA256.Text = "SHA256";
            // 
            // textSHA256
            // 
            this.textSHA256.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textSHA256.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textSHA256.Location = new System.Drawing.Point(83, 130);
            this.textSHA256.Name = "textSHA256";
            this.textSHA256.ReadOnly = true;
            this.textSHA256.Size = new System.Drawing.Size(509, 20);
            this.textSHA256.TabIndex = 5;
            // 
            // textMD5
            // 
            this.textMD5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textMD5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textMD5.Location = new System.Drawing.Point(83, 81);
            this.textMD5.Name = "textMD5";
            this.textMD5.ReadOnly = true;
            this.textMD5.Size = new System.Drawing.Size(509, 20);
            this.textMD5.TabIndex = 6;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "ofdFile";
            // 
            // hash
            // 
            this.hash.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.hash.Location = new System.Drawing.Point(248, 166);
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(107, 32);
            this.hash.TabIndex = 7;
            this.hash.Text = "Verify Hash";
            this.hash.UseVisualStyleBackColor = false;
            this.hash.Click += new System.EventHandler(this.Hash_Click);
            // 
            // textSHA1
            // 
            this.textSHA1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textSHA1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textSHA1.Location = new System.Drawing.Point(83, 106);
            this.textSHA1.Name = "textSHA1";
            this.textSHA1.ReadOnly = true;
            this.textSHA1.Size = new System.Drawing.Size(509, 20);
            this.textSHA1.TabIndex = 8;
            // 
            // label_SHA1
            // 
            this.label_SHA1.AutoSize = true;
            this.label_SHA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_SHA1.Location = new System.Drawing.Point(12, 107);
            this.label_SHA1.Name = "label_SHA1";
            this.label_SHA1.Size = new System.Drawing.Size(44, 17);
            this.label_SHA1.TabIndex = 9;
            this.label_SHA1.Text = "SHA1";
            // 
            // label_hash
            // 
            this.label_hash.AutoSize = true;
            this.label_hash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_hash.Location = new System.Drawing.Point(12, 39);
            this.label_hash.Name = "label_hash";
            this.label_hash.Size = new System.Drawing.Size(41, 17);
            this.label_hash.TabIndex = 11;
            this.label_hash.Text = "Hash";
            // 
            // texthash
            // 
            this.texthash.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.texthash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texthash.Location = new System.Drawing.Point(83, 38);
            this.texthash.Name = "texthash";
            this.texthash.Size = new System.Drawing.Size(509, 20);
            this.texthash.TabIndex = 10;
            // 
            // match
            // 
            this.match.AutoSize = true;
            this.match.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.match.Location = new System.Drawing.Point(516, 173);
            this.match.Name = "match";
            this.match.Size = new System.Drawing.Size(0, 25);
            this.match.TabIndex = 12;
            // 
            // copy1
            // 
            this.copy1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copy1.Location = new System.Drawing.Point(598, 79);
            this.copy1.Name = "copy1";
            this.copy1.Size = new System.Drawing.Size(75, 23);
            this.copy1.TabIndex = 15;
            this.copy1.Text = "Copy Hash";
            this.copy1.UseVisualStyleBackColor = false;
            this.copy1.Click += new System.EventHandler(this.Copy1_Click);
            // 
            // copy2
            // 
            this.copy2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copy2.Location = new System.Drawing.Point(598, 104);
            this.copy2.Name = "copy2";
            this.copy2.Size = new System.Drawing.Size(75, 23);
            this.copy2.TabIndex = 16;
            this.copy2.Text = "Copy Hash";
            this.copy2.UseVisualStyleBackColor = false;
            this.copy2.Click += new System.EventHandler(this.Copy2_Click);
            // 
            // copy3
            // 
            this.copy3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copy3.Location = new System.Drawing.Point(598, 130);
            this.copy3.Name = "copy3";
            this.copy3.Size = new System.Drawing.Size(75, 23);
            this.copy3.TabIndex = 17;
            this.copy3.Text = "Copy Hash";
            this.copy3.UseVisualStyleBackColor = false;
            this.copy3.Click += new System.EventHandler(this.Copy3_Click);
            // 
            // Hash_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(681, 211);
            this.Controls.Add(this.copy3);
            this.Controls.Add(this.copy2);
            this.Controls.Add(this.copy1);
            this.Controls.Add(this.match);
            this.Controls.Add(this.label_hash);
            this.Controls.Add(this.texthash);
            this.Controls.Add(this.label_SHA1);
            this.Controls.Add(this.textSHA1);
            this.Controls.Add(this.hash);
            this.Controls.Add(this.textMD5);
            this.Controls.Add(this.textSHA256);
            this.Controls.Add(this.label_SHA256);
            this.Controls.Add(this.label_MD5);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label_File);
            this.Controls.Add(this.txtloc);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Hash_Match";
            this.Text = "Hash Checker";
            this.Load += new System.EventHandler(this.FormHashChecker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtloc;
        private System.Windows.Forms.Label label_File;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label_MD5;
        private System.Windows.Forms.Label label_SHA256;
        private System.Windows.Forms.TextBox textSHA256;
        private System.Windows.Forms.TextBox textMD5;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Button hash;
        private System.Windows.Forms.TextBox textSHA1;
        private System.Windows.Forms.Label label_SHA1;
        private System.Windows.Forms.Label label_hash;
        private System.Windows.Forms.TextBox texthash;
        private System.Windows.Forms.Label match;
        private System.Windows.Forms.Button copy1;
        private System.Windows.Forms.Button copy2;
        private System.Windows.Forms.Button copy3;

    }
}

