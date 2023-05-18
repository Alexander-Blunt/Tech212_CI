namespace SafariGameApp;

public class HighScoreIO
{
    public static void WriteHighScoreToFile(string playerFullName, int score)
    {

    }
}

public class HighScoreObject : IComparable<HighScoreObject>, IEquatable<HighScoreObject>
{
    public string Date { get; }
    public string FullName { get; }
    
    public int Score { get; }

    public HighScoreObject(string fullName, int score, string date)
    {
        FullName = fullName;
        Score = score;
        Date = date;
    }

    public int CompareTo(HighScoreObject? obj)
    {
        if (obj is null)
        {
            throw new ArgumentNullException("Comparing null high score");
        }
        if (obj.Score > this.Score)
        {
            return 1;
        }
        else if (obj.Score == this.Score)
        {
            return 0;
        }
        else return -1;
    }

    public bool Equals(HighScoreObject? other)
    {
        return other is not null &&
               Score == other.Score &&
               FullName == other.FullName &&
               Date == other.Date;
    }
}