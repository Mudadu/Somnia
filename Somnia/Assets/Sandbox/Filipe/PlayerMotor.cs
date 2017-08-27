using UnityEngine;
using System.Collections;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controle;
    private Vector3 moveVector = Vector3.zero;

    public float verticalVel;
    public float gravidade = 120.0f;
    public float puloForca = 80.0f;

    // Use this for initialization
    private void Start ()
    {
        controle = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	private void Update ()
    {
	    if(controle.isGrounded)
        {
            verticalVel = -gravidade * Time.deltaTime;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                verticalVel = puloForca;
            }
        }
        else
        {
            verticalVel -= gravidade * Time.deltaTime;
        }

        
        moveVector.x = Input.GetAxis("Horizontal") * 1500.0f;
        moveVector.y = verticalVel;
        moveVector.z = Input.GetAxis("Vertical") * 1500.0f;
        controle.Move(moveVector * Time.deltaTime);


    }
}
