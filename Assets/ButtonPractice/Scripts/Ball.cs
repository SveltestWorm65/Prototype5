using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float force;
    private Rigidbody rb;
    public GameObject restartButton;
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
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
}
