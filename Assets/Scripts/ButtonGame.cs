using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonGame : MonoBehaviour
{
    [SerializeField] private TMP_Text _outputText;

    private string _message = "Вы уже проиграли? Так быстро?";

    public void OnButtonClick()
    {
        _outputText.text = _message;
    }
}
