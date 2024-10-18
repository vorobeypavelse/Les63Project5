using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Les64MovePlayer : MonoBehaviour
{
    
    [SerializeField] int speed = 20;
    [SerializeField] int rotationSpeed = 90;

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // �������� ������� � ������� ����
        float mouseHorizontal = Input.GetAxis("Mouse X");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * vertical);
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * horizontal);
        //�������� ������� � ������� ����
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * mouseHorizontal);
    }

    //���� 66
    
}
