public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private double _activityDuration;

    public Activity(string activityName, string activityDescription, double activityDuration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _activityDuration = activityDuration;
    }

    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetActivityDescription()
    {
        return _activityDescription;
    }
    public double GetActivityDuration()
    {
        return _activityDuration;
    }
    public string GetStartingMessage()
    {
        return $"Welcome to the {_activityName} activity." 
    }
}