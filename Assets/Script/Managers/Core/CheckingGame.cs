using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingGame : MonoBehaviour
{
//    private IEnumerator coroutine;

//    private bool bombFinished = false;
//    private bool showFinished = false;
//    //private IEnumerator coroutine2;
//    //private bool start;
//    //private bool nextStage;
//    //private bool disappearFunc;

//    public GameObject Count;

//    public void OnCount()
//    {
//        Count.SetActive(true);
//    }
//    private void Start()
//    {
//        GameObject go = Managers.Menu.GetMenu();
//        Count = Managers.Resource.Instantiate("UI/Counter", go.transform);

//        coroutine = Convolution();
//        StartCoroutine(coroutine);

//    }

//    private IEnumerator ShowPattterns()
//    {

//        yield return null;
//    }
//    private IEnumerator Convolution()
//    {
//        {//1
//            OnCount();

//            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//ī��Ʈ �ٿ� ������ ���� ����
//            Count.GetComponent<Count>().finishedCount = false;

//            {//show
//                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Half_Idx()));

//                yield return new WaitUntil(() => showFinished);//show �� ���� ����
//            }

//            OnCount();

//            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//ī��Ʈ �ٿ� ������ ���� ����
//            Count.GetComponent<Count>().finishedCount = false;

//            {//bomb
//                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Half_Idx()));

//                yield return new WaitUntil(() => bombFinished);//��ź ������ ���� ����
//            }
//        }

//        {//2
//            OnCount();

//            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//ī��Ʈ �ٿ� ������ ���� ����
//            Count.GetComponent<Count>().finishedCount = false;

//            {//show
//                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Half_Idx()));

//                yield return new WaitUntil(() => showFinished);//show �� ���� ����

//                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Half_Idx()));

//                yield return new WaitUntil(() => showFinished);//show �� ���� ����
//            }

//            OnCount();

//            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//ī��Ʈ �ٿ� ������ ���� ����
//            Count.GetComponent<Count>().finishedCount = false;

//            {//bomb
//                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Half_Idx()));//1��° ����

//                yield return new WaitUntil(() => bombFinished);//��ź ������ ���� ����

//                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Half_Idx()));//2��° ����

//                yield return new WaitUntil(() => bombFinished);//��ź ������ ���� ����
//            }
//        }

//        {//3
//            OnCount();

//            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//ī��Ʈ �ٿ� ������ ���� ����
//            Count.GetComponent<Count>().finishedCount = false;

//            {//show
//                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Half_Idx()));

//                yield return new WaitUntil(() => showFinished);//show �� ���� ����

//                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Half_Idx()));

//                yield return new WaitUntil(() => showFinished);//show �� ���� ����

//                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Botttom_Arrow()));

//                yield return new WaitUntil(() => showFinished);//show �� ���� ����
//            }

//            OnCount();

//            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//ī��Ʈ �ٿ� ������ ���� ����
//            Count.GetComponent<Count>().finishedCount = false;

//            {//bomb
//                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Half_Idx()));//1��° ����

//                yield return new WaitUntil(() => bombFinished);//��ź ������ ���� ����

//                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Half_Idx()));//2��° ����

//                yield return new WaitUntil(() => bombFinished);//��ź ������ ���� ����

//                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Botttom_Arrow()));//3��° ����

//                yield return new WaitUntil(() => bombFinished);//��ź ������ ���� ����
//            }
//        }




//        yield return null;
//    }

//    private IEnumerator Pattern_To_Show(int[] pattern)
//    {
//        showFinished = false;

//        //yield return new WaitForSeconds(1.0f);
//        for (int i = 0; i < pattern.Length; i++)
//        {
//            Managers.Monster.ActivateShow(pattern[i]);
//        }

//        yield return new WaitForSeconds(1.0f);

//        for (int i = 0; i < pattern.Length; i++)
//        {
//            Managers.Monster.DeactivateShow(pattern[i]);
//        }

//        //yield return new WaitForSeconds(1.0f);

//        showFinished = true;
//    }

//    //���� �ڸ��� ���� -> �����
//    private IEnumerator Pattern_To_Bomb(int[] pattern)
//    {
//        bombFinished = false;

//        //yield return new WaitForSeconds(1.0f);
//        for (int i=0;i<pattern.Length;i++)
//        {
//            Managers.Monster.ActivateBomb(pattern[i]);
//        }

//        yield return new WaitForSeconds(1.0f);

//        for (int i = 0; i < pattern.Length; i++)
//        {
//            Managers.Monster.DeactivateBomb(pattern[i]);
//        }

//        //yield return new WaitForSeconds(1.0f);

//        bombFinished = true;
//    }
//    //void Start()
//    //{
//    //    start = false;
//    //    nextStage = false;
//    //    disappearFunc= false;
//    //    coroutine = Init();
//    //    StartCoroutine(coroutine);
//    //}

//    //void Update()
//    //{
//    //    while(nextStage)
//    //    {
//    //        nextStage = false;
//    //        coroutine = Init();
//    //        StartCoroutine(coroutine);
//    //    }
//    //}
//    //public bool GetStart() { return start; }

//    //private IEnumerator Init()
//    //{
//    //    start = false;
//    //    disappearFunc= false;
//    //    Managers.Resource.Instantiate("UI/Counter");
//    //    Managers.Game.OnGame();
//    //    yield return new WaitUntil(() => Managers.Game.GetFinishShow());
//    //    Managers.Game.FinishShowFalse();
//    //    Managers.Resource.Instantiate("UI/Counter");
//    //    yield return new WaitForSeconds(3.0f);

//    //    start = true;//can move
//    //    //���� ������°� ����
//    //    yield return new WaitUntil(() => start);
//    //    coroutine2 = Disappear_Appear();
//    //    StartCoroutine(coroutine2);
//    //    yield return new WaitUntil(() => disappearFunc);
//    //    nextStage = true;
//    //    yield return new WaitForSeconds(3.0f);

//    //}
//    //private IEnumerator Disappear_Appear()
//    //{
//    //    yield return new WaitForSeconds(2.0f);

//    //    for (int i = 0; i < Managers.Game.GetPatternsList().Count; i++)
//    //    {
//    //        for (int j = 0; j < Managers.Game.GetPatternsList()[i].patternNum.Count; j++)
//    //        {
//    //            int num = Managers.Game.GetPatternsList()[i].patternNum[j];
//    //            Managers.Field.GetGrid((int)num / 4, (int)num % 4).SetActive(false);
//    //        }

//    //        yield return new WaitForSeconds(2.0f);

//    //        for (int j = 0; j < Managers.Game.GetPatternsList()[i].patternNum.Count; j++)
//    //        {
//    //            int num = Managers.Game.GetPatternsList()[i].patternNum[j];
//    //            Managers.Field.GetGrid((int)num / 4, (int)num % 4).SetActive(true);
//    //        }
//    //        yield return new WaitForSeconds(2.0f);
//    //    }
//    //    disappearFunc = true;
//    //}
//}
//public class Patterns
//{
//    public static int[] Get_Left_Half_Idx()
//    {       
//        int[] result = { 0,1,2,5,6,7,10,11,12,15,16,17,20,21,22};
//        return result;
//    }
//    public static int[] Get_Right_Half_Idx()
//    {
//        int[] result = { 2,3,4,7,8,9,12,13,14,17,18,19,22,23,24 };
//        return result;
//    }
//    public static int[] Get_Top_Half_Idx()
//    {
//        int[] result = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
//        return result;
//    }
//    public static int[] Get_Bottom_Half_Idx()
//    {
//        int[] result = { 10,11,12,13,14,15,16,17,18,19,20,21,22,23,24 };
//        return result;
//    }
//    public static int[] Get_Left_Botttom_Arrow()
//    {
//        int[] result = { 4,5,8,10,11,12,15,16,17,20,21,22,23};
//        return result;
//    }
//    public static int[] Get_Right_Botttom_Arrow()
//    {
//        int[] result = { 0, 6, 9, 12, 13, 14, 17, 18, 19, 21, 22, 23, 24 };
//        return result;
//    }
//    public static int[] Get_Left_Top_Arrow()
//    {
//        int[] result = { 0, 1, 2, 3, 5, 6, 7, 10, 11, 12, 15, 18, 24 };
//        return result;
//    }
//    public static int[] Get_Right_Top_Arrow()
//    {
//        int[] result = { 1, 2, 3, 4, 7, 8, 9, 12, 13, 14, 16, 19, 20 };
//        return result;
//    }

}
