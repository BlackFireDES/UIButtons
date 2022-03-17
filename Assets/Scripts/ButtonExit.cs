using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonExit : MonoBehaviour
{
    [SerializeField] private TMP_Text _outputText;

    private string _message = "Удачи! Заходи еще п*оиграть!";

    public void OnButtonClick()
    {
        _outputText.text = _message;
    }
}
