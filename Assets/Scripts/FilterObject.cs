using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterObject : MonoBehaviour {

    OneEuroFilter<Vector3> positionFilter;

    //filter
    public float filterFrequency = 120.0f;
    public float filterMinCutoff = 1.0f;
    public float filterBeta = 0.0f;
    public float filterDcutoff = 1.0f;


    //Noise Stuff
    public bool filterOn;
    public float noiseAmount = 1f;

    private Vector3 startingPos;
    private Vector3 noisyPos;

    public GameObject noisyCube;



    private void Start() {
        positionFilter = new OneEuroFilter<Vector3>(filterFrequency);
        this.startingPos = this.transform.localPosition;
    }

    private void Update() {

        //consider removing z noise?

        //generate noise
        noisyPos = PerturbedPosition(startingPos);

        //save noisy vector here
        noisyCube.transform.localPosition = noisyPos;

        if (filterOn){

            //init
            positionFilter.UpdateParams(filterFrequency, filterMinCutoff, filterBeta, filterDcutoff);
            //apply filter
            this.transform.localPosition = positionFilter.Filter(noisyPos);

        } else {
            this.transform.localPosition = noisyPos;
        }

    }

    Vector3 PerturbedPosition(Vector3 _position) {
        Vector3 noise = new Vector3(Random.value * noiseAmount - noiseAmount / 2.0f,
                                    Random.value * noiseAmount - noiseAmount / 2.0f,
                                    Random.value * noiseAmount - noiseAmount / 2.0f) * Time.deltaTime;

        return _position + noise;
    }

}
