//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

////Object �� pool
//class Pool
//{
//    //pool�� ���� ������Ʈ(Prefab)�� ����
//    public GameObject Original { get; private set; }
//    //pool�� root ������Ʈ : push�� ������Ʈ�� �θ� ������Ʈ("@Pool_Root" ������ "Prefab��_ROOT")
//    public Transform Root { get; set; }

//    //pool�� push�� ������Ʈ�� ����ִ� stack
//    Stack<Poolable> _poolStack = new Stack<Poolable>();

//    //pool�� root������Ʈ ����
//    public void Init(GameObject original, int count = 15)       //count: �Ѱ��� Prefab���� ��� clone�� ����� ������ ����(����Ʈ �� :5)
//    {
//        Original = original;
//        Root = new GameObject().transform;
//        Root.name = $"{original.name}_ROOT";

//        for (int i = 0; i < count; i++)
//            Push(Create());                             //37���� Push

//    }

//    //pool�� �� object ����
//    Poolable Create()
//    {
//        GameObject go = Object.Instantiate(Original);
//        go.name = Original.name;                        //Prefab ��� ������ ���� GameObject ����
//        //return go.GetOrAddComponent<Poolable>();        //Poolable ������Ʈ �߰�
//    }

//    //������Ʈ�� pool�� ����ִ´� (= Destroy)
//    public void Push(Poolable poolable)                 //���⼭ poolable�� prefab���� ������ GameObject �ϳ�
//    {
//        if (poolable == null)
//            return;

//        //poolable�� pool�� �ű�� ��Ȱ��ȭ
//        poolable.transform.SetParent(Root);
//        poolable.gameObject.SetActive(false);
//        poolable.IsUsing = false;

//        _poolStack.Push(poolable);                      //���� �ִ� Push �Լ�
//    }

//    //������Ʈ�� pool���� ������ (= Instantiate)
//    public Poolable Pop(Transform parent)               //parent�� "@Pool_Root" ������ "Prefab��_ROOT"���� �Ѱ��� �����ͼ� ���̰� ���� �θ� Ŭ����
//    {
//        //pop�� ������Ʈ
//        Poolable poolable;

//        //pool�� ���� ������Ʈ�� �ִٸ�
//        if (_poolStack.Count > 0)
//            poolable = _poolStack.Pop();
//        //���ٸ� ����(Stack�� 5���� ����� ���Ҵµ� ���� 5���� ��� IsUsing ���·� ���� ��� ������ Stack �ۿ� ��ġ �ϸ�)
//        else
//            poolable = Create();

//        //������Ʈ Ȱ��ȭ
//        poolable.gameObject.SetActive(true);

//        //DontDestroyOnLoad ������ : DontDestroyOnLoad ���Ͽ� ���� ��������� �������ʴ��� ������
//        if (parent == null)
//            poolable.transform.SetParent(Managers.Scene.CurrentScene.transform);// = Managers.Scene.CurrentScene.transform;
//        else
//            poolable.transform.SetParent(parent);

//        poolable.IsUsing = true;

//        return poolable;

//    }
//}

////�������� ����� �� ���� ResourceManager���� �˾Ƽ� ���
//public class PoolManager        //"@Pool_Root" ����
//{
//    //object name�� key�� ���� pool dictionary
//    Dictionary<string, Pool> _poolDict = new Dictionary<string, Pool>();      //"@Pool_Root" ���Ͽ� ���� ���� Pool�� ����(����)
//    //pool���� �θ� ������Ʈ
//    Transform _root;

//    public void Init()
//    {
//        if(_root == null)
//        {
//            _root = new GameObject { name = "@Pool_Root" }.transform;
//            Object.DontDestroyOnLoad(_root);
//        }
//    }

//    //pool �����ϰ� dictionary�� �߰�
//    public void CreatePool(GameObject original, int count = 15)
//    {
//        Pool pool = new Pool();                     //�� Pool ����
//        pool.Init(original, count);                 //pool �ʱ�ȭ
//        pool.Root.SetParent(_root);                   //���� Pool��  "@Pool_Root" ���Ͽ� ��ġ

//        _poolDict.Add(original.name, pool);         //���� Pool Dictionary�� �߰�
//    }

//    //pool�� �ִٸ� pool�� push ������ destroy
//    public void Push(Poolable poolable)             //�� ����� poolabke(Clone)�� �ٽ�  "@Pool_Root" ������ Pool�� �ݳ�
//    {
//        //poolable�� pool�� ���ٸ� �׳� destroy
//        string name = poolable.gameObject.name;
//        if(_poolDict.ContainsKey(name) == false)
//        {
//            GameObject.Destroy(poolable.gameObject);
//            return;
//        }

//        _poolDict[name].Push(poolable);             //PoolŬ������ Push�Լ� ȣ��
//    }

//    //"@Pool_Root" ������ Pool���� poolable(Clone)�� ���� parent ������ ���δ�
//    public Poolable Pop(GameObject original, Transform parent =null)
//    {
//        //pool�� ���ٸ� pool���� �� pop
//        if (_poolDict.ContainsKey(original.name) == false)
//            CreatePool(original);

//        return _poolDict[original.name].Pop(parent);        //PoolŬ������ Pop�Լ� ȣ��
//    }

//    public GameObject GetOriginal(string name)              //�ش� Pool�� ����� �Ǿ��� Prefab�� ������  //name�� "Prefab��"
//    {
//        if (_poolDict.ContainsKey(name) == false)
//            return null;
//        return _poolDict[name].Original;
//    }

//    //Scene �̵��� ��� pool������Ʈ ����
//    public void Clear()
//    {
//        foreach(Transform child in _root)
//        {
//            GameObject.Destroy(child.gameObject);
//        }

//        _poolDict.Clear();
//    }
//}
