// Models/Question.cs
namespace QuizApp.Models
{
    public class Question
    {
        public string TextTr { get; set; }  // Türkçe soru metni
        public string TextEn { get; set; }  // İngilizce soru metni
        public string Answer { get; set; }  // Doğru cevap
        public string HintTr { get; set; }  // Türkçe ipucu
        public string HintEn { get; set; }  // İngilizce ipucu

        public Question(string textTr, string textEn, string answer, string hintTr, string hintEn)
        {
            TextTr = textTr;
            TextEn = textEn;
            Answer = answer;
            HintTr = hintTr;
            HintEn = hintEn;
        }
    }
}
