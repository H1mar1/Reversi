using UnityEngine;

public class ReversiManager : MonoBehaviour
{
    [SerializeField]
    public GameObject reversiGameObjects;

    //���o�[�V�̋��8�~8�ŕ�������
    //const�Œ萔��錾����i�ォ�珑�������邱�Ƃ��ł��Ȃ��j
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

                _FiledState[x, y] = spriteStare.None;//�ŏ��͋��1���Ȃ��ɂ���
            }
        }
        //��ԕۑ�
        _FiledState[3, 3] = spriteStare.Blace;
        _FiledState[3, 4] = spriteStare.White;
        _FiledState[4, 3] = spriteStare.White;
        _FiledState[4, 4] = spriteStare.Blace;
    }

    private void Update()
    {
        
    }
}
