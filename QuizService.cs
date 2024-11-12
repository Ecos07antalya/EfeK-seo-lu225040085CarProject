// Services/QuizService.cs
using System;
using System.Collections.Generic;
using QuizApp.Models;
using QuizApp.Utilities;

namespace QuizApp.Services
{
    public class QuizService
    {
        private readonly List<Question> _questions;
        private readonly bool _isEnglish;
        private int _score;

        public QuizService(List<Question> questions, bool isEnglish)
        {
            _questions = questions;
            _isEnglish = isEnglish;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine(_isEnglish ? "Welcome to the Racing Simulation Games Quiz!" : "Yarış Simülasyon Oyunları Quiz'ine Hoş Geldiniz!");
            Console.WriteLine(_isEnglish ? "You will earn 1 point for each correct answer.\n" : "Her doğru cevap için 1 puan kazanacaksınız.\n");

            foreach (var question in _questions)
            {
                AskQuestion(question);
            }

            Console.WriteLine(_isEnglish ? $"Quiz Completed! Your score: {_score}/{_questions.Count}" : $"Quiz Tamamlandı! Skorunuz: {_score}/{_questions.Count}");
        }

        private void AskQuestion(Question question)
        {
            Console.WriteLine(_isEnglish ? question.TextEn : question.TextTr);
            Console.Write(_isEnglish ? "Your answer: " : "Cevabınız: ");
            string userAnswer = Console.ReadLine();

            if (userAnswer.Equals(question.Answer, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(_isEnglish ? "Correct!\n" : "Doğru!\n");
                _score++;
            }
            else
            {
                Console.WriteLine(_isEnglish ? $"Incorrect! Hint: {question.HintEn}" : $"Yanlış! İpucu: {question.HintTr}");
                Console.Write(_isEnglish ? "Try again: " : "Tekrar deneyin: ");
                userAnswer = Console.ReadLine();

                if (userAnswer.Equals(question.Answer, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(_isEnglish ? "Correct!\n" : "Doğru!\n");
                    _score++;
                }
                else
                {
                    Console.WriteLine(_isEnglish ? $"Incorrect! The correct answer is: {question.Answer}\n" : $"Yanlış! Doğru cevap: {question.Answer}\n");
                }
            }
        }
    }
}
