using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text collectiblesNumbersText;
    private int colletiblesNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCollectible()
    {
        colletiblesNumber++;
        collectiblesNumbersText.text= colletiblesNumber.ToString();
    }
}
