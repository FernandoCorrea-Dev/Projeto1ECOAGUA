using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoÁgua
{
    public partial class formQuiz : Form
    {
        public List<Question> questions = new List<Question>();
        public int currentQuestionIndex = 0;

        public formQuiz()
        {
            InitializeComponent();
            ConfigureRichTextBoxes();
            AddQuestions();
            ShowQuestion();
        }

        private void ConfigureRichTextBoxes()
        {
            var richTextBoxes = new[] { lblExplanation, lblQuestion };

            foreach (var rtb in richTextBoxes)
            {
                string rtfAtual = rtb.Rtf;
                rtfAtual = rtfAtual.Replace(@"\ql", @"\qj");

                if (!rtfAtual.Contains(@"\qj"))
                {
                    rtfAtual = rtfAtual.Replace(@"\pard", @"\pard\qj");
                }

                rtb.Rtf = rtfAtual;
            }
        }

        private void AddQuestions()
        {
            // Adicionando perguntas e explicações sobre o uso consciente da água
            questions.Add(new Question("Pergunta 1: Qual é a principal fonte de água potável no planeta?", "Águas subterrâneas",
                new[] { "Oceanos", "Rios e lagos", "Águas subterrâneas" },
                "Embora a água seja abundante no planeta, mais de 97% dela está nos oceanos e não é potável.\nA água doce disponível para consumo humano está principalmente em águas subterrâneas e em rios e lagos."));

            questions.Add(new Question("Pergunta 2: Quanto tempo pode demorar para que 1 litro de óleo derramado na água se decomponha?", "1 ano",
                new[] { "1 dia", "1 mês", "1 ano" },
                "O óleo derramado na água pode demorar até 1 ano para se decompor, prejudicando a qualidade da água e afetando a vida aquática."));

            questions.Add(new Question("Pergunta 3: Qual é o consumo médio de água diário de uma pessoa?", "150 litros",
                new[] { "50 litros", "150 litros", "200 litros" },
                "Em média, uma pessoa consome cerca de 150 litros de água por dia, incluindo o uso para beber, cozinhar, higiene e outros serviços."));

            questions.Add(new Question("Pergunta 4: Qual é a prática mais eficiente para economizar água no dia a dia?", "Tomar banhos mais curtos",
                new[] { "Tomar banhos mais curtos", "Lavar roupas com pouca água", "Usar torneiras abertas por mais tempo" },
                "Reduzir o tempo no banho é uma das formas mais eficazes de economizar água. Um banho longo pode consumir até 100 litros de água, enquanto um banho mais curto pode reduzir esse consumo significativamente."));

            questions.Add(new Question("Pergunta 5: O que pode acontecer com o uso excessivo de água potável?", "Escassez de água",
                new[] { "Aumento da poluição", "Escassez de água", "Menos áreas verdes" },
                "O uso excessivo de água potável pode levar à escassez de recursos hídricos, afetando tanto o consumo humano quanto os ecossistemas que dependem da água."));

            questions.Add(new Question("Pergunta 6: Qual das seguintes atitudes contribui para a economia de água em casa?", "Fechar a torneira enquanto escova os dentes",
                new[] { "Usar o vaso sanitário como lixeira", "Fechar a torneira enquanto escova os dentes", "Deixar a torneira aberta durante o uso do sabão" },
                "Fechar a torneira enquanto escova os dentes pode economizar até 12 litros de água por minuto."));

            questions.Add(new Question("Pergunta 7: Quanto tempo em média uma ducha de 15 minutos pode consumir de água?", "100 litros",
                new[] { "50 litros", "100 litros", "150 litros" },
                "Uma ducha de 15 minutos pode consumir até 100 litros de água, o que é um desperdício significativo em locais onde há escassez de água."));

            questions.Add(new Question("Pergunta 8: O que é reuso da água?", "Usar a água da chuva para regar plantas",
                new[] { "Usar a água da chuva para regar plantas", "Reutilizar a água de lavagem de roupas para limpar o chão", "Reutilizar a água potável para consumo humano" },
                "O reuso de água pode ser uma prática sustentável, como usar a água da chuva para regar plantas e reduzir o consumo de água potável."));

            questions.Add(new Question("Pergunta 9: Qual das seguintes opções pode ajudar a reduzir o desperdício de água nas indústrias?", "Instalar sistemas de captação de água da chuva",
                new[] { "Instalar sistemas de captação de água da chuva", "Aumentar o uso de água nas fábricas", "Descartar água de processo no esgoto sem tratamento" },
                "As indústrias podem reduzir o uso de água potável captando a água da chuva e utilizando-a em processos não potáveis."));

            questions.Add(new Question("Pergunta 10: Quais dos seguintes hábitos de consumo ajudam a evitar o desperdício de água?", "Utilizar lavadoras de roupas e louças com carga máxima",
                new[] { "Utilizar lavadoras de roupas e louças com carga máxima", "Lavar carros com mangueira aberta", "Encher a piscina com água potável frequentemente" },
                "Utilizar lavadoras de roupas e louças com a carga completa é uma maneira eficiente de reduzir o consumo de água, evitando lavagens desnecessárias."));
        }

        // Mostrar a pergunta atual
        private void ShowQuestion()
        {
            lblExplanation.Visible = false;

            if (currentQuestionIndex < questions.Count)
            {
                var question = questions[currentQuestionIndex];
                lblQuestion.Text = question.QuestionText;

                rbtnOption1.Text = question.Options[0];
                rbtnOption2.Text = question.Options[1];
                rbtnOption3.Text = question.Options[2];

                rbtnOption1.Checked = false;
                rbtnOption2.Checked = false;
                rbtnOption3.Checked = false;

                btnSubmit.Enabled = false; // Desabilitar o botão "Submeter"
                rbtnOption1.Visible = true;
                rbtnOption2.Visible = true;
                rbtnOption3.Visible = true;
                btnSubmit.Visible = true;

                // Forçar o refresh da interface para garantir que os controles sejam visíveis
                this.Refresh();
            }
            else
            {
                // Fim do quiz
                lblQuestion.Text = "Você terminou o quiz!";
                rbtnOption1.Visible = false;
                rbtnOption2.Visible = false;
                rbtnOption3.Visible = false;
                btnSubmit.Visible = false;

                lblExplanation.Text = "Obrigado por responder nosso quiz! Espero que tenha aprendido muito!!";
                lblExplanation.Visible = true;

                // Iniciar o timer de reinício
                Timer restartTimer = new Timer();
                restartTimer.Interval = 5000; // 5 segundos
                restartTimer.Tick += RestartTimer_Tick; // Método para reiniciar
                restartTimer.Start();
            }
        }

        // Método que trata o evento Tick do timer para reiniciar o quiz
        private void RestartTimer_Tick(object sender, EventArgs e)
        {
            Timer restartTimer = sender as Timer;
            if (restartTimer != null)
            {
                restartTimer.Stop(); // Parar o timer
                currentQuestionIndex = 0; // Reiniciar o índice das perguntas
                ShowQuestion(); // Exibir a primeira pergunta novamente
            }
        }

        // Evento de clique no botão "Submeter"
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var question = questions[currentQuestionIndex];

            // Verificar qual opção foi selecionada
            string selectedAnswer = string.Empty;
            if (rbtnOption1.Checked) selectedAnswer = rbtnOption1.Text;
            else if (rbtnOption2.Checked) selectedAnswer = rbtnOption2.Text;
            else if (rbtnOption3.Checked) selectedAnswer = rbtnOption3.Text;

            // Exibir a explicação
            if (selectedAnswer == question.CorrectAnswer)
            {
                lblExplanation.Text = "Resposta correta: " + question.Explanation;

                // Iniciar o timer para avançar a pergunta após 5 segundos
                Timer questionTimer = new Timer();
                questionTimer.Interval = 3000; // 5 segundos
                questionTimer.Tick += QuestionTimer_Tick;
                questionTimer.Start();
            }
            else
            {
                lblExplanation.Text = "Resposta incorreta: " + question.Explanation;
            }

            rbtnOption1.Checked = false;
            rbtnOption2.Checked = false;
            rbtnOption3.Checked = false;
            btnSubmit.Enabled = false;
            lblExplanation.Visible = true;
        }

        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            Timer questionTimer = sender as Timer;
            if (questionTimer != null)
            {
                questionTimer.Stop();
                currentQuestionIndex++;
                ShowQuestion();
            }
        }

        // Função que será chamada sempre que uma opção de resposta for clicada
        private void Option_CheckedChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = rbtnOption1.Checked || rbtnOption2.Checked || rbtnOption3.Checked;
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            btnSubmit.ForeColor = System.Drawing.Color.Black;
        }
    

    private void lblExplanation_TextChanged(object sender, EventArgs e)
        {
            // Não utilizado, mas pode ser expandido se necessário
        }
    }

    // Classe Question
    public class Question
    {
        public string QuestionText { get; set; }
        public string CorrectAnswer { get; set; }
        public string[] Options { get; set; }
        public string Explanation { get; set; }

        public Question(string questionText, string correctAnswer, string[] options, string explanation)
        {
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
            Options = options;
            Explanation = explanation;
        }
    }
}