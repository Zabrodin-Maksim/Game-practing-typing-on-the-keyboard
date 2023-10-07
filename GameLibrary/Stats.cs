namespace GameLibrary;


public class UpdatedStatsEventArgs : EventArgs
{
    public int Correct { get; init; }
    public int Missed { get; init; }
    public int Accuracy { get; init; }
}

public delegate void UpdatedStatsEventHandler(object sender, UpdatedStatsEventArgs e);

public class Stats
{
    
    private int correct;
    private int missed;
    private int accuracy;
    public int Correct {get{return correct;}}
    public int Missed {get{return missed;}}
    public int Accuracy {get{return accuracy;}}


    public event UpdatedStatsEventHandler? UpdatedStats;

    public void Update(bool correctKey)
    {
        if (correctKey) { correct++; }
        else { missed++; }

        accuracy = (int)Math.Round(((float)correct / (correct + missed)) * 100);

        UpdatedStats?.Invoke(this, new UpdatedStatsEventArgs { Correct = correct, Missed = missed, Accuracy = accuracy });
    }

    public void Reset()
    {
        correct = 0;
        missed = 0;
        accuracy = 0;
    }
}
