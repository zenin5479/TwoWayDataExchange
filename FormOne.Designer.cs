namespace TwoWayDataExchange
{
   partial class FormOne
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
         txtNumber = new System.Windows.Forms.TextBox();
         label1 = new System.Windows.Forms.Label();
         button1 = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // txtNumber
         // 
         txtNumber.Location = new System.Drawing.Point(86, 109);
         txtNumber.Name = "txtNumber";
         txtNumber.Size = new System.Drawing.Size(100, 23);
         txtNumber.TabIndex = 0;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new System.Drawing.Point(144, 198);
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size(38, 15);
         label1.TabIndex = 1;
         label1.Text = "label1";
         // 
         // button1
         // 
         button1.Location = new System.Drawing.Point(105, 152);
         button1.Name = "button1";
         button1.Size = new System.Drawing.Size(75, 23);
         button1.TabIndex = 2;
         button1.Text = "button1";
         button1.UseVisualStyleBackColor = true;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(484, 361);
         Controls.Add(button1);
         Controls.Add(label1);
         Controls.Add(txtNumber);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Двусторонний обмен между Windows Forms и консолью ";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox txtNumber;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
   }
}