using TMPro;
using UnityEngine;

public class CSVReader : MonoBehaviour
{
    [SerializeField] private CSVManager csv;
    [SerializeField] private int textID;

    [SerializeField] private TextMeshProUGUI wikiText;
    [SerializeField] private TextMeshProUGUI wikiName;

    void Start()
    {
        wikiName.text = csv.rows[textID][0];
        wikiText.text = csv.rows[textID][1];
    }

    public void Next()
    {
        if(textID < csv.rows.Length)
        {
            textID++;
            Start();
        }
    }

    public void Back()
    {
        if(textID > 0)
        {
            textID--;
            Start();
        }
    }
}