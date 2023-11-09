using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    // [SerializeField] float xValue = 0f;
    // [SerializeField] float yValue = 0.01f;
    // [SerializeField] float zValue = 0f;
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        printInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void printInstructions()
    {
        Debug.Log("Welcome to the ObstacleCoure game");
        Debug.Log("Use arrow/WASD keys to move the player");
        Debug.Log("Do not hit the walls!!!!");
    }

    void movePlayer()
    {
        float time = Time.deltaTime;
        float xValue = Input.GetAxis("Horizontal") * time * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * time * moveSpeed;
        transform.Translate(zValue,0,-xValue);
    }
}
