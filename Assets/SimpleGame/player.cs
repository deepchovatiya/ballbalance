using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    CharacterController ab;
    Vector3 moves;
    public Text scorecheck;
    int score;
    void Start()
    {
        ab= GetComponent<CharacterController>();
    }

    void Update()
    {
        moves = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        ab.Move(moves);
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.collider.tag=="coins")
        {
            hit.gameObject.SetActive(false);
            score++;
            scorecheck.text = "Score"+score;
        }
    }
   
}
