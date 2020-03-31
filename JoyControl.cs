using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class JoyControl : MonoBehaviour
{
    public Transform other;
    float posZ = 0;
    float fov = 0;
    // Start is called before the first frame update
    void Start()
    {
        //EditorApplication.update += Update;
        posZ = 0;
        fov = GetComponent<Camera>().fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        //float Hv = Input.GetAxis("Horizontal");
        float Vv = Input.GetAxis("Vertical");
        //float faword = Input.GetAxis("Joy_Y");
        //Vector3 pos = transform.forward * Vv * 0.06f;
        posZ += Vv * 0.06f;
        transform.localPosition -= transform.forward * Vv * 0.06f;


        //float Hvo = Input.GetAxis("Horizontal_R");
        float Vvo = Input.GetAxis("Vertical_R");
        //Vector3 poso = new Vector3(transform.position.x, transform.position.y,
        //     transform.position.z + Hvo * 0.1f);
        //transform.position = poso;

        //Vector3 rotation = new Vector3(transform.localEulerAngles.x - Vvo * 0.5f,
        //    transform.localEulerAngles.y + Hvo * 0.5f,
        //    transform.localEulerAngles.z);
        //transform.localEulerAngles = rotation;

        GetComponent<Camera>().fieldOfView -= Vvo * 0.9f;
        //detectPressedKeyOrButton();

        // xbox A键
        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
          //  transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, posZ);

            transform.localPosition += transform.forward * posZ;
            posZ = 0;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
            GetComponent<Camera>().fieldOfView = fov;
    }

    public void detectPressedKeyOrButton()
    {
        //foreach (KeyCode kcode in System.Enum.GetValues(typeof(KeyCode)))
        //{
        //    if (Input.GetKeyDown(kcode))
        //        Debug.Log("KeyCode down: " + kcode);
        //}

    }
}
