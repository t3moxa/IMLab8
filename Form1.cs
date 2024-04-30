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
                1 => "�������� ��������",
                2 => "���������� ��",
                3 => "����� ����������",
                4 => "������� ����������",
                5 => "�� ����",
                6 => "������� ����",
                7 => "��� ������� ������",
                8 => "��� �����?",
                _ => "��� �� ������ ������� ���� �����?"
            };
        }
        public string GetSimpleAnswer()
        {
            double a = _simpleRandom.NextDouble();
            if (a < 0.5)
            {
                return "��";
            }
            else
            {
                return "���";
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
