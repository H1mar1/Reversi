using UnityEngine;

public class ReversiManager : MonoBehaviour
{
    [SerializeField]
    public GameObject reversiGameObjects;

    //���o�[�V�̋��8�~8�ŕ�������
    //const�Œ萔��錾����i�ォ�珑�������邱�Ƃ��ł��Ȃ��j
    const int FIELD_SIZE_X = 8;
    const int FIELD_SIZE_8 = 8;

    private void Start()
    {
        for (int x = 0; x < FIELD_SIZE_X; x++) 
        {
            for(int y = 0; y < FIELD_SIZE_X; y++)
            {
                var sprite = Instantiate(reversiGameObjects, new Vector3(-1.122f * x, 0.5f, -1.122f * y), Quaternion.Euler(70, 0, 0));
            }
        }
    }
}
