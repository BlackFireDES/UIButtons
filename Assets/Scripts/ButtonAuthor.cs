using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonAuthor : MonoBehaviour
{
    [SerializeField] TMP_Text _outputText;

    private string _message = "�����: �������� ������";

    public void OnButtonClick()
    {
        _outputText.text = _message;
    }
}
