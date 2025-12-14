namespace KR
{
    partial class TCAdd
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label amount_PLabel;
            System.Windows.Forms.Label coeff_costLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label floorLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label townLabel;
            this.amount_PTextBox = new System.Windows.Forms.TextBox();
            this.coeff_costTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.floorTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            amount_PLabel = new System.Windows.Forms.Label();
            coeff_costLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            floorLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            townLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // amount_PLabel
            // 
            amount_PLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            amount_PLabel.AutoSize = true;
            amount_PLabel.Location = new System.Drawing.Point(39, 42);
            amount_PLabel.Name = "amount_PLabel";
            amount_PLabel.Size = new System.Drawing.Size(111, 25);
            amount_PLabel.TabIndex = 1;
            amount_PLabel.Text = "Amount P:";
            // 
            // coeff_costLabel
            // 
            coeff_costLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            coeff_costLabel.AutoSize = true;
            coeff_costLabel.Location = new System.Drawing.Point(39, 89);
            coeff_costLabel.Name = "coeff_costLabel";
            coeff_costLabel.Size = new System.Drawing.Size(115, 25);
            coeff_costLabel.TabIndex = 3;
            coeff_costLabel.Text = "Coeff cost:";
            // 
            // costLabel
            // 
            costLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(39, 135);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(62, 25);
            costLabel.TabIndex = 5;
            costLabel.Text = "Cost:";
            // 
            // floorLabel
            // 
            floorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            floorLabel.AutoSize = true;
            floorLabel.Location = new System.Drawing.Point(39, 182);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new System.Drawing.Size(67, 25);
            floorLabel.TabIndex = 7;
            floorLabel.Text = "Floor:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(39, 233);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(74, 25);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name:";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(39, 281);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(79, 25);
            statusLabel.TabIndex = 15;
            statusLabel.Text = "Status:";
            // 
            // townLabel
            // 
            townLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            townLabel.AutoSize = true;
            townLabel.Location = new System.Drawing.Point(39, 330);
            townLabel.Name = "townLabel";
            townLabel.Size = new System.Drawing.Size(70, 25);
            townLabel.TabIndex = 17;
            townLabel.Text = "Town:";
            // 
            // amount_PTextBox
            // 
            this.amount_PTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.amount_PTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Amount_P", true));
            this.amount_PTextBox.Location = new System.Drawing.Point(160, 39);
            this.amount_PTextBox.Name = "amount_PTextBox";
            this.amount_PTextBox.Size = new System.Drawing.Size(360, 31);
            this.amount_PTextBox.TabIndex = 2;
            // 
            // coeff_costTextBox
            // 
            this.coeff_costTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.coeff_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Coeff_cost", true));
            this.coeff_costTextBox.Location = new System.Drawing.Point(160, 86);
            this.coeff_costTextBox.Name = "coeff_costTextBox";
            this.coeff_costTextBox.Size = new System.Drawing.Size(360, 31);
            this.coeff_costTextBox.TabIndex = 4;
            // 
            // costTextBox
            // 
            this.costTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(160, 132);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(360, 31);
            this.costTextBox.TabIndex = 6;
            // 
            // floorTextBox
            // 
            this.floorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.floorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Floor", true));
            this.floorTextBox.Location = new System.Drawing.Point(160, 179);
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.Size = new System.Drawing.Size(360, 31);
            this.floorTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(160, 230);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(360, 31);
            this.nameTextBox.TabIndex = 14;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(160, 278);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(360, 31);
            this.statusTextBox.TabIndex = 16;
            // 
            // townTextBox
            // 
            this.townTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.townTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mallBindingSource, "Town", true));
            this.townTextBox.Location = new System.Drawing.Point(160, 327);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(360, 31);
            this.townTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(107, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 54);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mallBindingSource
            // 
            this.mallBindingSource.DataSource = typeof(KR.FolderModel.Mall);
            // 
            // TCAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(558, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(amount_PLabel);
            this.Controls.Add(this.amount_PTextBox);
            this.Controls.Add(coeff_costLabel);
            this.Controls.Add(this.coeff_costTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(floorLabel);
            this.Controls.Add(this.floorTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(townLabel);
            this.Controls.Add(this.townTextBox);
            this.Name = "TCAdd";
            this.Text = "TCAdd";
            this.Load += new System.EventHandler(this.TCAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mallBindingSource;
        private System.Windows.Forms.TextBox amount_PTextBox;
        private System.Windows.Forms.TextBox coeff_costTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox floorTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.Button button1;
    }
}