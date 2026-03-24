using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NguoiChoiDieuKhien : MonoBehaviour
{
    //Bien rieng 
    private float tocdo = 20.0f;
    private float tocDoXoay = 67.0f;
    private float docDauVao;
    private float thangDauVao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Day la de lay dau vao cua nguoi choi
        docDauVao = Input.GetAxis("Horizontal");
        thangDauVao = Input.GetAxis("Vertical");

        //Di chuyen xe den truoc
        transform.Translate(Vector3.forward * Time.deltaTime * tocdo * thangDauVao);
        //Xoay xe qua lai
        transform.Rotate(Vector3.up, tocDoXoay * docDauVao * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("thoatgame");
            Application.Quit();
        }

    }
}
