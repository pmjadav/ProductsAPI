namespace ProductClient
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
            this.btnGetAllProducts = new System.Windows.Forms.Button();
            this.btnGetProd = new System.Windows.Forms.Button();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAllProducts = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetAllProducts
            // 
            this.btnGetAllProducts.Location = new System.Drawing.Point(78, 32);
            this.btnGetAllProducts.Name = "btnGetAllProducts";
            this.btnGetAllProducts.Size = new System.Drawing.Size(147, 23);
            this.btnGetAllProducts.TabIndex = 0;
            this.btnGetAllProducts.Text = "List All Products";
            this.btnGetAllProducts.UseVisualStyleBackColor = true;
            this.btnGetAllProducts.Click += new System.EventHandler(this.btnGetAllProducts_Click);
            // 
            // btnGetProd
            // 
            this.btnGetProd.Location = new System.Drawing.Point(235, 34);
            this.btnGetProd.Name = "btnGetProd";
            this.btnGetProd.Size = new System.Drawing.Size(155, 22);
            this.btnGetProd.TabIndex = 1;
            this.btnGetProd.Text = "Search Product by Id";
            this.btnGetProd.UseVisualStyleBackColor = true;
            this.btnGetProd.Click += new System.EventHandler(this.btnGetProd_Click);
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(33, 34);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(100, 20);
            this.txtProdId.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.txtProdId);
            this.groupBox1.Controls.Add(this.btnGetProd);
            this.groupBox1.Location = new System.Drawing.Point(362, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 373);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(33, 99);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(35, 13);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAllProducts);
            this.groupBox2.Controls.Add(this.btnGetAllProducts);
            this.groupBox2.Location = new System.Drawing.Point(13, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 373);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // lblAllProducts
            // 
            this.lblAllProducts.AutoSize = true;
            this.lblAllProducts.Location = new System.Drawing.Point(24, 99);
            this.lblAllProducts.Name = "lblAllProducts";
            this.lblAllProducts.Size = new System.Drawing.Size(35, 13);
            this.lblAllProducts.TabIndex = 1;
            this.lblAllProducts.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllProducts;
        private System.Windows.Forms.Button btnGetProd;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblAllProducts;
    }
}

