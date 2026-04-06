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
         lblResult = new System.Windows.Forms.Label();
         btnCalc = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // txtNumber
         // 
         txtNumber.Location = new System.Drawing.Point(12, 12);
         txtNumber.Name = "txtNumber";
         txtNumber.Size = new System.Drawing.Size(100, 23);
         txtNumber.TabIndex = 0;
         // 
         // lblResult
         // 
         lblResult.AutoSize = true;
         lblResult.Location = new System.Drawing.Point(144, 198);
         lblResult.Name = "lblResult";
         lblResult.Size = new System.Drawing.Size(38, 15);
         lblResult.TabIndex = 1;
         lblResult.Text = "label1";
         // 
         // btnCalc
         // 
         btnCalc.Location = new System.Drawing.Point(25, 74);
         btnCalc.Name = "btnCalc";
         btnCalc.Size = new System.Drawing.Size(144, 23);
         btnCalc.TabIndex = 2;
         btnCalc.Text = "Вычислить факториал";
         btnCalc.UseVisualStyleBackColor = true;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(484, 361);
         Controls.Add(btnCalc);
         Controls.Add(lblResult);
         Controls.Add(txtNumber);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Двусторонний обмен между Windows Forms и консолью ";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox txtNumber;
      private System.Windows.Forms.Label lblResult;
      private System.Windows.Forms.Button btnCalc;
   }
}