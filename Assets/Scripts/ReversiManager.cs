using UnityEngine;

public class ReversiManager : MonoBehaviour
{
    [SerializeField]
    public GameObject reversiGameObjects;

    //リバーシの駒を8×8で複製する
    //constで定数を宣言する（後から書き換えることができない）
    const int FIELD_SIZE_X = 8;
    const int FIELD_SIZE_Y = 8;

    public enum spriteStare
    {
        None,//0
        White,//1
        Blace,//2
    }

    private spriteStare[,] _FiledState = new spriteStare[FIELD_SIZE_X, FIELD_SIZE_Y];
    //private SpriteState[,] _Filed
    private void Start()
    {
        for (int x = 0; x < FIELD_SIZE_X; x++) 
        {
            for(int y = 0; y < FIELD_SIZE_X; y++)
            {
                var sprite = Instantiate(reversiGameObjects, new Vector3(-1.122f * x, 0.05f, -1.122f * y), Quaternion.Euler(0, 0, 0));

                _FiledState[x, y] = spriteStare.None;//最初は駒を1つもなしにする
            }
        }
        //状態保存
        _FiledState[3, 3] = spriteStare.Blace;
        _FiledState[3, 4] = spriteStare.White;
        _FiledState[4, 3] = spriteStare.White;
        _FiledState[4, 4] = spriteStare.Blace;
    }

    private void Update()
    {
        
    }
}
