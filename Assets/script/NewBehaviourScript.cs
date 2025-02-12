using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int rows = 5; // ����
    public int columns = 5; // ����
    public float spacing = 2f; // ����֮��ļ��
    public Material earth; // ���������Զ������

    void Start()
    {
        // ѭ��������������
        for (int x = 0; x < columns; x++)
        {
            for (int z = 0; z < rows; z++)
            {
                // ����ÿ�������λ��
                Vector3 position = new Vector3(x * spacing, 0f, z * spacing);

                // ����һ���µ�����
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                // ���������λ��
                sphere.transform.position = position;

                // ����Զ�������Ƿ��Ѿ���ֵ
                if (earth != null)
                {
                    // ��ȡ����� Renderer ���
                    Renderer renderer = sphere.GetComponent<Renderer>();
                    // Ϊ����Ӧ���Զ������
                    renderer.material = earth;
                }
            }
        }
    }
}
