using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMover
{
    public class Board
    {
        public bool White_to_move
        {
            get;
        }
        public KeyValuePair<KeyValuePair<int,int>,dynamic> Position
        {
            get;
        }
        public int Move
        {
            get;
        }
        public int Hmclock
        {
            get;
        }
        public string Lastmove
        {
            get;
        }
        public bool BQ_Castleable
        {
            get;
        }
        public bool BK_Castleable
        {
            get;
        }
        public bool WQ_Castleable
        {
            get;
        }
        public bool WK_Castleable
        {
            get;
        }
        public Board(KeyValuePair<KeyValuePair<int, int>, dynamic> pos, bool wtm,int m,int hmc,string lm,bool bqcastle,bool bkcastle,bool wqcastle,bool wkcastle)
        {
            White_to_move = wtm;
            Position = pos;
            Move = m;
            Hmclock = hmc;
            Lastmove = lm;
            BK_Castleable = bkcastle;
            BQ_Castleable = bqcastle;
            WK_Castleable = wkcastle;
            WQ_Castleable = wqcastle;
        }
    }
    public class Pawn
    {
        public KeyValuePair<int, int> Position;
        public bool Is_black;
        public Pawn(KeyValuePair<int, int> pos,bool is_black)
        {
            Position = pos;
            Is_black = is_black;
        }
    }
    public class Bishop
    {
        public KeyValuePair<int, int> Position;
        public bool Is_black;
        public Bishop(KeyValuePair<int, int> pos, bool is_black)
        {
            Position = pos;
            Is_black = is_black;
        }
    }
    public class Knight 
    {
        public KeyValuePair<int, int> Position;
        public bool Is_black;
        public Knight(KeyValuePair<int, int> pos, bool is_black)
        {
            Position = pos;
            Is_black = is_black;
        }
    }
    public class Rook
    {
        public KeyValuePair<int, int> Position;
        public bool Is_black;
        public Rook(KeyValuePair<int, int> pos, bool is_black)
        {
            Position = pos;
            Is_black = is_black;
        }
    }
    public class Queen 
    {
        public KeyValuePair<int, int> Position;
        public bool Is_black;
        public Queen(KeyValuePair<int, int> pos, bool is_black)
        {
            Position = pos;
            Is_black = is_black;
        }
    }
    static public class ChessHandle { 
        public static KeyValuePair<int,int> SPos_to_Npos(string Spos)
        {
            if (Spos.Length != 2)
            {
                return new KeyValuePair<int,int>(-1,-1);
            }
            int w = -1;
            switch (Spos[0])
            {
                case 'a':
                    w = 1;
                    break;
                case 'b':
                    w = 2;
                    break;
                case 'c':
                    w = 3;
                    break;
                case 'd':
                    w = 4;
                    break;
                case 'e':
                    w = 5;
                    break;
                case 'f':
                    w = 6;
                    break;
                case 'g':
                    w = 7;
                    break;
                case 'h':
                    w = 8;
                    break;
                default:
                    return new KeyValuePair<int, int>(-1, -1);
            }
            int h;
            try
            {
                h = Int32.Parse(Spos[1].ToString());
                if (h > 8 ||h < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                return new KeyValuePair<int, int>(-1, -1);
            }
            return new KeyValuePair<int, int>(w, h);
        }
        public static string NPos_to_Spos(KeyValuePair<int, int> Npos)
        {
            char w = ' ';
            switch (Npos.Key)
            {
                case 1:
                    w = 'a';
                    break;
                case 2:
                    w = 'b';
                    break;
                case 3:
                    w = 'c';
                    break;
                case 4:
                    w = 'd';
                    break;
                case 5:
                    w = 'e';
                    break;
                case 6:
                    w = 'f';
                    break;
                case 7:
                    w = 'g';
                    break;
                case 8:
                    w = 'h';
                    break;
                default:
                    return "";
            }
            string h;
            if (Npos.Value < 0||Npos.Value > 8)
            {
                return "";
            }
            h = Npos.Value.ToString();
            return w + h;
        }
        public static Board FenBoardMaker(string FEN)
        {
            string[] FENS = FEN.Split(' ');
            if(FENS.Length != 6)
            {
                throw new Exception("FEN Error.");
            }
            #region Position(FEN Part 1)
            KeyValuePair<KeyValuePair<int, int>, dynamic> pos;
            int w = 1;int h = 8;
            string[] FENP1 = FENS[0].Split('/');
            if (FENP1.Length != 8)
            {
                throw new Exception("FEN Error.");
            }
            
            #endregion
        }
    }
}
