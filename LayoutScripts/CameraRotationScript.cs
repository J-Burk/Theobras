using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;

    public bool startDelay;
    public bool rightButtonDown;
    public bool leftButtonDown;

    public float rotationValue;
    public float mouseScroll;
    public float maxCamDistance;
    public float minCamDistance;
    public float camDistanceReader;
    public float camRotationVertical;
    public float camRotationHorizontal;
    public float camRotationZ;
    public float camRotationSpeed;

    Vector3 mousePosition;

    void Start()
    {
        // Startdelay für Scrollfix
        startDelay = true;

        // Playerzuweisung
        Player = GameObject.FindGameObjectWithTag("Player");

        // Kamera Scroll Variablen
        maxCamDistance = 2;
        minCamDistance = 0;
        camDistanceReader = 1;

        // Kamerarotationvariablen
        camRotationSpeed = 100.0f;
    }

    void Update()
    {
        transform.position = Player.transform.position + new Vector3(0, 1, 0);
        mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        camRotationZ = transform.rotation.z;

        // Prüfung ob Rechte Maustaste gehalten wird
        if (Input.GetMouseButtonDown(1))
        {
            rightButtonDown = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            rightButtonDown = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            leftButtonDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            leftButtonDown = false;
        }

        // Charaktersteuerung
        if (!startDelay)
        {
            if (camDistanceReader >= minCamDistance - 0.1f && camDistanceReader <= maxCamDistance + 0.1f)
            {
                camDistanceReader -= mouseScroll * 1;
                if (camDistanceReader < minCamDistance)
                {
                    camDistanceReader = minCamDistance;
                }
                else if (camDistanceReader > maxCamDistance)
                {
                    camDistanceReader = maxCamDistance;
                }
            }

            if (camDistanceReader > minCamDistance && camDistanceReader < maxCamDistance)
            {
                Camera.transform.position += Camera.transform.forward * mouseScroll * 100 * Time.deltaTime;
            }

            //if (rightButtonDown)
            //{
            //    camRotationHorizontal = mousePosition.x + Input.GetAxis("Mouse X");
            //    transform.RotateAround(Player.transform.position, Vector3.up, camRotationHorizontal);
            //}
            if (rightButtonDown && !leftButtonDown)
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * camRotationSpeed * Time.deltaTime, 0);
                Camera.transform.Rotate(-1 * Input.GetAxis("Mouse Y") * camRotationSpeed * Time.deltaTime, 0, 0);
                Camera.transform.position -= new Vector3(0, Input.GetAxis("Mouse Y") * 0.05f * camDistanceReader, 0);
            }
            if (rightButtonDown && leftButtonDown)
            {
                Camera.transform.Rotate(-1 * Input.GetAxis("Mouse Y") * camRotationSpeed * Time.deltaTime, 0, 0);
            }
        }
        //Start Delay um den Bug dass die Kamera am anfang verschoben wird zu entgehen
        startDelay = false;
    }
}
