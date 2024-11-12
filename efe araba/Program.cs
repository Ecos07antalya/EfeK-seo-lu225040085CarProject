// Program.cs
using System;
using System.Collections.Generic;
using QuizApp.Models;
using QuizApp.Services;
using QuizApp.Utilities;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dil seçimi
            bool isEnglish = Language.GetLanguageChoice();

            // Soru listesi
            List<Question> questions = new List<Question>
            {
                new Question("1997 yılında çıkan ve Nissan Skyline GT-R R34'ü içeren simülasyon oyunu hangisidir?",
                             "Which simulation game, released in 1997, features the Nissan Skyline GT-R R34?",
                             "Gran Turismo",
                             "Bu oyun Japonya'da Polyphony Digital tarafından geliştirildi.",
                             "This game was developed in Japan by Polyphony Digital."),

                new Question("2014 yılında yayınlanan ve Ford GT'nin öne çıktığı yarış simülasyonu serisi nedir?",
                            "Which racing simulation series, released in 2014, features the Ford GT?",
                            "Forza Motorsport",
                            "Microsoft'un yarış simülasyonu serisi.",
                            "Microsoft's racing simulation series."),

                new Question("Ferrari 458 Italia’yı sürme deneyimini gerçekçi bir şekilde yaşatan, 2014 yılında çıkmış simülasyon oyunu hangisidir?",
                             "Which simulation game, released in 2014, allows a realistic driving experience of the Ferrari 458 Italia?",
                             "Assetto Corsa",
                             "İtalyan yapımı bir yarış simülasyonu.",
                             "An Italian-made racing simulation."),

                new Question("2015 yılında piyasaya sürülen ve Pagani Zonda R gibi üst düzey araçların bulunduğu simülasyon oyununun adı nedir?",
                             "What is the name of the simulation game, released in 2015, featuring high-performance cars like the Pagani Zonda R?",
                             "Project CARS",
                             "Bu oyun Slightly Mad Studios tarafından geliştirilmiştir.",
                             "This game was developed by Slightly Mad Studios."),

                new Question("Chevrolet Corvette C6.R’ı gerçekçi yarış sezonlarında deneyimlemek isteyenler için 2008’de piyasaya sürülen çevrimiçi simülasyon oyunu nedir?",
                             "Which online simulation game, released in 2008, offers a realistic racing experience with the Chevrolet Corvette C6.R?",
                             "iRacing",
                             "Bu oyun, profesyonel çevrimiçi yarışçılar tarafından sıkça tercih edilir.",
                             "This game is often preferred by professional online racers."),

                new Question("Formula 1 araçlarıyla yarışmayı sağlayan, 2010'da Codemasters tarafından başlatılan simülasyon serisinin adı nedir?",
                             "What is the name of the simulation series, started by Codemasters in 2010, that features Formula 1 cars?",
                             "F1 Series",
                             "FIA ile lisanslı bir Formula 1 serisidir.",
                             "A licensed Formula 1 series with FIA."),

                new Question("Audi R8 LMS Ultra'nın popüler olduğu, 2013 yılında piyasaya sürülen simülasyon oyunu nedir?",
                             "Which simulation game, released in 2013, features the popular Audi R8 LMS Ultra?",
                             "RaceRoom Racing Experience",
                             "SimBin Studios tarafından geliştirilen bir yarış oyunu.",
                             "A racing game developed by SimBin Studios."),

                new Question("Subaru Impreza WRX STI ile ralli deneyimi sunan, 2015 yılında çıkan oyun hangisidir?",
                             "Which game, released in 2015, offers a rally experience with the Subaru Impreza WRX STI?",
                             "Dirt Rally",
                             "Bu oyun Codemasters tarafından geliştirilen bir ralli serisinin parçasıdır.",
                             "Part of a rally series developed by Codemasters."),

                new Question("Mercedes-AMG Petronas F1 W12'yi içeren, 2021 yılında çıkan Formula 1 oyunu nedir?",
                             "Which Formula 1 game, released in 2021, features the Mercedes-AMG Petronas F1 W12?",
                             "F1 2021",
                             "Codemasters tarafından geliştirilen ve EA tarafından yayınlanan F1 oyunu.",
                             "An F1 game developed by Codemasters and published by EA."),

                new Question("Porsche 911 GT3 Cup sürüş deneyimi sunan ve 2020 yılında piyasaya çıkan yarış simülasyonu hangisidir?",
                             "Which racing simulation game, released in 2020, offers the driving experience of a Porsche 911 GT3 Cup?",
                             "Automobilista 2",
                             "Bu oyun, Reiza Studios tarafından geliştirilen bir Brezilya yapımı.",
                             "A Brazilian-made game developed by Reiza Studios.")
                // Diğer soruları buraya ekleyin...
            };

            // Quiz başlatma
            QuizService quizService = new QuizService(questions, isEnglish);
            quizService.StartQuiz();
        }
    }
}
