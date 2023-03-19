namespace GameLibrary;

// TODO: Vytvořte třídu UpdatedStatsEventArgs, která je potomkem EventArgs
// - a obsahuje vlastnosti (get & init)
// -- int Correct
// -- int Missed
// -- int Accuracy

// TODO: Vytvořte delegát UpdatedStatsEventHandler pro příslušnou událost, využijte výše definované argumenty

// TODO: Dokončete třídu Stats...
public class UpdatedStatsEventArgs : EventArgs
{
    public int Correct { get; init; }
    public int Missed { get; init; }
    public int Accuracy { get; init; }
}

public delegate void UpdatedStatsEventHandler(object sender, UpdatedStatsEventArgs e);

public class Stats
{
    // TODO: Vytvořte vlastnosti určené pro čtení:
    // - int Correct
    // - int Missed
    // - Int Accuracy
    private int correct;
    private int missed;
    private int accuracy;
    public int Correct {get{return correct;}}
    public int Missed {get{return missed;}}
    public int Accuracy {get{return accuracy;}}

    // TODO: Vytvořte veřejnou událost UpdatedStats (UpdatedStatsEventHandler?)

    public event UpdatedStatsEventHandler? UpdatedStats;

    // TODO: Vytvořte veřejnou metodu Update
    // - parametr - bool correctKey - určuje zdali byla stisknuta správná klávesa a jedná se o Correct zásah či o Missed zásah
    // - na základě parametru inkrementujte Correct nebo Missed vlastnost
    // - vypočtěte hodnotu Accuracy jako procentuální přesnost (na základě Correct a Missed, vypočtená hodnota 0-100 %)
    // - vyvolejte událost UpdatedStats a předejte pomocí event args aktuální stav vlastností

    public void Update(bool correctKey)
    {
        if (correctKey) { correct++; }
        else { missed++; }

        accuracy = (int)Math.Round(((float)correct / (correct + missed)) * 100);

        UpdatedStats?.Invoke(this, new UpdatedStatsEventArgs { Correct = correct, Missed = missed, Accuracy = accuracy });
    }

    // TODO: Vytvořte veřejnou metodu Reset
    // - metoda vynuluje vlasnosti Correct, Missed, Accuracy
    // - metoda nijak nemění stav události UpdatedStats a ani ji nevyvolává

    public void Reset()
    {
        correct = 0;
        missed = 0;
        accuracy = 0;
    }
}
