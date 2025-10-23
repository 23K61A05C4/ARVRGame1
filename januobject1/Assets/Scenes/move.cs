using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float moveForce ;
    [SerializeField] float JumpForce  ;
    Rigidbody body;
    private void Start()
    {
        body= GetComponent<Rigidbody>();
        body.freezeRotation = true;     
    }
    private void FixedUpdate()
    {
        movementLogic();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }
    private void movementLogic()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movedirection = (transform.right * x + transform.forward * z); 
        body.AddForce(moveForce * movedirection, ForceMode.Force);
    }
}

