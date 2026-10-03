namespace Bakery.Core;

public class Staff
{
    public string Name { get; set; }
    public int Score { get; set; }

    public Staff(string name, int score)
    {
        Name = name;
        Score = score;
    }

    public string Grade => Grader.Grade(Score);
}