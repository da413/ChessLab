using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;

public enum PieceType
    {
        Pawn,
        Knight,
        Bishop,
        Rook,
        Queen,
        King
    }

public class ChessPiece : MonoBehaviour
{
    public PieceType pieceType;
    public Color tintColor = Color.white;
    private void OnDrawGizmos()
    {
        UnityEngine.Vector3 piecePos = transform.position;
        String pieceTexture = pieceType.ToString() + ".png";
        Gizmos.DrawIcon(new UnityEngine.Vector3(piecePos.x, piecePos.y, 0), pieceTexture, true, tintColor);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = tintColor;
        UnityEngine.Vector3 piecePos = transform.position;

        switch (pieceType)
        {
            case PieceType.Pawn:
                DrawPawnMoves(piecePos);
                break;
            case PieceType.Knight:
                DrawKnightsMoves(piecePos);
                break;
            case PieceType.Bishop:
                DrawDiagonalMoves(piecePos);
                break;
            case PieceType.Rook:
                DrawStraightMoves(piecePos);
                break;
            case PieceType.Queen:
                DrawDiagonalMoves(piecePos);
                DrawStraightMoves(piecePos);
                break;
            case PieceType.King:
                DrawKingsMoves(piecePos);
                break;
            default:
                break;
        }
    }
    private void DrawKingsMoves(UnityEngine.Vector3 piecePos)
    {
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x - 1, piecePos.y, 0), new UnityEngine.Vector3(piecePos.x + 1, piecePos.y, 0));
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x, piecePos.y - 1, 0), new UnityEngine.Vector3(piecePos.x, piecePos.y + 1, 0));
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x - 1, piecePos.y - 1, 0), new UnityEngine.Vector3(piecePos.x + 1, piecePos.y + 1, 0));
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x + 1, piecePos.y - 1, 0), new UnityEngine.Vector3(piecePos.x - 1, piecePos.y + 1, 0));
    }
    private void DrawKnightsMoves(UnityEngine.Vector3 piecePos)
    {
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x - 1, piecePos.y + 2, 0), new UnityEngine.Vector3(piecePos.x + 1, piecePos.y - 2, 0));
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x - 1, piecePos.y - 2, 0), new UnityEngine.Vector3(piecePos.x + 1, piecePos.y + 2, 0));
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x - 2, piecePos.y + 1, 0), new UnityEngine.Vector3(piecePos.x + 2, piecePos.y - 1, 0));
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x - 2, piecePos.y - 1, 0), new UnityEngine.Vector3(piecePos.x + 2, piecePos.y + 1, 0));
    }
    private void DrawStraightMoves(UnityEngine.Vector3 piecePos)
    {
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x - 8, piecePos.y, 0), new UnityEngine.Vector3(piecePos.x + 8, piecePos.y, 0));
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x, piecePos.y - 8, 0), new UnityEngine.Vector3(piecePos.x, piecePos.y + 8, 0));
    }
    private void DrawDiagonalMoves(UnityEngine.Vector3 piecePos)
    {
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x - 8, piecePos.y - 8, 0), new UnityEngine.Vector3(piecePos.x + 8, piecePos.y + 8, 0));
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x + 8, piecePos.y - 8, 0), new UnityEngine.Vector3(piecePos.x - 8, piecePos.y + 8, 0));
    }
    private void DrawPawnMoves(UnityEngine.Vector3 piecePos)
    {
        Gizmos.DrawLine(new UnityEngine.Vector3(piecePos.x, piecePos.y, 0), new UnityEngine.Vector3(piecePos.x, piecePos.y + 2, 0));
    }
}
