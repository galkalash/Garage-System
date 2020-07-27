using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.WindowsUI
{
    public class MinutesToCharg : Form
    {

        public MinutesToCharg()
        {
            initializeComponent();
        }


        public Button _buttonOK
        {
            get
            {
                return buttonOK;
            }
        }

        public string _textBoxMinuteToCharg
        {
            get
            {
                return textBoxMinuteToCharg.Text;
            }
        }

        private void initializeComponent()
        {

            labelMinuteToCharg = new System.Windows.Forms.Label();
            textBoxMinuteToCharg = new System.Windows.Forms.TextBox();
            buttonCancel = new System.Windows.Forms.Button();
            buttonOK = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelMinuteToCharg
            // 
            labelMinuteToCharg.AutoSize = true;
            labelMinuteToCharg.Font = new System.Drawing.Font("Narkisim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            labelMinuteToCharg.Location = new System.Drawing.Point(60, 59);
            labelMinuteToCharg.Name = "labelMinuteToCharg";
            labelMinuteToCharg.Size = new System.Drawing.Size(140, 19);
            labelMinuteToCharg.TabIndex = 0;
            labelMinuteToCharg.Text = "Minutes:";
            // 
            // textBoxMinuteToCharg
            // 
            textBoxMinuteToCharg.Location = new System.Drawing.Point(153, 59);
            textBoxMinuteToCharg.Name = "textBoxMinuteToCharg";
            textBoxMinuteToCharg.Size = new System.Drawing.Size(190, 22);
            textBoxMinuteToCharg.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(287, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 31);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += ButtonCancel_Click;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(153, 136);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 31);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;

            this.AcceptButton = this.buttonOK;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = this.buttonCancel;
            ClientSize = new System.Drawing.Size(411, 182);
            Controls.Add(this.buttonOK);
            Controls.Add(this.buttonCancel);
            Controls.Add(this.labelMinuteToCharg);
            Controls.Add(this.textBoxMinuteToCharg);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VehicleTypesForm";
            Text = "Vehicle Types";
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private System.Windows.Forms.Label labelMinuteToCharg;
        private System.Windows.Forms.TextBox textBoxMinuteToCharg;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}
