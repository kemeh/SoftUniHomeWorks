public static class MoodFactory
{
    public static Mood GetMood(int points)
    {
        if (points < -5)
        {
            return Mood.Angry;
        }
        if (points >= -5 && points <= 0)
        {
            return Mood.Sad;
        }
        if (points <= 15)
        {
            return Mood.Happy;
        }
        else
        {
            return Mood.JavaScript;
        }
    }
}