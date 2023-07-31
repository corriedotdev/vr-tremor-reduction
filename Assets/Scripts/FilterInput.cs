using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterInput : MonoBehaviour {

    OneEuroFilter<Quaternion> positionFilter;

    public Transform controller;

    //filter
    public float filterFrequency = 120.0f;
    public float filterMinCutoff = 1.0f;
    public float filterBeta = 0.0f;
    public float filterDcutoff = 1.0f;

    //Noise Stuff
    public bool filterOn;

    private Vector3 startingPos;

    private void Start() {
        positionFilter = new OneEuroFilter<Quaternion>(filterFrequency);
        this.startingPos = controller.localPosition;
    }

    private void Update() {

        //consider removing z noise?

        if (filterOn) {

            //update rotation 
            Quaternion eulerRotation = controller.rotation;
 
            //init
            positionFilter.UpdateParams(filterFrequency, filterMinCutoff, filterBeta, filterDcutoff);

            //filter rotation
            Quaternion filteredRotation = positionFilter.Filter(eulerRotation);
            transform.rotation = filteredRotation;

            
        }

    }

}
