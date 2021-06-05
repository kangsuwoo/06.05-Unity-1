using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ݵ�� MonoBehavipour ��� Ŭ������ ��ӵǾ� �־�� �Ѵ�

//
public class MovePosition : MonoBehaviour
{
    // ����Ƽ �÷ο���Ʈ

    // Start ?
    // �÷��� �Ǿ��� �� �� �� ���� ȣ��ȴ�

    void Start()
    {
        //// Console â�� ������!
        //Debug.Log("Start");

        //// �� ��ɰ� �Ȱ����� ������� �޾��ش�
        //Debug.LogWarning("�� �Լ��� ��� ǥ���Ѵ� !");

        //// �� ��ɰ� ������, �� ������ ����Ǹ�
        //// ������ �Ͻ����� �ȴ�
        //Debug.LogError("�� �Լ��� ���� ������ ǥ���Ѵ� !");

    }

    // Update ?
    // �� �����Ӹ��� ȣ��ȴ�
    // ������ ? -> FPS
    // �׳� ��� �ݺ��ȴ�
    void Update()
    {
        // Vector ?
        // x, y, z ���� ������ �ִ� ����ü


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
       

        // ȸ�� 
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, 1.0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -1.0f);
        }

        // ����
        // ť�� �ȿ� �ִ� ������Ʈ(��ǰ) �������� ���
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
