using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shotCounter : MonoBehaviour
{

    private int _shotCounter = 0;
    private TextMeshProUGUI _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        duck_movement.ChickenDead += IncreaseCounter;
        UpdateText();
    }

    void OnDestroy()
    {
        duck_movement.ChickenDead -= IncreaseCounter;
    }

    public void ResetCounter()
    {
        _shotCounter = 0;
        UpdateText();
    }
    
    private void IncreaseCounter()
    {
        _shotCounter++;
        UpdateText();
    }

    private void UpdateText()
    {
        _text.text = "Score " + _shotCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
