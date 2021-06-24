
namespace KeysInteractionSample {
    partial class NumPadForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEdit1.Location = new System.Drawing.Point(12, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(214, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svgImageBox1.Location = new System.Drawing.Point(12, 32);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(214, 244);
            this.svgImageBox1.SvgImage = global::KeysInteractionSample.Properties.Resources.Keys;
            this.svgImageBox1.TabIndex = 1;
            this.svgImageBox1.Text = "svgImageBox1";
            this.svgImageBox1.QueryHoveredItem += new DevExpress.XtraEditors.SvgImageQueryHoveredItemEventHandler(this.OnQueryHoveredItem);
            this.svgImageBox1.ItemPress += new DevExpress.XtraEditors.SvgImageItemEventHandler(this.OnItemPress);
            this.svgImageBox1.QueryUniqueItemId += new DevExpress.XtraEditors.QueryUniqueItemIdEventHandler(this.OnQueryUniqueItemId);
            // 
            // NumPadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 288);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.textEdit1);
            this.MinimumSize = new System.Drawing.Size(240, 320);
            this.Name = "NumPadForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "SVG NumPad (CS)";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}

