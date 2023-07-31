using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderDisplay : MonoBehaviour {

    public Slider _slider;
    public Text _sliderOut;

    private void Update() {
        _sliderOut.text = System.Math.Round(_slider.value *100).ToString();
    }

}
