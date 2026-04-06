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
         Console.WriteLine("Введите число в форму и нажмите кнопку");
         Console.WriteLine("Здесь будут отображаться шаги вычисления\n");
      }

      private void CreateUI()
      {
         Text = "Факториал через консоль";
         FormClosing += Form1_FormClosing;
      }

      private void btnCalc_Click(object sender, EventArgs e)
      {
         if (!int.TryParse(txtNumber.Text, out int n) || n < 0)
         {
            MessageBox.Show("Введите неотрицательное целое число.", "Ошибка");
            return;
         }

         // Вычисление факториала с выводом в консоль
         long result = FactorialWithConsoleLog(n);

         // Отображаем результат в форме
         lblResult.Text = string.Format("Результат: {0}! = {1}", n, result);
      }

      // Вычисляет факториал и выводит промежуточные шаги в консоль
      private long FactorialWithConsoleLog(int n)
      {
         if (n == 0 || n == 1)
         {
            Console.WriteLine("Факториал {0}! = 1", n);
            return 1;
         }

         long fact = 1;
         Console.WriteLine("Вычисляем {0}! :", n);

         for (int i = 2; i <= n; i++)
         {
            fact *= i;
            Console.WriteLine("  Шаг {0}: умножаем на {1} -> текущий результат = {2}", i - 1, i, fact);
         }

         Console.WriteLine("\nРезультат: {0}! = {1}\n", n, fact);
         return fact;
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         // Освобождаем консоль при закрытии формы
         FreeConsole();
      }
   }
}