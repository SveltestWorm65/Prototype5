using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float force;
    private Rigidbody rb;
    public GameObject restartButton;
    public Slider slider;
    void Start()
    {
      rb = GetComponent<Rigidbody>();
        ChangeForce();
    }
    public void MoveForward()
    {
        rb.AddForce(Vector3.forward *  force, ForceMode.Impulse);
    }
    public void MoveDown()
    {
        rb.AddForce(Vector3.back * force, ForceMode.Impulse);
    }
    public void MoveLeft()
    {
        rb.AddForce(Vector3.left * force, ForceMode.Impulse);
    }
    public void MoveRight()
    {
        rb.AddForce(Vector3.right * force, ForceMode.Impulse);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void Update()
    {
        if (transform.position.y <= -10)
        {
            restartButton.SetActive(true);
        }
    
    }
    public void ChangeForce()
    {
        //if anyone finds this bring me some code red 
        force = slider.value;
    }
}
