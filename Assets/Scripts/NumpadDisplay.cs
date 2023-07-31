using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumpadDisplay : MonoBehaviour {


    public string _input;
    public Text _textOut;



    private void Update() {
        _textOut.text = _input.ToString();

    }



    public void AddNumber(int num) {
        _input = _input + num.ToString();
    }


    public void RemoveLast() {
        if(_input.Length > 0) {
            _input = _input.Remove(_input.Length - 1);

        }

    }
}
