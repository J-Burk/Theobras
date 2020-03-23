using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public Transform Target;
    public Camera Camera;
    public GameObject HUD;

    public bool fly;

    public string Name;

    public float walkSpeed;
    public float flightSpeed;
    public float horizontalInput;
    public float verticalInput;
    public float rotationValue;

    public Animator CharacterAnimator;

    private RaycastHit choose;
    private Ray chooseRay;

    void Start()
    {
        fly = false;
        walkSpeed = 2.0f;
        flightSpeed = 10;
        Name = "Player";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            walkSpeed = 10.0f;
        }
        else
        {
            walkSpeed = 5.0f;
        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        rotationValue += horizontalInput;
        transform.position += transform.forward * verticalInput * walkSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, rotationValue, 0), Time.deltaTime * 20);

        if (Input.GetMouseButtonDown(0))
        {
            chooseRay = Camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(chooseRay, out choose))
            {
                Target = choose.transform;
                //if (choose.collider.gameObject.tag == "Finish")
                //{
                //    Target = choose.transform;
                //}
            }
        }
        if (Target != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Target.GetComponent<EnemieAlphaScript>().life -= 10;
            }
        }

        if (Input.GetKeyDown("1"))
        {
            //Debug.Log("1 is gedrückt");
        }
        if (Input.GetKeyDown("7"))
        {
            Debug.Log("7 is gedrückt");
            HUD.GetComponent<HUDScript>().maxCast = 7;
            HUD.GetComponent<HUDScript>().Cast();
        }

    }
}
