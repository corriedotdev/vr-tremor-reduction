using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOut : MonoBehaviour {

    public LineRenderer line;


    private void Start() {
        
    }

    private void Update() {
        line.SetPosition(0, this.transform.localPosition);

        line.SetPosition(1, new Vector3(this.transform.localPosition.x,
            this.transform.localPosition.y,
            this.transform.localPosition.z + 20f));


    }



}
