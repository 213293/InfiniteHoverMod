using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boom : MonoBehaviour
{

    private Animator animator; //this creates a variable called animator

    void Awake()
    {
        animator = GetComponent<Animator>(); //this assigns the gameObjects Animator to the variable animator
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log ("Boom", gameObject);
        animator.SetBool("Collision", true); //this changes the bool parameter to true and triggers the "Boom" animation
        Invoke("ChangeLevel", .5f);

    }

    void ChangeLevel()
    {
        SceneManager.LoadScene("SampleScene"); //this restarts the current level
    }

}