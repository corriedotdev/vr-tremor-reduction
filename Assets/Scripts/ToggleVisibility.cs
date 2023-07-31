using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisibility : MonoBehaviour {


    public void Toggle() {
        this.gameObject.SetActive(!this.gameObject.active);
    }
}
