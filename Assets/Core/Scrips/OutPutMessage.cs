using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutPutMessage : MonoBehaviour
{
    // �� ������Ʈ�� ���� ��ü��
    // �ٸ� �ݶ��̴� (Collider, Rigidbody) �Ǵ� ����Ʈ�ٵ� ���� ��ü�� ������ 
    // ȣ��ȴ�
    private void OnCollisionEnter(Collision collision)
    {
        // rich Text?
        // �����ִ� ���ڿ� <b> ���� <b> -> ���� �۾�
        Debug.Log("<b> You Win ! <b>");
    }
}
