using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody rigidbodyPlayer;
    public float speed = 2f;
    public float RotationSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertacal = Input.GetAxis("Vertical");

        Vector3 DirVector = new Vector3(horizontal, 0, vertacal);
        if(DirVector.magnitude > Mathf.Abs(0.05f))
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.LookRotation(DirVector), Time.deltaTime * RotationSpeed);
        rigidbodyPlayer.velocity = Vector3.ClampMagnitude(DirVector,1) * speed;
    }
}
