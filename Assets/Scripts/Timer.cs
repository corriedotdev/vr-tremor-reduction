using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private bool _isActive = false;
    private float _timer = 0;
    public Text _timerText;
    public Text _btnText;

    private void Update() {
        
        if (_isActive) {
            //start timer
            _timer += Time.deltaTime;
            _timerText.text = Math.Round((Decimal)_timer, 3, MidpointRounding.AwayFromZero).ToString();            
        } 
    }

    public void StartStopTimer() {
        _isActive = !_isActive;

        if (_isActive == false) {
            _timer = 0;
            _btnText.text = "Start";
        } else {
            _btnText.text = "Stop";
        }
    }





}
