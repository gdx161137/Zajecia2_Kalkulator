using System.CodeDom;
using System.Diagnostics;

namespace Zajecia2_Kalkulator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operatorUsed = "";
        bool isOperatorUsed = false;
        const int InitializationLimitTime = 1; // 2 sekundy

        public Form1()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            InitializeComponent();

            stopwatch.Stop();
            long elapsedTime = stopwatch.ElapsedMilliseconds;

            if (elapsedTime > InitializationLimitTime)
            {
                LogInitializationTime(elapsedTime);
            }
        }

        private void LogInitializationTime(long elapsedTime)
        {
            string source = "MyCalculatorApp";
            string log = "Application";
            string eventMessage = $"Zainicjowanie aplikazji zaje³o {elapsedTime} co jest wiêksze od przyjêtego limitu {InitializationLimitTime} ms";

            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }

            EventLog.WriteEntry(source, eventMessage, EventLogEntryType.Warning);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClickNumber(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || isOperatorUsed)
            {
                textBox_Result.Clear();
            }
            isOperatorUsed = false;
            Button button = (Button)sender;

            if (button.Text == ",")
            {
                if (!textBox_Result.Text.Contains(","))
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }

            } 
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
        }

        private void buttonClickOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorUsed = button.Text;
            resultValue = double.Parse(textBox_Result.Text);
            isOperatorUsed = true;
            label_CurrentOperation.Text = resultValue + " " + operatorUsed;
            textBox_Result.Text = "0";
        }

        private void buttonClickClear(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            label_CurrentOperation.Text = null;
            operatorUsed = "";
            isOperatorUsed = false;
        }

        private void buttonClickSum(object sender, EventArgs e)
        {
            switch(operatorUsed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString(); 
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / double.Parse(textBox_Result.Text)).ToString();
                    break;
            }
            label_CurrentOperation.Text = null;
        }
    }
}
