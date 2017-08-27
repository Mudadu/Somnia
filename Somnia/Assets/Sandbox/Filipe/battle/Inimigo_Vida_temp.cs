using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo_Vida_temp : MonoBehaviour {
    public int vidaMax = 100;
    public int vidaAtual = 100;

    public float barraVidaLargura;

	// Use this for initialization
	void Start () {
        barraVidaLargura = Screen.width / 3;


    }
	
	// Update is called once per frame
	void Update () {
        AjustarVidaAtual(0);
	}

    void OnGUI() {
        GUI.Box(new Rect(10,40,barraVidaLargura,20),vidaAtual+"/"+vidaMax);

    }

    void AjustarVidaAtual(int var){
        vidaAtual += var;
        if(vidaAtual<0) vidaAtual = 0;
        if (vidaAtual>vidaMax) vidaAtual = vidaMax; 
        barraVidaLargura = (Screen.width / 3) * (vidaAtual / (float)vidaMax);
    }
}
