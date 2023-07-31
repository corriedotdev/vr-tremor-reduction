using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilterToggle : MonoBehaviour {


    public FilterInput _left, _right;
    public bool _isOn = true;
    public Text _btnText;


    public void ToggleFilter() {
        _isOn = !_isOn;

        if (_isOn) {
            _left.filterOn = true;
            _right.filterOn = true;
            _btnText.text = "Disable Filter";
        } else {
            _left.filterOn = false;
            _right.filterOn = false;
            _btnText.text = "Enable Filter";
        }



    }


}
