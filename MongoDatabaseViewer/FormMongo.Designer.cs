namespace MongoDatabaseViewer
{
    partial class FormMongo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMongo));
            this.btnGetDatabase = new System.Windows.Forms.Button();
            this.lvwDatabase = new System.Windows.Forms.ListView();
            this.header1 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnGetDatabase
            // 
            this.btnGetDatabase.Location = new System.Drawing.Point(12, 12);
            this.btnGetDatabase.Name = "btnGetDatabase";
            this.btnGetDatabase.Size = new System.Drawing.Size(100, 31);
            this.btnGetDatabase.TabIndex = 0;
            this.btnGetDatabase.Text = "GetDatabase";
            this.btnGetDatabase.UseVisualStyleBackColor = true;
            this.btnGetDatabase.Click += new System.EventHandler(this.btnGetDatabase_Click);
            // 
            // lvwDatabase
            // 
            this.lvwDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDatabase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header1});
            this.lvwDatabase.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwDatabase.FullRowSelect = true;
            this.lvwDatabase.GridLines = true;
            this.lvwDatabase.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwDatabase.Location = new System.Drawing.Point(12, 49);
            this.lvwDatabase.Name = "lvwDatabase";
            this.lvwDatabase.Size = new System.Drawing.Size(1094, 578);
            this.lvwDatabase.TabIndex = 1;
            this.lvwDatabase.UseCompatibleStateImageBehavior = false;
            this.lvwDatabase.View = System.Windows.Forms.View.Details;
            // 
            // header1
            // 
            this.header1.Text = "Database Stuff";
            this.header1.Width = 2500;
            // 
            // FormMongo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 639);
            this.Controls.Add(this.lvwDatabase);
            this.Controls.Add(this.btnGetDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMongo";
            this.Text = "Mongo Utility";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGetDatabase;
        private ListView lvwDatabase;
        private ColumnHeader header1;
    }
}