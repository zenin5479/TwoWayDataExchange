using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TwoWayDataExchange
{
   public partial class FormOne : Form
   {
      [DllImport("kernel32.dll")]
      private static extern bool AllocConsole();

      [DllImport("kernel32.dll")]
      private static extern bool FreeConsole();

      public FormOne()
      {
         InitializeComponent();

         CreateUI();

         // Подключаем консоль к процессу
         AllocConsole();
         Console.WriteLine("=== Калькулятор факториала ===");
         Console.WriteLine("Введите число в форму и нажмите кнопку.");
         Console.WriteLine("Здесь будут отображаться шаги вычисления.\n");
      }

      private void CreateUI()
      {
         this.Text = "Факториал через консоль";
         this.Size = new System.Drawing.Size(400, 200);
         this.FormClosing += Form1_FormClosing;

         // Поле для ввода числа
         Label lblPrompt = new Label
         {
            Text = "Введите целое число (0..20):",
            Location = new System.Drawing.Point(30, 30),
            AutoSize = true
         };
      }

      private void btnCalc_Click(object sender, EventArgs e)
      {

      }
   }
}