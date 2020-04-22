using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    Vector3 mousePos;
    Camera camara;
    float velocidadAndar = 10.0f;

    CharacterController cmpCC;


    // Start is called before the first frame update
    void Start()
    {
        camara = FindObjectOfType<Camera>();
        cmpCC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        mousePos = camara.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camara.transform.position.y - transform.position.y));
        transform.LookAt(mousePos);

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 velocidad = (Vector3.right * velocidadAndar * xInput) + (Vector3.forward * velocidadAndar * zInput);

        cmpCC.Move(velocidad * Time.deltaTime);

    }
}
