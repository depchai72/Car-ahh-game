using UnityEngine;

public class TuPhaHuy : MonoBehaviour
{
    public GameObject NguoiChoi;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NguoiChoi.transform.position.z - transform.position.z > 120)
        {
            Destroy(gameObject);
        }
    }
}
