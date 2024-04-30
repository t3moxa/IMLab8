namespace IMLab8
{
    public partial class Form1 : Form
    {
        Random _simpleRandom = new Random();
        Random _8BallRandom = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public string Get8BallAnswer()
        {
            double a = _8BallRandom.NextDouble();
            int k = 0;
            while (a > 0)
            {
                a = a - 0.125;
                k++;
            }
            return k switch
            {
                1 => "Возможно частично",
                2 => "Определённо да",
                3 => "Очень сомневаюсь",
                4 => "Подумай хорошенько",
                5 => "НЕ НАДО",
                6 => "Слишком рано",
                7 => "Уже слишком поздно",
                8 => "Кто знает?",
                _ => "Как ты вообще получил этот ответ?"
            };
        }
        public string GetSimpleAnswer()
        {
            double a = _simpleRandom.NextDouble();
            if (a < 0.5)
            {
                return "Да";
            }
            else
            {
                return "Нет";
            }
        }
        private void BallAnswerButton_Click(object sender, EventArgs e)
        {
            BallAnswerLabel.Text = Get8BallAnswer();
        }

        private void SimpleAnswerButton_Click(object sender, EventArgs e)
        {
            SimpleAnswerLabel.Text = GetSimpleAnswer();
        }
    }
}
