using UnityEngine;

public class DiTheoNguoiCHoi : MonoBehaviour
{
    public GameObject NguoiChoi;
    private Vector3 lech = new Vector3(0, 5.0f, -8.53f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Dat camera sau nguoi choi bang cach them vao vi tri nguoi choi
        transform.position = NguoiChoi.transform.position + lech;
    }
}
