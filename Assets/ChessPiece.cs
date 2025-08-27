using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{
    public enum PieceType
    {
        Pawn,
        Knight,
        Bishop,
        Rook,
        Queen,
        King
    }

    [SerializeField] PieceType pieceType;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public Texture chessTexture;
    private void OnDrawGizmosSelected()
    {
        switch (pieceType)
        {
            case PieceType.Pawn:
                Gizmos.DrawGUITexture(new Rect(0, 0, 1, 1), chessTexture);
                break;
            case PieceType.Knight:
                Gizmos.DrawGUITexture(new Rect(0, 0, 1, 1), chessTexture);
                break;
            case PieceType.Bishop:
                Gizmos.DrawGUITexture(new Rect(0, 0, 1, 1), chessTexture);
                break;
            case PieceType.Rook:
                Gizmos.DrawGUITexture(new Rect(0, 0, 1, 1), chessTexture);
                break;
            case PieceType.Queen:
                Gizmos.DrawGUITexture(new Rect(0, 0, 1, 1), chessTexture);
                break;
            case PieceType.King:
                Gizmos.DrawGUITexture(new Rect(0, 0, 1, 1), chessTexture);
                break;
            default:
                break;
        }
    }
}
