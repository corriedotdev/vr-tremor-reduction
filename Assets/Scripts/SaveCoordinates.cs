using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class SaveCoordinates : MonoBehaviour {


    public GameObject filteredCube;
    public GameObject unfilteredCube;


    public FilterObject obj;

    public float[] unfilteredX = new float[500];
    public float[] unfilteredY = new float[500];

    public float[] filteredX = new float[500];
    public float[] filteredY = new float[500];

    public int[] frame = new int[500];
    int i = 0;
    public string filePath = @"C:\Users\Corrie Green\Desktop\" + DateTime.Now.ToString("yyyy-mm-dd-hh-mm-ss") + ".csv";

    private void Start() {
        if (File.Exists(filePath))
            File.Delete(filePath);

    }

    void FixedUpdate() {

        //Debug.Log("Cube Y: " + cube.transform.position.ToString());

        if(i < 500) {
            frame[i] = i;
            unfilteredX[i] = filteredCube.transform.position.x;
            unfilteredY[i] = filteredCube.transform.position.y;

            filteredX[i] = unfilteredCube.transform.position.x;
            filteredY[i] = unfilteredCube.transform.position.y;

        } else {
            Debug.Log("Maxed out array");
        }

        i++;

    }

    public void Save() {


        StringBuilder sb = new StringBuilder();
        for (int index = 0; index < 500; index++) {

            string v = frame[index] + "," + unfilteredX[index].ToString() + "," + unfilteredY[index].ToString() + "," + filteredX[index].ToString() + "," + filteredY[index].ToString();

            sb.AppendLine(v);
        }


        if (!File.Exists(filePath))
            File.WriteAllText(filePath, sb.ToString());
        else
            File.AppendAllText(filePath, sb.ToString());
    }

}