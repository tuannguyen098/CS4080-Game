using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 30.0f;
    private float turnSpeed = 50;

    private float horizontalInput;
    private float forwardInput;

    private bool crashed = false;

    public GameManager gameManager;

    // Stops the vehicle when it crashes
    public IEnumerator resumeDriving()
    {
        Debug.Log("waiting");
        yield return new WaitForSecondsRealtime((float)0.5);
        crashed = false;
        
    }
    // Stops the vehicle when it crashes
    public void isCrashed(bool checking)
    {
        if (checking)
        {
            Debug.Log("Crashed");
            crashed = true;
            StartCoroutine(resumeDriving());
            Debug.Log("Done waiting");
        }
    }
    // Start is called before the first frame update
    public void Start()
    {
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }

    // Update is called once per frame
    public void Update()
    {
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward
        if(!crashed)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
        else
        {
             transform.Translate(0,0,0);
        }
        if(transform.position.z > 477.0493)
        {
            GetComponent<PlayerController>().enabled = false;
            gameManager.Victory();
        }
    }
}
