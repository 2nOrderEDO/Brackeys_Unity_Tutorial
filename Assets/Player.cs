using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody rb;
    public Material playermat;
    //public Vector3 F = 100, 0, 0;
	// Use this for initialization
	void Start () {
        Debug.Log("Hello wolrd");
        rb.useGravity = true;
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //rb.AddForce(-100, 0, 0);
        Color color = new Color( 0.5f + rb.velocity[0]/10, 0.5f + rb.velocity[1]/10, 0.5f + rb.velocity[2]/10);
        
        playermat.SetColor("_Color",color);

        Debug.Log(rb.velocity);
        if (Input.GetKey("w") )
        {
            rb.AddForce(-10, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(10, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -10);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, 10);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, 250, 0);
        }
    }
}
