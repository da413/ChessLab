using System.Collections;
using System.Collections.Generic;
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
    public Texture2D pieceTexture;
    private void OnValidate()
    {
        pieceTexture = Resources.Load<Texture2D>($"PieceImages/{pieceType}");
    }
    private void OnDrawGizmos()
    {
        Handles.BeginGUI();
        Color oldColor = GUI.color;
        GUI.color = tintColor;
        GUI.DrawTexture(new Rect(0, 0, 100, 100), pieceTexture);
        GUI.color = oldColor;
        Handles.EndGUI();
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        switch (pieceType)
        {
            case PieceType.Pawn:
                DrawPawnMoves();
                break;
            case PieceType.Knight:
                DrawKnightsMoves();
                break;
            case PieceType.Bishop:
                DrawDiagonalMoves();
                break;
            case PieceType.Rook:
                DrawStraightMoves();
                break;
            case PieceType.Queen:
                DrawDiagonalMoves();
                DrawStraightMoves();
                break;
            case PieceType.King:
                DrawKingsMoves();
                break;
            default:
                break;
        }
    }
    private void DrawKingsMoves()
    {

    }
    private void DrawKnightsMoves()
    {

    }
    private void DrawStraightMoves()
    {

    }
    private void DrawDiagonalMoves()
    {

    }
    private void DrawPawnMoves()
    {

    }
}
