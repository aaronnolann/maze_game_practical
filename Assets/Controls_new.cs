using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls_new : MonoBehaviour
{
    // Start is called before the first frame update

    // Horizontal is z axis, vertical is x axis

    float movementAmount = 5;
    float yRotation = 0;
    public GameObject ball;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationVert = Input.GetAxis("Vertical") * movementAmount;
        float rotationHoriz = Input.GetAxis("Horizontal") *- movementAmount;

        transform.rotation = Quaternion.Euler(rotationVert, yRotation, rotationHoriz);

        if ( (Input.GetKeyDown(KeyCode.R)) && (ball.transform.position.y < -10))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
