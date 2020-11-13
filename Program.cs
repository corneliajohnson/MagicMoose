using System;
using System.Collections.Generic;

namespace MagicMoose
{
  class Program
  {
    static void Main(string[] args)
    {
      // Let the moose speak!
      MooseSays("I'm the Magic Moose. Ask Me Anything!");
      string question = Console.ReadLine();
      MooseSays(RandomAnswer());
      ContinueQuestion();
    }

    static void MooseSays(string message)
    {
      Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
    }

    static string RandomAnswer()
    {
      List<string> answers = new List<string>()
        {
            "As I see it, yes.", "Ask again later.", "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.", "Don’t count on it.", "It is certain.", "It is decidedly so.", "Most likely.", "My reply is no.", "My sources say no.", "Outlook not so good.","Outlook good.", "Reply hazy, try again.", "Signs point to yes.", "Very doubtful.", "Without a doubt.", "Yes.", "Yes – definitely.", "You may rely on it."
        };
      Random randomResponse = new Random();
      int generateRandom = randomResponse.Next(0, answers.Count - 1);
      return answers[generateRandom];
    }

    static void ContinueQuestion()
    {
      while (true)
      {
        MooseSays("Ask me more");
        string question = Console.ReadLine();
        if (!string.IsNullOrEmpty(question))
        {
          MooseSays(RandomAnswer());
        }
        else
        {
          Environment.Exit(-1);
        }
      }
    }
  }
}
