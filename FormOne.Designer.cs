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
         lblPrompt = new System.Windows.Forms.Label();
         SuspendLayout();
         // 
         // txtNumber
         // 
         txtNumber.Location = new System.Drawing.Point(12, 27);
         txtNumber.Name = "txtNumber";
         txtNumber.Size = new System.Drawing.Size(144, 23);
         txtNumber.TabIndex = 0;
         // 
         // lblResult
         // 
         lblResult.AutoSize = true;
         lblResult.Location = new System.Drawing.Point(12, 82);
         lblResult.Name = "lblResult";
         lblResult.Size = new System.Drawing.Size(66, 15);
         lblResult.TabIndex = 1;
         lblResult.Text = "Результат: ";
         // 
         // btnCalc
         // 
         btnCalc.Location = new System.Drawing.Point(12, 56);
         btnCalc.Name = "btnCalc";
         btnCalc.Size = new System.Drawing.Size(150, 23);
         btnCalc.TabIndex = 2;
         btnCalc.Text = "Вычислить факториал";
         btnCalc.UseVisualStyleBackColor = true;
         btnCalc.Click += btnCalc_Click;
         // 
         // lblPrompt
         // 
         lblPrompt.AutoSize = true;
         lblPrompt.Location = new System.Drawing.Point(12, 9);
         lblPrompt.Name = "lblPrompt";
         lblPrompt.Size = new System.Drawing.Size(161, 15);
         lblPrompt.TabIndex = 3;
         lblPrompt.Text = "Введите целое число (0..20):";
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(314, 111);
         Controls.Add(lblPrompt);
         Controls.Add(btnCalc);
         Controls.Add(lblResult);
         Controls.Add(txtNumber);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Факториал через консоль";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox txtNumber;
      private System.Windows.Forms.Label lblResult;
      private System.Windows.Forms.Button btnCalc;
      private System.Windows.Forms.Label lblPrompt;
   }
}