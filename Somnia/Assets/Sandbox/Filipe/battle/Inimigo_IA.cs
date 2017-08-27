using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo_IA : MonoBehaviour {
    public Transform alvo;
    public int velMove;
    public int velRotacao;

    private Transform tempTransform;
    private Vector3 frente;
   

    void Awake(){
        tempTransform = transform;
        frente = tempTransform.forward;
        

    }

    // Use this for initialization
    void Start () {
        GameObject foco = GameObject.FindGameObjectWithTag("Player");

        alvo = foco.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawLine(alvo.position, tempTransform.position, Color.green);

        //Olhar para o alvo
        tempTransform.rotation = Quaternion.Slerp(tempTransform.rotation, Quaternion.LookRotation(alvo.position - tempTransform.position), velRotacao*Time.deltaTime);
        

        //Mover para o alvo
        frente = tempTransform.forward;
        frente.y = 0; // Inimigo não se mover na vertical
        tempTransform.position += frente * velMove * Time.deltaTime;
        


    }
}
