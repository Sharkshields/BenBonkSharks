using TMPro;
using UnityEngine;

public class CSVReader : MonoBehaviour
{
    [SerializeField] private CSVManager csv;
    [SerializeField] private int textID;

    [SerializeField] private TextMeshPro wikiText;
    [SerializeField] private TextMeshProUGUI wikiName;

    public void Start()
    {
        wikiName.text = csv.rows[0][textID];
        wikiText.text = csv.rows[1][textID];
    }
}