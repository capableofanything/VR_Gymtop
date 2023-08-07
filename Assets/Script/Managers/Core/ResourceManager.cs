using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager 
{

    //prefab�� �ҷ����� �Լ�
    //path: "Prefabs/Prefab��"�� ���
    public T Load<T>(string path) where T : Object      //where(����): T�� Object�� ��ڹ޴´�(or Object�̴�)
   
    {
        //pool�� ���� �̹� load�� original�� �ִٸ� ��������
        //Prefab�� ���
        //Loading�� ���̱� ���ؼ� ���
        if (typeof(T) == typeof(GameObject))
        {
            //�̸� ����
            string name = path;
            int index = name.LastIndexOf('/');
            if (index > 0)
                name = name.Substring(index + 1);



        }

        return Resources.Load<T>(path);     //���� ResourcesŬ������ �����ϴ�Load (�ҷ�����)�Լ�
    }

    //prefab�� �ҷ����� �����ϴ� ���� �ѹ��� �ذ��ϴ� �Լ�
    public GameObject Instantiate(string path, Transform parent = null)
    {
        //prefab�� �ҷ����� �ܰ�(���� Load�Լ� ���)
        GameObject original = Load<GameObject>($"Prefabs/{path}");  //���(path)�� Asset>Resources>Prefab ���� �Ͽ� ��� 
        if (original == null)       //�ҷ����� ���ϸ�
        {
            Debug.Log($"Failed to load prefab : {path}");
            return null;
        }



        //poolable ������Ʈ�� �ƴ϶��(�ҷ��� prefab�� ����)
        GameObject go = Object.Instantiate(original, parent);
        go.name = original.name;
        return go;
    }

    public void Destroy(GameObject go)
    {
        if (go == null)
            return;


        //�ƴ϶��
        Object.Destroy(go);     //Object �ʼ� (��� ���� ����)
    }
}
