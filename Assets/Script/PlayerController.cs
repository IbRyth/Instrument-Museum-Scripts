using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    //相机距离人物高度
    float m_Height = 1.6f;
    //相机距离人物距离
    float m_Distance = 1f;
    //相机跟随速度
    float m_Speed = 4f;
    //目标位置
    Vector3 m_TargetPosition;
    //要跟随的人物
    Vector3 follow;
    public float speed;
    public int rotation;
    bool inTouch = false;

    public Camera m_camara;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        follow = m_camara.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      

        float lerpValue = 0;
        if (Input.GetKey(KeyCode.D)) {
            lerpValue = Mathf.Lerp(transform.position.x, transform.position.x + speed, Time.time);
            transform.position = new Vector3(lerpValue, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            lerpValue = Mathf.Lerp(transform.position.x, transform.position.x - speed, Time.time);
            transform.position = new Vector3(lerpValue, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            lerpValue = Mathf.Lerp(transform.position.z, transform.position.z - speed, Time.time);
            transform.position = new Vector3(transform.position.x, transform.position.y, lerpValue);
        }
        if (Input.GetKey(KeyCode.W))
        {
            lerpValue = Mathf.Lerp(transform.position.z, transform.position.z + speed, Time.time);
            transform.position = new Vector3(transform.position.x, transform.position.y, lerpValue);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            //lerpValue = Mathf.Lerp(transform.rotation.y, transform.rotation.y - rotation, Time.time);
            transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y-10, transform.rotation.z));

        }

            //Vector3 movment = new Vector3(speed * moveHorizontal, 0.0f, speed * moveVertical);
            //rb.AddForce(movment);
            //if (moveVertical > 0)
            //{

            //    transform.position += new Vector3(0, 0, speed * 1.5f);
            //}
        }

    //相机平滑的跟随人物移动
    void LateUpdate()
    {
        //得到这个目标位置
        //      m_TargetPosition = follow.position + Vector3.up * m_Height - follow.forward * m_Distance;
        ////相机位置
        //       m_camara.transform.position = Vector3.Lerp(m_camara.transform.position, m_TargetPosition, m_Speed * Time.deltaTime);
        ////相机时刻看着人物
        // m_camara.transform.LookAt(follow,Vector3.up);
        if (!inTouch)
        {
            m_camara.transform.position = transform.position + follow;
        }

    }

    void OnCollisionEnter(Collision col)
    {
        
        if (col.collider.gameObject.name == "Stand")
        {
            inTouch = true;
            Transform t_t = col.collider.gameObject.transform;
            m_camara.transform.position = new Vector3(t_t.position.x,
                t_t.position.y + m_Height, t_t.position.z);
            m_camara.transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
        }

    }
    void OnCollisionExit(Collision col)
    {
        if (col.collider.gameObject.name == "Stand")
        {
            inTouch = false;
            m_camara.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

        }
    }
}