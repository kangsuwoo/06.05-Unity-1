using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 반드시 MonoBehavipour 라는 클래스가 상속되어 있어야 한다

//
public class MovePosition : MonoBehaviour
{
    // 유니티 플로우차트

    // Start ?
    // 플레이 되었을 때 단 한 번만 호출된다

    void Start()
    {
        //// Console 창에 적힌다!
        //Debug.Log("Start");

        //// 위 기능과 똑같지만 경고문구를 달아준다
        //Debug.LogWarning("이 함수는 경고를 표시한다 !");

        //// 위 기능과 같지만, 이 문구가 실행되면
        //// 게임이 일시정지 된다
        //Debug.LogError("이 함수는 에러 문구를 표시한다 !");

    }

    // Update ?
    // 매 프레임마다 호출된다
    // 프레임 ? -> FPS
    // 그냥 계속 반복된다
    void Update()
    {
        // Vector ?
        // x, y, z 값을 가지고 있는 구조체


        //Vector3 position = transform.position;
        //position.z += 0.09f;

        //transform.position = position;

        //transform.Translate(0, 0, 0.01f);
        //if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(-0.01f, 0, 0);
        //}
        //else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(0.01f, 0, 0);
        //}
        //else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.Translate(0, 0, +0.01f);
        //}
        //else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Translate(0, 0, -0.01f);
        //}
       

        // 회전 
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, 1.0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -1.0f);
        }

        // 점프
        // 큐브 안에 있는 컴포넌트(부품) 가져오는 방법
        Rigidbody body = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            body.AddForce(-5.0f, 0, 0, ForceMode.Impulse);

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            body.AddForce(5.0f, 0, 0, ForceMode.Impulse);

        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            body.AddForce(0, 0, 5.0f, ForceMode.Impulse);

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            body.AddForce(0, 0, -5.0f, ForceMode.Impulse);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(0, 300.0f, 0, ForceMode.Impulse);

        }

    }
}
