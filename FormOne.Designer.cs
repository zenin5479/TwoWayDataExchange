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
         TextBoxNumber = new System.Windows.Forms.TextBox();
         LabelResult = new System.Windows.Forms.Label();
         ButtonCalculator = new System.Windows.Forms.Button();
         LabelPrompt = new System.Windows.Forms.Label();
         SuspendLayout();
         // 
         // TextBoxNumber
         // 
         TextBoxNumber.Location = new System.Drawing.Point(12, 27);
         TextBoxNumber.Name = "TextBoxNumber";
         TextBoxNumber.Size = new System.Drawing.Size(150, 23);
         TextBoxNumber.TabIndex = 0;
         // 
         // LabelResult
         // 
         LabelResult.AutoSize = true;
         LabelResult.Location = new System.Drawing.Point(12, 82);
         LabelResult.Name = "LabelResult";
         LabelResult.Size = new System.Drawing.Size(66, 15);
         LabelResult.TabIndex = 1;
         LabelResult.Text = "Результат: ";
         // 
         // ButtonCalculator
         // 
         ButtonCalculator.Location = new System.Drawing.Point(12, 56);
         ButtonCalculator.Name = "ButtonCalculator";
         ButtonCalculator.Size = new System.Drawing.Size(150, 23);
         ButtonCalculator.TabIndex = 2;
         ButtonCalculator.Text = "Вычислить факториал";
         ButtonCalculator.UseVisualStyleBackColor = true;
         ButtonCalculator.Click += ButtonCalculator_Click;
         // 
         // LabelPrompt
         // 
         LabelPrompt.AutoSize = true;
         LabelPrompt.Location = new System.Drawing.Point(12, 9);
         LabelPrompt.Name = "LabelPrompt";
         LabelPrompt.Size = new System.Drawing.Size(161, 15);
         LabelPrompt.TabIndex = 3;
         LabelPrompt.Text = "Введите целое число (0..20):";
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(314, 111);
         Controls.Add(LabelPrompt);
         Controls.Add(ButtonCalculator);
         Controls.Add(LabelResult);
         Controls.Add(TextBoxNumber);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Факториал через консоль";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox TextBoxNumber;
      private System.Windows.Forms.Label LabelResult;
      private System.Windows.Forms.Button ButtonCalculator;
      private System.Windows.Forms.Label LabelPrompt;
   }
}