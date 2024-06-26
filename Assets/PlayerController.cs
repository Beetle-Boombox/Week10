using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            playerAnim.SetBool("UpTurn", true);
        }
        
        if(Input.GetKeyDown(KeyCode.A))
        {
            playerAnim.SetBool("LeftTurn", true);
        }

        
        if(Input.GetKeyDown(KeyCode.S))
        {
            playerAnim.SetBool("DownTurn", true);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            playerAnim.SetBool("RightTurn", true);
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("UpTurn", false);
        }
        
        if(Input.GetKeyUp(KeyCode.A))
        {
            playerAnim.SetBool("LeftTurn", false);
        }

        
        if(Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("DownTurn", false);
        }

        if(Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("RightTurn", false);
        }
    }
}
