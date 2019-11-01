namespace FantasyPetStore
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DragonFeedInput = new System.Windows.Forms.TextBox();
            this.hydraPolishInput = new System.Windows.Forms.TextBox();
            this.griffonPelletInput = new System.Windows.Forms.TextBox();
            this.DragonfeedLabel = new System.Windows.Forms.Label();
            this.HydraPolishLabel = new System.Windows.Forms.Label();
            this.GriffonPeletLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(95, 376);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(101, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate Price";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DragonFeedInput
            // 
            this.DragonFeedInput.Location = new System.Drawing.Point(160, 69);
            this.DragonFeedInput.Name = "DragonFeedInput";
            this.DragonFeedInput.Size = new System.Drawing.Size(100, 20);
            this.DragonFeedInput.TabIndex = 2;
            // 
            // hydraPolishInput
            // 
            this.hydraPolishInput.Location = new System.Drawing.Point(160, 107);
            this.hydraPolishInput.Name = "hydraPolishInput";
            this.hydraPolishInput.Size = new System.Drawing.Size(100, 20);
            this.hydraPolishInput.TabIndex = 3;
            // 
            // griffonPelletInput
            // 
            this.griffonPelletInput.Location = new System.Drawing.Point(160, 146);
            this.griffonPelletInput.Name = "griffonPelletInput";
            this.griffonPelletInput.Size = new System.Drawing.Size(100, 20);
            this.griffonPelletInput.TabIndex = 4;
            // 
            // DragonfeedLabel
            // 
            this.DragonfeedLabel.AutoSize = true;
            this.DragonfeedLabel.Location = new System.Drawing.Point(54, 72);
            this.DragonfeedLabel.Name = "DragonfeedLabel";
            this.DragonfeedLabel.Size = new System.Drawing.Size(69, 13);
            this.DragonfeedLabel.TabIndex = 5;
            this.DragonfeedLabel.Text = "Dragon Feed";
            // 
            // HydraPolishLabel
            // 
            this.HydraPolishLabel.AutoSize = true;
            this.HydraPolishLabel.Location = new System.Drawing.Point(54, 110);
            this.HydraPolishLabel.Name = "HydraPolishLabel";
            this.HydraPolishLabel.Size = new System.Drawing.Size(66, 13);
            this.HydraPolishLabel.TabIndex = 6;
            this.HydraPolishLabel.Text = "Hydra Polish";
            // 
            // GriffonPeletLabel
            // 
            this.GriffonPeletLabel.AutoSize = true;
            this.GriffonPeletLabel.Location = new System.Drawing.Point(57, 146);
            this.GriffonPeletLabel.Name = "GriffonPeletLabel";
            this.GriffonPeletLabel.Size = new System.Drawing.Size(72, 13);
            this.GriffonPeletLabel.TabIndex = 7;
            this.GriffonPeletLabel.Text = "Griffon Pellets";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Location = new System.Drawing.Point(60, 239);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(200, 70);
            this.totalCostLabel.TabIndex = 8;
            this.totalCostLabel.Text = "Your Total Cost Is. . .";
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(95, 415);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(101, 23);
            this.receiptButton.TabIndex = 9;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.Location = new System.Drawing.Point(474, 29);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(268, 370);
            this.receiptLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.GriffonPeletLabel);
            this.Controls.Add(this.HydraPolishLabel);
            this.Controls.Add(this.DragonfeedLabel);
            this.Controls.Add(this.griffonPelletInput);
            this.Controls.Add(this.hydraPolishInput);
            this.Controls.Add(this.DragonFeedInput);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox DragonFeedInput;
        private System.Windows.Forms.TextBox hydraPolishInput;
        private System.Windows.Forms.TextBox griffonPelletInput;
        private System.Windows.Forms.Label DragonfeedLabel;
        private System.Windows.Forms.Label HydraPolishLabel;
        private System.Windows.Forms.Label GriffonPeletLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptLabel;
    }
}

