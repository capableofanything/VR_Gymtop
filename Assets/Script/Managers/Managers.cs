using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour       //@Managers(GameObject)�� ���Ե�(���۽� ����)
{
    static Managers _instance;
    public static Managers Instance { get { Init(); return _instance; } }
    #region Contents
    FieldManager _field = new FieldManager();
    GameManagerEx _game = new GameManagerEx();
    PlayerManager _player = new PlayerManager();
    MonsterManager _monster = new MonsterManager();
    public static FieldManager Field { get { return Instance._field; } }
    public static GameManagerEx Game { get { return Instance._game; } }
    public static PlayerManager Player { get { return Instance._player; } }
    public static MonsterManager Monster { get { return Instance._monster; } }
    #endregion

    #region Core
    BluetoothManager _bluetooth = new BluetoothManager();
    MenuManager _menu = new MenuManager();
    ResourceManager _resource = new ResourceManager();
    SceneManagerEx _scene = new SceneManagerEx();
    SoundManager _sound = new SoundManager();

    public static BluetoothManager Bluetooth { get { return Instance._bluetooth; } }
    public static MenuManager Menu { get { return Instance._menu; } }
    public static ResourceManager Resource { get { return Instance._resource; } }
    public static SceneManagerEx Scene { get { return Instance._scene; } }
    public static SoundManager Sound { get { return Instance._sound; } }
    
    #endregion

    void Start()
    {
        Init();
    }

    void Update()
    {

    }
    static void Init()
    {
        if (_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject() { name = "@Managers" };
                go.AddComponent<Managers>();

            }
            DontDestroyOnLoad(go);
            _instance = go.GetComponent<Managers>();

            //Manager Init
            _instance._sound.Init();
        }
    }

    public static void Clear()
    {
        //Manager Clear
        Sound.Clear();
        //Scene.Clear();
    }
}